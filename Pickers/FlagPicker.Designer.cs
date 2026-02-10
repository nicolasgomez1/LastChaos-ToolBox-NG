namespace LastChaos_ToolBoxNG
{
    partial class FlagPicker
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
			btnCheck = new Button();
			clbFlagList = new CheckedListBox();
			tbFlag = new TextBox();
			label10 = new Label();
			btnSelect = new Button();
			SuspendLayout();
			// 
			// btnCheck
			// 
			btnCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnCheck.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnCheck.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnCheck.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnCheck.FlatStyle = FlatStyle.Flat;
			btnCheck.ForeColor = Color.FromArgb(208, 203, 148);
			btnCheck.Location = new Point(13, 12);
			btnCheck.Margin = new Padding(4, 3, 4, 3);
			btnCheck.Name = "btnCheck";
			btnCheck.Size = new Size(308, 27);
			btnCheck.TabIndex = 9;
			btnCheck.Text = "Check All";
			btnCheck.UseVisualStyleBackColor = true;
			btnCheck.Click += btnCheck_Click;
			// 
			// clbFlagList
			// 
			clbFlagList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			clbFlagList.BackColor = Color.FromArgb(28, 30, 31);
			clbFlagList.BorderStyle = BorderStyle.FixedSingle;
			clbFlagList.CheckOnClick = true;
			clbFlagList.ForeColor = Color.FromArgb(208, 203, 148);
			clbFlagList.FormattingEnabled = true;
			clbFlagList.Location = new Point(15, 45);
			clbFlagList.Margin = new Padding(4, 3, 4, 3);
			clbFlagList.Name = "clbFlagList";
			clbFlagList.Size = new Size(306, 524);
			clbFlagList.TabIndex = 11;
			clbFlagList.SelectedIndexChanged += clbFlagList_SelectedIndexChanged;
			// 
			// tbFlag
			// 
			tbFlag.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbFlag.BackColor = Color.FromArgb(28, 30, 31);
			tbFlag.BorderStyle = BorderStyle.FixedSingle;
			tbFlag.ForeColor = Color.FromArgb(208, 203, 148);
			tbFlag.Location = new Point(52, 574);
			tbFlag.Margin = new Padding(4, 3, 4, 3);
			tbFlag.Name = "tbFlag";
			tbFlag.ReadOnly = true;
			tbFlag.Size = new Size(203, 23);
			tbFlag.TabIndex = 1012;
			tbFlag.TextAlign = HorizontalAlignment.Center;
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label10.AutoSize = true;
			label10.ForeColor = Color.FromArgb(208, 203, 148);
			label10.Location = new Point(15, 578);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(29, 15);
			label10.TabIndex = 1013;
			label10.Text = "Flag";
			label10.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnSelect
			// 
			btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSelect.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnSelect.FlatStyle = FlatStyle.Flat;
			btnSelect.ForeColor = Color.FromArgb(208, 203, 148);
			btnSelect.Location = new Point(263, 572);
			btnSelect.Margin = new Padding(4, 3, 4, 3);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(58, 27);
			btnSelect.TabIndex = 1014;
			btnSelect.Text = "Select";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// FlagPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(334, 611);
			Controls.Add(btnSelect);
			Controls.Add(label10);
			Controls.Add(tbFlag);
			Controls.Add(clbFlagList);
			Controls.Add(btnCheck);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(350, 650);
			Name = "FlagPicker";
			ShowInTaskbar = false;
			Text = "Flag Picker";
			Load += FlagPicker_Load;
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckedListBox clbFlagList;
        private System.Windows.Forms.TextBox tbFlag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelect;
    }
}