namespace LastChaos_ToolBoxNG
{
	partial class StringPicker
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
			btnRemoveString = new Button();
			tbSearch = new TextBox();
			MainList = new ListBox();
			SuspendLayout();
			// 
			// btnRemoveString
			// 
			btnRemoveString.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemoveString.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveString.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveString.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveString.FlatStyle = FlatStyle.Flat;
			btnRemoveString.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveString.Location = new Point(13, 322);
			btnRemoveString.Margin = new Padding(4, 3, 4, 3);
			btnRemoveString.Name = "btnRemoveString";
			btnRemoveString.Size = new Size(598, 27);
			btnRemoveString.TabIndex = 1014;
			btnRemoveString.Text = "Remove String";
			btnRemoveString.UseVisualStyleBackColor = true;
			btnRemoveString.Click += btnRemoveString_Click;
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
			tbSearch.Size = new Size(598, 23);
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
			MainList.Size = new Size(598, 272);
			MainList.TabIndex = 1027;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// StringPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(624, 361);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Controls.Add(btnRemoveString);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimizeBox = false;
			MinimumSize = new Size(640, 400);
			Name = "StringPicker";
			ShowInTaskbar = false;
			Text = "String Picker";
			Load += StringPicker_LoadAsync;
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnRemoveString;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ListBox MainList;
	}
}