namespace LastChaos_ToolBoxNG
{
    partial class RareOptionPicker
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
			btnRemoveRareOption = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			SuspendLayout();
			// 
			// btnRemoveRareOption
			// 
			btnRemoveRareOption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnRemoveRareOption.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveRareOption.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveRareOption.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveRareOption.FlatStyle = FlatStyle.Flat;
			btnRemoveRareOption.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveRareOption.Location = new Point(13, 572);
			btnRemoveRareOption.Margin = new Padding(4, 3, 4, 3);
			btnRemoveRareOption.Name = "btnRemoveRareOption";
			btnRemoveRareOption.Size = new Size(308, 27);
			btnRemoveRareOption.TabIndex = 1014;
			btnRemoveRareOption.Text = "Remove Title";
			btnRemoveRareOption.UseVisualStyleBackColor = true;
			btnRemoveRareOption.Click += btnRemoveRareOption_Click;
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
			tbSearch.Size = new Size(308, 23);
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
			MainList.Location = new Point(13, 41);
			MainList.Margin = new Padding(4, 3, 4, 3);
			MainList.Name = "MainList";
			MainList.Size = new Size(308, 527);
			MainList.TabIndex = 1027;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// RareOptionPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(334, 611);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveRareOption);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(350, 650);
			Name = "RareOptionPicker";
			ShowInTaskbar = false;
			Text = "Title Picker";
			Load += RareOptionPicker_LoadAsync;
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveRareOption;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox MainList;
    }
}