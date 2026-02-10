namespace LastChaos_ToolBoxNG
{
	public partial class FiltersManager : Form
	{
		private readonly Main pMain;

		public FiltersManager(Main mainForm)
		{
			InitializeComponent();

			pMain = mainForm;
		}

		private void FiltersManager_Load(object sender, EventArgs e)
		{
			MainList.BeginUpdate();

			IniData pData = (new FileIniDataParser()).ReadFile(pMain.pSettings.SettingsFile);

			foreach (KeyData Key in pData["ControlPanelFilters"])
				MainList.Items.Add(new Main.ListBoxItem { Text = Key.KeyName });

			MainList.EndUpdate();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool bSuccess = true;
			MessageBox_Input pInput = new(this, "Please enter new Filter:");

			if (pInput.ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileIniDataParser pParser = new();
					IniData pData = pParser.ReadFile(pMain.pSettings.SettingsFile);

					pData["ControlPanelFilters"].AddKey(pInput.strOutput);

					pParser.WriteFile(pMain.pSettings.SettingsFile, pData);
				}
				catch (Exception ex)
				{
					pMain.Logger(LogTypes.Error, $"Filters Manager > {ex.Message}.");

					bSuccess = false;
				}
				finally
				{
					if (bSuccess)
					{
						MainList.Items.Add(new Main.ListBoxItem { Text = pInput.strOutput });
						MainList.SelectedIndex = MainList.Items.Count - 1;
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool bSuccess = true;
			int nSelected = MainList.SelectedIndex;

			if (nSelected != -1)
			{
				try
				{
					FileIniDataParser pParser = new();
					IniData pData = pParser.ReadFile(pMain.pSettings.SettingsFile);

					pData["ControlPanelFilters"].RemoveKey(MainList.Text);

					pParser.WriteFile(pMain.pSettings.SettingsFile, pData);
				}
				catch (Exception ex)
				{
					pMain.Logger(LogTypes.Error, $"Filters Manager > {ex.Message}.");

					bSuccess = false;
				}
				finally
				{
					if (bSuccess)
					{
						MainList.Items.RemoveAt(nSelected);
						MainList.SelectedIndex = MainList.Items.Count - 1;
					}
				}
			}
		}
	}
}
