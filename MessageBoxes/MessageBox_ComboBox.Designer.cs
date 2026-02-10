namespace LastChaos_ToolBoxNG
{
	partial class MessageBox_ComboBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnOk = new Button();
			rtbMessage = new RichTextBox();
			cbSelector = new ComboBox();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOk.BackColor = Color.FromArgb(40, 40, 40);
			btnOk.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnOk.FlatStyle = FlatStyle.Flat;
			btnOk.ForeColor = Color.FromArgb(208, 203, 148);
			btnOk.Location = new Point(252, 63);
			btnOk.Margin = new Padding(4, 3, 4, 3);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(69, 27);
			btnOk.TabIndex = 1012;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = false;
			btnOk.Click += btnOk_Click;
			// 
			// rtbMessage
			// 
			rtbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			rtbMessage.BackColor = Color.FromArgb(40, 40, 40);
			rtbMessage.BorderStyle = BorderStyle.None;
			rtbMessage.ForeColor = Color.FromArgb(208, 203, 148);
			rtbMessage.Location = new Point(13, 12);
			rtbMessage.Margin = new Padding(4, 3, 4, 3);
			rtbMessage.Name = "rtbMessage";
			rtbMessage.ScrollBars = RichTextBoxScrollBars.None;
			rtbMessage.Size = new Size(308, 16);
			rtbMessage.TabIndex = 1015;
			rtbMessage.TabStop = false;
			rtbMessage.Text = "Please Select One";
			// 
			// cbSelector
			// 
			cbSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cbSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbSelector.FormattingEnabled = true;
			cbSelector.Location = new Point(13, 34);
			cbSelector.Margin = new Padding(4, 3, 4, 3);
			cbSelector.Name = "cbSelector";
			cbSelector.Size = new Size(308, 23);
			cbSelector.TabIndex = 1016;
			cbSelector.KeyDown += cbSelector_KeyDown;
			// 
			// MessageBox_ComboBox
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(334, 102);
			Controls.Add(cbSelector);
			Controls.Add(rtbMessage);
			Controls.Add(btnOk);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "MessageBox_ComboBox";
			ShowInTaskbar = false;
			Text = "User ComboBox";
			TopMost = true;
			Load += MessageBox_ComboBox_Load;
			ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.RichTextBox rtbMessage;
		private System.Windows.Forms.ComboBox cbSelector;
	}
}