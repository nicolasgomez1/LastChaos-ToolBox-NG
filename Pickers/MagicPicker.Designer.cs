namespace LastChaos_ToolBoxNG
{
	partial class MagicPicker
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
			btnRemoveMagic = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			groupBox1 = new GroupBox();
			rtbInformation = new RichTextBox();
			btnSelect = new Button();
			cbLevelSelector = new ComboBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnRemoveMagic
			// 
			btnRemoveMagic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemoveMagic.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveMagic.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveMagic.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveMagic.FlatStyle = FlatStyle.Flat;
			btnRemoveMagic.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveMagic.Location = new Point(349, 552);
			btnRemoveMagic.Margin = new Padding(4, 3, 4, 3);
			btnRemoveMagic.Name = "btnRemoveMagic";
			btnRemoveMagic.Size = new Size(262, 27);
			btnRemoveMagic.TabIndex = 1014;
			btnRemoveMagic.Text = "Remove Magic";
			btnRemoveMagic.UseVisualStyleBackColor = true;
			btnRemoveMagic.Click += btnRemoveMagic_Click;
			// 
			// tbSearch
			// 
			tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbSearch.BackColor = Color.FromArgb(28, 30, 31);
			tbSearch.BorderStyle = BorderStyle.FixedSingle;
			tbSearch.ForeColor = Color.FromArgb(208, 203, 148);
			tbSearch.Location = new Point(13, 12);
			tbSearch.Margin = new Padding(4, 3, 4, 3);
			tbSearch.Name = "tbSearch";
			tbSearch.Size = new Size(325, 23);
			tbSearch.TabIndex = 1026;
			tbSearch.TextChanged += tbSearch_TextChanged;
			tbSearch.KeyDown += tbSearch_KeyDown;
			// 
			// MainList
			// 
			MainList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			MainList.BackColor = Color.FromArgb(28, 30, 31);
			MainList.BorderStyle = BorderStyle.FixedSingle;
			MainList.ForeColor = Color.FromArgb(208, 203, 148);
			MainList.FormattingEnabled = true;
			MainList.Location = new Point(13, 52);
			MainList.Margin = new Padding(4, 3, 4, 3);
			MainList.Name = "MainList";
			MainList.Size = new Size(325, 527);
			MainList.TabIndex = 1027;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rtbInformation);
			groupBox1.Controls.Add(btnSelect);
			groupBox1.Controls.Add(cbLevelSelector);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(346, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(265, 534);
			groupBox1.TabIndex = 1032;
			groupBox1.TabStop = false;
			groupBox1.Text = "Magic Data";
			// 
			// rtbInformation
			// 
			rtbInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			rtbInformation.BackColor = Color.FromArgb(40, 40, 40);
			rtbInformation.BorderStyle = BorderStyle.None;
			rtbInformation.ForeColor = Color.FromArgb(208, 203, 148);
			rtbInformation.Location = new Point(8, 22);
			rtbInformation.Margin = new Padding(4, 3, 4, 3);
			rtbInformation.Name = "rtbInformation";
			rtbInformation.ReadOnly = true;
			rtbInformation.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
			rtbInformation.Size = new Size(249, 444);
			rtbInformation.TabIndex = 1030;
			rtbInformation.Text = "";
			rtbInformation.ZoomFactor = 1.2F;
			// 
			// btnSelect
			// 
			btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnSelect.Enabled = false;
			btnSelect.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnSelect.FlatStyle = FlatStyle.Flat;
			btnSelect.ForeColor = Color.FromArgb(208, 203, 148);
			btnSelect.Location = new Point(8, 501);
			btnSelect.Margin = new Padding(4, 3, 4, 3);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(249, 27);
			btnSelect.TabIndex = 1028;
			btnSelect.Text = "Select Magic && Level";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// cbLevelSelector
			// 
			cbLevelSelector.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			cbLevelSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbLevelSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLevelSelector.Enabled = false;
			cbLevelSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbLevelSelector.FormattingEnabled = true;
			cbLevelSelector.Location = new Point(8, 472);
			cbLevelSelector.Margin = new Padding(4, 3, 4, 3);
			cbLevelSelector.Name = "cbLevelSelector";
			cbLevelSelector.Size = new Size(249, 23);
			cbLevelSelector.TabIndex = 1029;
			// 
			// MagicPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(624, 591);
			Controls.Add(groupBox1);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveMagic);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(640, 630);
			Name = "MagicPicker";
			ShowInTaskbar = false;
			Text = "Magic Picker";
			FormClosing += Picker_FormClosing;
			Load += MagicPicker_LoadAsync;
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveMagic;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ListBox MainList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.ComboBox cbLevelSelector;
		private System.Windows.Forms.RichTextBox rtbInformation;
	}
}