namespace LastChaos_ToolBoxNG
{
	/* Args:
	 *	Form<Parent Form to center the Window>
	 *	String<Prompt to show>
	 *	String<Default Input value>
	 *	String<TextBox Mask Format>
	 * Returns:
	 *	String<Text entered by user>
	// Call and receive implementation
	MessageBox_Input pInput = new(this, "Please enter a value:", "");
	if (pInput.ShowDialog() != DialogResult.OK)
		 return;

	string strOutput = pInput.strOutput;
	/****************************************/
	public partial class MessageBox_Input : Form
	{
		private Form pParentForm;
		public string strOutput = "";

		public MessageBox_Input(Form pParentForm, string strCaption, string strDefaultValue = "", string strTextBoxMask = "")
		{
			InitializeComponent();

			rtbMessage.Text = strCaption;
			mtbInput.Text = strDefaultValue;

			if (strTextBoxMask != "")
				mtbInput.Mask = "0000-00-00";

			this.Width = Math.Max(TextRenderer.MeasureText(strCaption, rtbMessage.Font).Width, 350);
			this.pParentForm = pParentForm;
		}

		private void MessageBox_Input_Load(object sender, EventArgs e)
		{
			this.Location = new Point(pParentForm.Location.X + (pParentForm.Width - this.Width) / 2, pParentForm.Location.Y + (pParentForm.Height - this.Height) / 2);

			(new ToolTip()).SetToolTip(mtbInput, "Press Enter to Close this Window");
		}

		private void MessageBox_Input_Shown(object sender, EventArgs e) {
			mtbInput.Focus();
			mtbInput.Select(mtbInput.Text.Length, 0);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			strOutput = mtbInput.Text.ToString();

			Close();
		}

		private void mtbInput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnOk_Click(sender, e);
		}
	}
}
