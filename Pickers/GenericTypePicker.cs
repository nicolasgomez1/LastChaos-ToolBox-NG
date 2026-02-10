namespace LastChaos_ToolBoxNG
{
	/* Args:
	 *	Form<Parent Form to center the Window>
	 * Returns:
	 *	Int<Type ID>
	// Call and receive implementation
	GenericTypePicker pGenericTypeSelector = new(this);
	if (pGenericTypeSelector.ShowDialog() != DialogResult.OK)
		return;

	int nType = Convert.ToInt32(pGenericTypeSelector.ReturnValues[0]);
	/****************************************/
	public partial class GenericTypePicker : Form
	{
		private readonly Main pMain;
		private Form pParentForm;
		private int nSearchPosition = 0;
		private List<(string, string[])>? listTypesLists;
		public int ReturnValues = -1;

		public GenericTypePicker(Main mainForm, Form ParentForm)
		{
			InitializeComponent();

			pMain = mainForm;
			pParentForm = ParentForm;
		}

		private void GenericTypePicker_Load(object sender, EventArgs e)
		{
			this.Location = new Point(pParentForm.Location.X + (pParentForm.Width - this.Width) / 2, pParentForm.Location.Y + (pParentForm.Height - this.Height) / 2);

			listTypesLists = new List<(string, string[])> { ("IETC Types", Defs.IETCTypes) };

			foreach (var List in listTypesLists)
				cbTypesListSelector.Items.Add(List.Item1);
		}

		private void cbTypesListSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listTypesLists != null)
			{
				foreach (var List in listTypesLists[cbTypesListSelector.SelectedIndex].Item2)
					MainList.Items.Add(List);
			}
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e) { nSearchPosition = pMain.SearchInListBox(tbSearch, e, MainList, nSearchPosition); }

		private void MainList_DoubleClick(object sender, EventArgs e)
		{
			int nIndex = MainList.SelectedIndex;
			if (nIndex != -1)
			{
				DialogResult = DialogResult.OK;

				ReturnValues = nIndex;

				Close();
			}
		}

		private void btnRemoveZone_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;

			ReturnValues = -1;

			Close();
		}

		private void tbSearch_TextChanged(object sender, EventArgs e) { nSearchPosition = 0; }
	}
}
