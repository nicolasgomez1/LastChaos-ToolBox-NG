namespace LastChaos_ToolBoxNG
{
	partial class TitlePicker
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
			tbSearch = new TextBox();
			MainList = new ListBox();
			btnRemoveZone = new Button();
			SuspendLayout();
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
			// btnRemoveZone
			// 
			btnRemoveZone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemoveZone.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveZone.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveZone.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveZone.FlatStyle = FlatStyle.Flat;
			btnRemoveZone.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveZone.Location = new Point(13, 572);
			btnRemoveZone.Margin = new Padding(4, 3, 4, 3);
			btnRemoveZone.Name = "btnRemoveZone";
			btnRemoveZone.Size = new Size(308, 27);
			btnRemoveZone.TabIndex = 1028;
			btnRemoveZone.Text = "Remove Title";
			btnRemoveZone.UseVisualStyleBackColor = true;
			btnRemoveZone.Click += btnRemoveZone_Click;
			// 
			// TitlePicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(334, 611);
			Controls.Add(btnRemoveZone);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(350, 650);
			Name = "TitlePicker";
			ShowInTaskbar = false;
			Text = "Title Picker";
			Load += TitlePicker_LoadAsync;
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ListBox MainList;
		private System.Windows.Forms.Button btnRemoveZone;
	}
}