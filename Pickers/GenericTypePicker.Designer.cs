namespace LastChaos_ToolBoxNG
{
	partial class GenericTypePicker
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
			btnRemoveType = new Button();
			cbTypesListSelector = new ComboBox();
			SuspendLayout();
			// 
			// tbSearch
			// 
			tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbSearch.BackColor = Color.FromArgb(28, 30, 31);
			tbSearch.BorderStyle = BorderStyle.FixedSingle;
			tbSearch.ForeColor = Color.FromArgb(208, 203, 148);
			tbSearch.Location = new Point(13, 41);
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
			MainList.Location = new Point(13, 70);
			MainList.Margin = new Padding(4, 3, 4, 3);
			MainList.Name = "MainList";
			MainList.Size = new Size(308, 497);
			MainList.TabIndex = 1027;
			MainList.DoubleClick += MainList_DoubleClick;
			// 
			// btnRemoveType
			// 
			btnRemoveType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemoveType.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveType.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveType.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveType.FlatStyle = FlatStyle.Flat;
			btnRemoveType.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveType.Location = new Point(13, 572);
			btnRemoveType.Margin = new Padding(4, 3, 4, 3);
			btnRemoveType.Name = "btnRemoveType";
			btnRemoveType.Size = new Size(308, 27);
			btnRemoveType.TabIndex = 1028;
			btnRemoveType.Text = "Remove Type";
			btnRemoveType.UseVisualStyleBackColor = true;
			btnRemoveType.Click += btnRemoveZone_Click;
			// 
			// cbTypesListSelector
			// 
			cbTypesListSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cbTypesListSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbTypesListSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTypesListSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbTypesListSelector.FormattingEnabled = true;
			cbTypesListSelector.Location = new Point(13, 12);
			cbTypesListSelector.Margin = new Padding(4, 3, 4, 3);
			cbTypesListSelector.Name = "cbTypesListSelector";
			cbTypesListSelector.Size = new Size(308, 23);
			cbTypesListSelector.TabIndex = 1029;
			cbTypesListSelector.SelectedIndexChanged += cbTypesListSelector_SelectedIndexChanged;
			// 
			// GenericTypePicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(334, 611);
			Controls.Add(cbTypesListSelector);
			Controls.Add(btnRemoveType);
			Controls.Add(MainList);
			Controls.Add(tbSearch);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimizeBox = false;
			MinimumSize = new Size(350, 650);
			Name = "GenericTypePicker";
			ShowInTaskbar = false;
			Text = "Generic Type Picker";
			Load += GenericTypePicker_Load;
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ListBox MainList;
		private System.Windows.Forms.Button btnRemoveType;
		private System.Windows.Forms.ComboBox cbTypesListSelector;
	}
}