namespace LastChaos_ToolBoxNG
{
	partial class QuestPicker
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
			btnRemoveOption = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			groupBox1 = new GroupBox();
			rtbInformation = new RichTextBox();
			btnSelect = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnRemoveOption
			// 
			btnRemoveOption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemoveOption.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveOption.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveOption.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveOption.FlatStyle = FlatStyle.Flat;
			btnRemoveOption.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveOption.Location = new Point(348, 552);
			btnRemoveOption.Margin = new Padding(4, 3, 4, 3);
			btnRemoveOption.Name = "btnRemoveOption";
			btnRemoveOption.Size = new Size(323, 27);
			btnRemoveOption.TabIndex = 1014;
			btnRemoveOption.Text = "Remove Quest";
			btnRemoveOption.UseVisualStyleBackColor = true;
			btnRemoveOption.Click += btnRemove_Click;
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
			tbSearch.Size = new Size(327, 23);
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
			MainList.Size = new Size(327, 527);
			MainList.TabIndex = 1027;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rtbInformation);
			groupBox1.Controls.Add(btnSelect);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(348, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(323, 534);
			groupBox1.TabIndex = 1032;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quest Data";
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
			rtbInformation.Size = new Size(307, 473);
			rtbInformation.TabIndex = 1030;
			rtbInformation.Text = "";
			rtbInformation.ZoomFactor = 1.2F;
			// 
			// btnSelect
			// 
			btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnSelect.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnSelect.FlatStyle = FlatStyle.Flat;
			btnSelect.ForeColor = Color.FromArgb(208, 203, 148);
			btnSelect.Location = new Point(8, 501);
			btnSelect.Margin = new Padding(4, 3, 4, 3);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(307, 27);
			btnSelect.TabIndex = 1028;
			btnSelect.Text = "Select Quest";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// QuestPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(684, 591);
			Controls.Add(groupBox1);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveOption);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(700, 630);
			Name = "QuestPicker";
			ShowInTaskbar = false;
			Text = "Quest Picker";
			Load += QuestPicker_LoadAsync;
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveOption;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ListBox MainList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.RichTextBox rtbInformation;
	}
}