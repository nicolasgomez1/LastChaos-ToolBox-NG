namespace LastChaos_ToolBoxNG
{
	partial class MessageBox_Input
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
			mtbInput = new MaskedTextBox();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOk.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnOk.FlatStyle = FlatStyle.Flat;
			btnOk.ForeColor = Color.FromArgb(208, 203, 148);
			btnOk.Location = new Point(252, 64);
			btnOk.Margin = new Padding(4, 3, 4, 3);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(69, 27);
			btnOk.TabIndex = 1012;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
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
			rtbMessage.Size = new Size(308, 17);
			rtbMessage.TabIndex = 1015;
			rtbMessage.TabStop = false;
			rtbMessage.Text = "Message";
			// 
			// mtbInput
			// 
			mtbInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			mtbInput.BackColor = Color.FromArgb(28, 30, 31);
			mtbInput.BorderStyle = BorderStyle.FixedSingle;
			mtbInput.ForeColor = Color.FromArgb(208, 203, 148);
			mtbInput.Location = new Point(12, 35);
			mtbInput.Name = "mtbInput";
			mtbInput.Size = new Size(309, 23);
			mtbInput.TabIndex = 1016;
			mtbInput.KeyDown += mtbInput_KeyDown;
			// 
			// MessageBox_Input
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(334, 103);
			Controls.Add(mtbInput);
			Controls.Add(rtbMessage);
			Controls.Add(btnOk);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "MessageBox_Input";
			ShowInTaskbar = false;
			Text = "User Input";
			TopMost = true;
			Load += MessageBox_Input_Load;
			Shown += MessageBox_Input_Shown;
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.RichTextBox rtbMessage;
		private MaskedTextBox mtbInput;
	}
}