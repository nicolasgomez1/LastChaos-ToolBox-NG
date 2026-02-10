namespace LastChaos_ToolBoxNG
{
    partial class SkillPicker
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
			btnRemoveSkill = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			btnSelect = new Button();
			cbLevelSelector = new ComboBox();
			pbIcon = new PictureBox();
			groupBox1 = new GroupBox();
			tbDescription = new TextBox();
			((ISupportInitialize)pbIcon).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnRemoveSkill
			// 
			btnRemoveSkill.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveSkill.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveSkill.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveSkill.FlatStyle = FlatStyle.Flat;
			btnRemoveSkill.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveSkill.Location = new Point(348, 322);
			btnRemoveSkill.Margin = new Padding(4, 3, 4, 3);
			btnRemoveSkill.Name = "btnRemoveSkill";
			btnRemoveSkill.Size = new Size(263, 27);
			btnRemoveSkill.TabIndex = 1014;
			btnRemoveSkill.Text = "Remove Skill";
			btnRemoveSkill.UseVisualStyleBackColor = true;
			btnRemoveSkill.Click += btnRemoveSkill_Click;
			// 
			// tbSearch
			// 
			tbSearch.BackColor = Color.FromArgb(28, 30, 31);
			tbSearch.BorderStyle = BorderStyle.FixedSingle;
			tbSearch.ForeColor = Color.FromArgb(208, 203, 148);
			tbSearch.Location = new Point(13, 12);
			tbSearch.Margin = new Padding(4, 3, 4, 3);
			tbSearch.Name = "tbSearch";
			tbSearch.Size = new Size(327, 23);
			tbSearch.TabIndex = 1026;
			tbSearch.TextChanged += tbSearch_TextChanged;
			tbSearch.KeyDown += tbSearch_KeyDown;
			// 
			// MainList
			// 
			MainList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			MainList.BackColor = Color.FromArgb(28, 30, 31);
			MainList.BorderStyle = BorderStyle.FixedSingle;
			MainList.ForeColor = Color.FromArgb(208, 203, 148);
			MainList.FormattingEnabled = true;
			MainList.Location = new Point(13, 47);
			MainList.Margin = new Padding(4, 3, 4, 3);
			MainList.Name = "MainList";
			MainList.Size = new Size(327, 302);
			MainList.TabIndex = 1027;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// btnSelect
			// 
			btnSelect.Enabled = false;
			btnSelect.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnSelect.FlatStyle = FlatStyle.Flat;
			btnSelect.ForeColor = Color.FromArgb(208, 203, 148);
			btnSelect.Location = new Point(8, 271);
			btnSelect.Margin = new Padding(4, 3, 4, 3);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(248, 27);
			btnSelect.TabIndex = 1028;
			btnSelect.Text = "Select Skill && Level";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// cbLevelSelector
			// 
			cbLevelSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbLevelSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLevelSelector.Enabled = false;
			cbLevelSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbLevelSelector.FormattingEnabled = true;
			cbLevelSelector.Location = new Point(8, 242);
			cbLevelSelector.Margin = new Padding(4, 3, 4, 3);
			cbLevelSelector.Name = "cbLevelSelector";
			cbLevelSelector.Size = new Size(248, 23);
			cbLevelSelector.TabIndex = 1029;
			// 
			// pbIcon
			// 
			pbIcon.BackgroundImage = Properties.Resources.DefaultSkill;
			pbIcon.ErrorImage = null;
			pbIcon.InitialImage = null;
			pbIcon.Location = new Point(7, 22);
			pbIcon.Margin = new Padding(4, 3, 4, 3);
			pbIcon.Name = "pbIcon";
			pbIcon.Size = new Size(32, 32);
			pbIcon.TabIndex = 13;
			pbIcon.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tbDescription);
			groupBox1.Controls.Add(pbIcon);
			groupBox1.Controls.Add(btnSelect);
			groupBox1.Controls.Add(cbLevelSelector);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(348, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(263, 304);
			groupBox1.TabIndex = 1030;
			groupBox1.TabStop = false;
			groupBox1.Text = "Skill Data";
			// 
			// tbDescription
			// 
			tbDescription.BackColor = Color.FromArgb(40, 40, 40);
			tbDescription.BorderStyle = BorderStyle.None;
			tbDescription.ForeColor = Color.FromArgb(208, 203, 148);
			tbDescription.Location = new Point(8, 60);
			tbDescription.Margin = new Padding(4, 3, 4, 3);
			tbDescription.Multiline = true;
			tbDescription.Name = "tbDescription";
			tbDescription.ReadOnly = true;
			tbDescription.Size = new Size(248, 176);
			tbDescription.TabIndex = 1030;
			// 
			// SkillPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(624, 361);
			Controls.Add(groupBox1);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveSkill);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(640, 400);
			Name = "SkillPicker";
			ShowInTaskbar = false;
			Text = "Skill Picker";
			Load += SkillPicker_LoadAsync;
			((ISupportInitialize)pbIcon).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbLevelSelector;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDescription;
    }
}