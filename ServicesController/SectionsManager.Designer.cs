namespace LastChaos_ToolBoxNG
{
	partial class SectionsManager
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
			btnDelete = new Button();
			MainList = new ListBox();
			btnAdd = new Button();
			cbSectionSelector = new ComboBox();
			SuspendLayout();
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnDelete.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.ForeColor = Color.FromArgb(208, 203, 148);
			btnDelete.Location = new Point(172, 222);
			btnDelete.Margin = new Padding(4, 3, 4, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(99, 27);
			btnDelete.TabIndex = 1012;
			btnDelete.Text = "Delete Selected";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
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
			MainList.Size = new Size(258, 167);
			MainList.TabIndex = 1028;
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnAdd.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.ForeColor = Color.FromArgb(208, 203, 148);
			btnAdd.Location = new Point(13, 222);
			btnAdd.Margin = new Padding(4, 3, 4, 3);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(151, 27);
			btnAdd.TabIndex = 1029;
			btnAdd.Text = "Add New Section Name";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// cbSectionSelector
			// 
			cbSectionSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cbSectionSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbSectionSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbSectionSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbSectionSelector.FormattingEnabled = true;
			cbSectionSelector.Items.AddRange(new object[] { "Auth", "Data", "User" });
			cbSectionSelector.Location = new Point(13, 12);
			cbSectionSelector.Margin = new Padding(4, 3, 4, 3);
			cbSectionSelector.Name = "cbSectionSelector";
			cbSectionSelector.Size = new Size(258, 23);
			cbSectionSelector.TabIndex = 1030;
			cbSectionSelector.SelectedIndexChanged += cbSectionSelector_SelectedIndexChanged;
			// 
			// SectionsManager
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(284, 261);
			Controls.Add(cbSectionSelector);
			Controls.Add(btnAdd);
			Controls.Add(MainList);
			Controls.Add(btnDelete);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SectionsManager";
			ShowInTaskbar = false;
			Text = "Sections Manager";
			Load += SectionsManager_Load;
			ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ListBox MainList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbSectionSelector;
	}
}