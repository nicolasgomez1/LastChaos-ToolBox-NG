namespace LastChaos_ToolBoxNG
{
    partial class NPCPicker
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
			btnRemoveNPC = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			btnSelect = new Button();
			groupBox1 = new GroupBox();
			rtbInformation = new RichTextBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnRemoveNPC
			// 
			btnRemoveNPC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnRemoveNPC.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveNPC.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveNPC.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveNPC.FlatStyle = FlatStyle.Flat;
			btnRemoveNPC.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveNPC.Location = new Point(348, 322);
			btnRemoveNPC.Margin = new Padding(4, 3, 4, 3);
			btnRemoveNPC.Name = "btnRemoveNPC";
			btnRemoveNPC.Size = new Size(263, 27);
			btnRemoveNPC.TabIndex = 1014;
			btnRemoveNPC.Text = "Remove NPC";
			btnRemoveNPC.UseVisualStyleBackColor = true;
			btnRemoveNPC.Click += btnRemoveNPC_Click;
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
			MainList.Location = new Point(13, 47);
			MainList.Margin = new Padding(4, 3, 4, 3);
			MainList.Name = "MainList";
			MainList.Size = new Size(327, 302);
			MainList.TabIndex = 1027;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
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
			btnSelect.Location = new Point(8, 271);
			btnSelect.Margin = new Padding(4, 3, 4, 3);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(247, 27);
			btnSelect.TabIndex = 1028;
			btnSelect.Text = "Select NPC";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox1.Controls.Add(rtbInformation);
			groupBox1.Controls.Add(btnSelect);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(348, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(263, 304);
			groupBox1.TabIndex = 1030;
			groupBox1.TabStop = false;
			groupBox1.Text = "NPC Data";
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
			rtbInformation.Size = new Size(247, 243);
			rtbInformation.TabIndex = 1031;
			rtbInformation.Text = "";
			rtbInformation.ZoomFactor = 1.2F;
			// 
			// NPCPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(624, 361);
			Controls.Add(groupBox1);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveNPC);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(640, 400);
			Name = "NPCPicker";
			ShowInTaskbar = false;
			Text = "NPC Picker";
			Load += NPCPicker_LoadAsync;
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveNPC;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox rtbInformation;
	}
}