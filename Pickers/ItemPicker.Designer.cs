namespace LastChaos_ToolBoxNG
{
    partial class ItemPicker
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
			btnRemoveItem = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			btnSelect = new Button();
			pbIcon = new PictureBox();
			groupBox1 = new GroupBox();
			rtbInformation = new RichTextBox();
			((ISupportInitialize)pbIcon).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnRemoveItem
			// 
			btnRemoveItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnRemoveItem.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveItem.FlatStyle = FlatStyle.Flat;
			btnRemoveItem.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveItem.Location = new Point(350, 322);
			btnRemoveItem.Margin = new Padding(4, 3, 4, 3);
			btnRemoveItem.Name = "btnRemoveItem";
			btnRemoveItem.Size = new Size(261, 27);
			btnRemoveItem.TabIndex = 1014;
			btnRemoveItem.Text = "Remove Item";
			btnRemoveItem.UseVisualStyleBackColor = true;
			btnRemoveItem.Click += btnRemoveItem_Click;
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
			btnSelect.Text = "Select Item";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// pbIcon
			// 
			pbIcon.BackgroundImage = Properties.Resources.DefaultItem;
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
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox1.Controls.Add(rtbInformation);
			groupBox1.Controls.Add(pbIcon);
			groupBox1.Controls.Add(btnSelect);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(348, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(263, 304);
			groupBox1.TabIndex = 1030;
			groupBox1.TabStop = false;
			groupBox1.Text = "Item Data";
			// 
			// rtbInformation
			// 
			rtbInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			rtbInformation.BackColor = Color.FromArgb(40, 40, 40);
			rtbInformation.BorderStyle = BorderStyle.None;
			rtbInformation.ForeColor = Color.FromArgb(208, 203, 148);
			rtbInformation.Location = new Point(7, 60);
			rtbInformation.Margin = new Padding(4, 3, 4, 3);
			rtbInformation.Name = "rtbInformation";
			rtbInformation.ReadOnly = true;
			rtbInformation.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
			rtbInformation.Size = new Size(249, 205);
			rtbInformation.TabIndex = 1032;
			rtbInformation.Text = "";
			rtbInformation.ZoomFactor = 1.2F;
			// 
			// ItemPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(624, 361);
			Controls.Add(groupBox1);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveItem);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(640, 400);
			Name = "ItemPicker";
			ShowInTaskbar = false;
			Text = "Item Picker";
			Load += ItemPicker_LoadAsync;
			((ISupportInitialize)pbIcon).EndInit();
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox rtbInformation;
	}
}