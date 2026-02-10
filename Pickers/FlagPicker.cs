namespace LastChaos_ToolBoxNG
{
	/* Args:
	 *	Main<Pointer to Main Form>
	 *	Form<Parent Form to center the Window>
	 *	String array with flag names<Flags Array>
	 *	Long<Actual Flag>
	 * Returns:
	 *	Long<Composed Flag>
	// Call and receive implementation
	FlagPicker pFlagSelector = new(this, Defs.ItemClass, 0);
	if (pFlagSelector.ShowDialog() != DialogResult.OK)
		 return;

	long lFlag = pFlagSelector.ReturnValues;
	/****************************************/
	public partial class FlagPicker : Form
	{
		private Form pParentForm;
		private string[] strFlags;
		public long ReturnValues = 0;

		public FlagPicker(Form ParentForm, string[] strFlags, long lFlag)
		{
			InitializeComponent();

			pParentForm = ParentForm;
			this.strFlags = strFlags;
			ReturnValues = lFlag;
		}

		private void FlagPicker_Load(object sender, EventArgs e)
		{
			this.Location = new Point(pParentForm.Location.X + (pParentForm.Width - this.Width) / 2, pParentForm.Location.Y + (pParentForm.Height - this.Height) / 2);

			clbFlagList.BeginUpdate();

			for (int i = 0; i < strFlags.Length; i++)
			{
				clbFlagList.Items.Add(i + " - " + strFlags[i]);

				clbFlagList.SetItemChecked(i, (ReturnValues & 1L << i) > 0);
			}

			if (strFlags.Length == clbFlagList.CheckedItems.Count)
				btnCheck.Text = "Uncheck All";

			clbFlagList.EndUpdate();

			tbFlag.Text = ReturnValues.ToString();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			long lFlag = 0;
			bool bChecked = (btnCheck.Text.ToString() == "Check All" ? true : false);

			for (int i = 0; i < clbFlagList.Items.Count; ++i)
			{
				clbFlagList.SetItemChecked(i, bChecked);
				lFlag += 1L << i;
			}

			if (!bChecked)
			{
				lFlag = 0;

				for (int i = 0; i < clbFlagList.Items.Count; ++i)
				{
					if (clbFlagList.GetItemChecked(i))
						lFlag += 1L << i;
				}
			}

			tbFlag.Text = lFlag.ToString();

			if (bChecked)
				btnCheck.Text = "Uncheck All";
			else
				btnCheck.Text = "Check All";

			ReturnValues = lFlag;
		}

		private void clbFlagList_SelectedIndexChanged(object sender, EventArgs e)
		{
			long lFlag = 0;

			for (int i = 0; i < clbFlagList.Items.Count; ++i)
			{
				if (clbFlagList.GetItemChecked(i))
					lFlag += 1L << i;
			}

			tbFlag.Text = lFlag.ToString();

			ReturnValues = lFlag;

			clbFlagList.ClearSelected();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;

			Close();
		}
	}
}
