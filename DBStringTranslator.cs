namespace LastChaos_ToolBoxNG
{
	public partial class DBStringTranslator : Form
	{
		private readonly Main pMain;

		public DBStringTranslator(Main mainForm)
		{
			InitializeComponent();

			pMain = mainForm;
		}

		private void DBStringTranslator_Load(object sender, EventArgs e)
		{
			cbTableSelector.BeginUpdate();

			foreach (var StringTypeData in Defs.StringTypes)
				cbTableSelector.Items.Add(StringTypeData.Key);

			cbTableSelector.EndUpdate();
			cbTableSelector.SelectedIndex = 0;
			
			cbOutputLanguageSelector.BeginUpdate();

			foreach (var NationData in Defs.LanguageCodes)
				cbOutputLanguageSelector.Items.Add(NationData.Key);

			cbOutputLanguageSelector.EndUpdate();
			cbOutputLanguageSelector.SelectedIndex = 0;
		}
		
		private void btnTranslate_Click(object sender, EventArgs e)
		{
			btnTranslate.Enabled = false;
			
			TranslateTable(cbTableSelector.Text, cbOutputLanguageSelector.Text);
		}

		private void TranslateTable(string strStringType, string strNation)
		{
#if DEBUG
			Stopwatch stopwatch = Stopwatch.StartNew();
#endif
			int i = 0;
			string? strTranslatedString, strFilePath = "SQLDumps", strColumnSuffix = strNation.ToLower();
			StringBuilder strbuilderQuery = new();
			List<string> listColumns = new();
			Defs.StringType StringTableData = Defs.StringTypes[strStringType];
			Defs.NationCharSetNPostfix pNationCharsetNPostfix = Defs.NationsCharsetsNPostfix[strNation];

			if (rbDumpToFile.Checked)
			{
				if (!Directory.Exists(strFilePath))
					Directory.CreateDirectory(strFilePath);

				strFilePath += $"\\{StringTableData.FileName}_{strColumnSuffix}.sql";
			}

			pMain.Logger(LogTypes.Message, $"Translating: {StringTableData.TableName} Table...");

			foreach (string strColumnName in StringTableData.Columns) // Iterate over each column
			{
				if (i == 0) // The first one generally is the index, don't need add postfix to it.
					listColumns.Add(strColumnName);
				else    // The rest of columns are strings, iterate over each nation checked and add the postfix of each nation to each string column, to do a big request with all required strings.
					listColumns.Add(strColumnName + "_usa");

				i++;
			}

			DataTable? pTable = pMain.QuerySelect(pNationCharsetNPostfix.Charset, $"{StringTableData.Clause} {string.Join(", ", listColumns)} FROM {pMain.pSettings.DBData}.{StringTableData.TableName} WHERE {StringTableData.Columns[0]} >= {tbStartFromRowNumber.Text} ORDER BY {StringTableData.Columns[0]};");
			if (pTable != null)
			{
				pbProgress.Minimum = 0;
				pbProgress.Maximum = pTable.Rows.Count - 1;
				pbProgress.Value = 0;

				using (HttpClient httpClient = new())
				{
					i = 0;
					httpClient.DefaultRequestHeaders.Add("User-Agent", "C# HttpClient");

					if (rbGoogle.Checked)
					{
						JsonElement root;

						foreach (DataRow pRow in pTable.Rows)
						{
							strbuilderQuery.Append($"UPDATE {StringTableData.TableName} SET");

							for (int j = 1; j < listColumns.Count; j++)
							{
								using (HttpResponseMessage httpResponse = httpClient.GetAsync($"https://translate.googleapis.com/translate_a/single?client=gtx&sl=en&tl={Defs.LanguageCodes[strNation]}&dt=t&q=" + (pRow[listColumns[j]].ToString() ?? string.Empty).Replace("\n", "%0A")).Result)
								{
									if (httpResponse.IsSuccessStatusCode)
									{
										strTranslatedString = StringTableData.TableName + " ID: " + pRow[listColumns[0]];

										using (JsonDocument jsonData = JsonDocument.Parse(httpResponse.Content.ReadAsStringAsync().Result))
										{
											root = jsonData.RootElement[0];

											if (root.ValueKind == JsonValueKind.Array)
												strTranslatedString = pMain.EscapeChars(root[0][0].GetString());
										}

										strbuilderQuery.Append($" {StringTableData.Columns[j]}_{strColumnSuffix}='{strTranslatedString}'");
									}
									else
									{
										pMain.Logger(LogTypes.Error, $"DataBase String Translator > Table: {StringTableData.TableName} ID: {pRow[listColumns[0]]} HTTP Request failed: " + httpResponse.StatusCode);
									}
								}

								if ((j + 1) == listColumns.Count)
									strbuilderQuery.Append($" WHERE {listColumns[0]}={pRow[listColumns[0]]};\r\n");
							}
							
							pbProgress.Value = i;

							i++;
						}
					}
					else
					{
						httpClient.DefaultRequestHeaders.Add("Authorization", "DeepL-Auth-Key " + pMain.pSettings.DeepLAPIKey);

						foreach (DataRow pRow in pTable.Rows)
						{
							strbuilderQuery.Append($"UPDATE {StringTableData.TableName} SET");

							for (int j = 1; j < listColumns.Count; j++)
							{
								using (HttpResponseMessage httpResponse = httpClient.GetAsync(pMain.pSettings.DeepLURL + $"?text={(pRow[listColumns[j]].ToString() ?? string.Empty).Replace("\n", "%0A")}&source_lang=EN&target_lang=" + Defs.LanguageCodes[strNation]).Result)
								{
									if (httpResponse.IsSuccessStatusCode)
									{
										using (JsonDocument jsonData = JsonDocument.Parse(httpResponse.Content.ReadAsStringAsync().Result))
											strTranslatedString = jsonData.RootElement.GetProperty("translations")[0].GetProperty("text").GetString();

										if (strTranslatedString?.Length <= 0)
											strTranslatedString = StringTableData.TableName + " ID: " + pRow[listColumns[0]];

										strbuilderQuery.Append($" {StringTableData.Columns[j]}_{strColumnSuffix}='{pMain.EscapeChars(strTranslatedString ?? string.Empty)}'");
									}
									else
									{
										pMain.Logger(LogTypes.Error, $"DataBase String Translator > Table: {StringTableData.TableName} ID: {pRow[listColumns[0]]} HTTP Request failed: " + httpResponse.StatusCode);
									}
								}

								if ((j + 1) == listColumns.Count)
									strbuilderQuery.Append($" WHERE {listColumns[0]}={pRow[listColumns[0]]};\r\n");
							}

							pbProgress.Value = i;

							i++;
						}
					}
				}

				pTable.Dispose();
			}
#if DEBUG
			stopwatch.Stop();
#endif
			if (rbDumpToFile.Checked)
			{
				File.WriteAllText(strFilePath, strbuilderQuery.ToString());
#if DEBUG
				pMain.Logger(LogTypes.Success, $"Translate Done: {strFilePath} Done! (Took: {stopwatch.ElapsedMilliseconds}ms)");
#else
				pMain.Logger(LogTypes.Success, $"Translate Done: {strFilePath} Done!");
#endif
			}
			else
			{
				if (pMain.QueryUpdateInsertDelete(pNationCharsetNPostfix.Charset, strbuilderQuery.ToString(), out long _, false))
				{
#if DEBUG
					pMain.Logger(LogTypes.Success, $"Translate Done: {StringTableData.TableName} Updated! (Took: {stopwatch.ElapsedMilliseconds}ms)");
#else
					pMain.Logger(LogTypes.Success, $"Translate Done: {StringTableData.TableName} Updated!");
#endif
				}
			}

			btnTranslate.Enabled = true;
		}
	}
}
