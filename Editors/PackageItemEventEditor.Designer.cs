using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class PackageItemEventEditor
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			btnReload = new Button();
			btnAddNew = new Button();
			MainList = new ListBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			lbTimeLeft = new Label();
			label4 = new Label();
			mcExpirationDate = new MonthCalendar();
			btnSetExpirationDateManually = new Button();
			label3 = new Label();
			cbEnable = new CheckBox();
			nudUsesLimit = new NumericUpDown();
			groupBox3 = new GroupBox();
			gridRewards = new DataGridView();
			itemIcon = new DataGridViewImageColumn();
			item = new DataGridViewTextBoxColumn();
			tbCode = new TextBox();
			label2 = new Label();
			btnRandomGenerator = new Button();
			btnUpdate = new Button();
			label1 = new Label();
			tbID = new TextBox();
			btnCopy = new Button();
			btnDelete = new Button();
			tbSearch = new TextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((ISupportInitialize)nudUsesLimit).BeginInit();
			groupBox3.SuspendLayout();
			((ISupportInitialize)gridRewards).BeginInit();
			SuspendLayout();
			// 
			// btnReload
			// 
			btnReload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnReload.BackColor = Color.FromArgb(40, 40, 40);
			btnReload.Enabled = false;
			btnReload.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnReload.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnReload.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnReload.FlatStyle = FlatStyle.Flat;
			btnReload.ForeColor = Color.FromArgb(208, 203, 148);
			btnReload.Location = new Point(13, 322);
			btnReload.Margin = new Padding(4, 3, 4, 3);
			btnReload.Name = "btnReload";
			btnReload.Size = new Size(70, 27);
			btnReload.TabIndex = 0;
			btnReload.Text = "Reload";
			btnReload.UseVisualStyleBackColor = false;
			btnReload.Click += btnReload_Click;
			// 
			// btnAddNew
			// 
			btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnAddNew.BackColor = Color.FromArgb(40, 40, 40);
			btnAddNew.Enabled = false;
			btnAddNew.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnAddNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnAddNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnAddNew.FlatStyle = FlatStyle.Flat;
			btnAddNew.ForeColor = Color.FromArgb(208, 203, 148);
			btnAddNew.Location = new Point(91, 322);
			btnAddNew.Margin = new Padding(4, 3, 4, 3);
			btnAddNew.Name = "btnAddNew";
			btnAddNew.Size = new Size(70, 27);
			btnAddNew.TabIndex = 0;
			btnAddNew.Text = "Add New";
			btnAddNew.UseVisualStyleBackColor = false;
			btnAddNew.Click += btnAddNew_Click;
			// 
			// MainList
			// 
			MainList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			MainList.BackColor = Color.FromArgb(28, 30, 31);
			MainList.BorderStyle = BorderStyle.FixedSingle;
			MainList.Enabled = false;
			MainList.ForeColor = Color.FromArgb(208, 203, 148);
			MainList.FormattingEnabled = true;
			MainList.Location = new Point(13, 41);
			MainList.Margin = new Padding(4, 3, 4, 3);
			MainList.Name = "MainList";
			MainList.Size = new Size(304, 272);
			MainList.TabIndex = 1;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(cbEnable);
			groupBox1.Controls.Add(nudUsesLimit);
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(tbCode);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnRandomGenerator);
			groupBox1.Controls.Add(btnUpdate);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tbID);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(325, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(753, 337);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Package Item Event Data";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lbTimeLeft);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(mcExpirationDate);
			groupBox2.Controls.Add(btnSetExpirationDateManually);
			groupBox2.FlatStyle = FlatStyle.Flat;
			groupBox2.Location = new Point(8, 84);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(265, 247);
			groupBox2.TabIndex = 1066;
			groupBox2.TabStop = false;
			// 
			// lbTimeLeft
			// 
			lbTimeLeft.AutoSize = true;
			lbTimeLeft.ForeColor = Color.White;
			lbTimeLeft.Location = new Point(102, 19);
			lbTimeLeft.Margin = new Padding(4, 0, 4, 0);
			lbTimeLeft.Name = "lbTimeLeft";
			lbTimeLeft.Size = new Size(12, 15);
			lbTimeLeft.TabIndex = 1066;
			lbTimeLeft.Text = "-";
			lbTimeLeft.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(208, 203, 148);
			label4.Location = new Point(8, 19);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(86, 15);
			label4.TabIndex = 1063;
			label4.Text = "Expiration Date";
			label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// mcExpirationDate
			// 
			mcExpirationDate.BackColor = Color.FromArgb(28, 30, 31);
			mcExpirationDate.ForeColor = Color.FromArgb(208, 203, 148);
			mcExpirationDate.Location = new Point(8, 76);
			mcExpirationDate.MaxSelectionCount = 1;
			mcExpirationDate.Name = "mcExpirationDate";
			mcExpirationDate.RightToLeft = RightToLeft.No;
			mcExpirationDate.ShowToday = false;
			mcExpirationDate.ShowTodayCircle = false;
			mcExpirationDate.ShowWeekNumbers = true;
			mcExpirationDate.TabIndex = 1064;
			mcExpirationDate.TitleBackColor = Color.FromArgb(60, 56, 54);
			mcExpirationDate.TitleForeColor = Color.FromArgb(208, 203, 148);
			mcExpirationDate.TrailingForeColor = Color.FromArgb(208, 203, 148);
			mcExpirationDate.DateChanged += mcExpirationDate_DateChanged;
			// 
			// btnSetExpirationDateManually
			// 
			btnSetExpirationDateManually.BackColor = Color.FromArgb(40, 40, 40);
			btnSetExpirationDateManually.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnSetExpirationDateManually.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnSetExpirationDateManually.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnSetExpirationDateManually.FlatStyle = FlatStyle.Flat;
			btnSetExpirationDateManually.ForeColor = Color.FromArgb(208, 203, 148);
			btnSetExpirationDateManually.Location = new Point(8, 37);
			btnSetExpirationDateManually.Margin = new Padding(4, 3, 4, 3);
			btnSetExpirationDateManually.Name = "btnSetExpirationDateManually";
			btnSetExpirationDateManually.Size = new Size(249, 27);
			btnSetExpirationDateManually.TabIndex = 1065;
			btnSetExpirationDateManually.Text = "Set Manually";
			btnSetExpirationDateManually.UseVisualStyleBackColor = false;
			btnSetExpirationDateManually.Click += btnSetExpirationDateManually_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(208, 203, 148);
			label3.Location = new Point(168, 59);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 1062;
			label3.Text = "Uses Limit";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbEnable
			// 
			cbEnable.AutoSize = true;
			cbEnable.ForeColor = Color.FromArgb(208, 203, 148);
			cbEnable.Location = new Point(99, 57);
			cbEnable.Margin = new Padding(4, 3, 4, 3);
			cbEnable.Name = "cbEnable";
			cbEnable.Size = new Size(61, 19);
			cbEnable.TabIndex = 1061;
			cbEnable.Text = "Enable";
			cbEnable.UseVisualStyleBackColor = true;
			cbEnable.CheckedChanged += cbEnable_CheckedChanged;
			// 
			// nudUsesLimit
			// 
			nudUsesLimit.BackColor = Color.FromArgb(28, 30, 31);
			nudUsesLimit.ForeColor = Color.FromArgb(208, 203, 148);
			nudUsesLimit.Location = new Point(236, 55);
			nudUsesLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudUsesLimit.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
			nudUsesLimit.Name = "nudUsesLimit";
			nudUsesLimit.Size = new Size(57, 23);
			nudUsesLimit.TabIndex = 1039;
			nudUsesLimit.TextAlign = HorizontalAlignment.Center;
			nudUsesLimit.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
			nudUsesLimit.ValueChanged += nudUsesLimit_ValueChanged;
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(gridRewards);
			groupBox3.FlatStyle = FlatStyle.Flat;
			groupBox3.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox3.Location = new Point(281, 86);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(464, 245);
			groupBox3.TabIndex = 1038;
			groupBox3.TabStop = false;
			groupBox3.Text = "Rewards";
			// 
			// gridRewards
			// 
			gridRewards.AllowUserToAddRows = false;
			gridRewards.AllowUserToDeleteRows = false;
			gridRewards.AllowUserToResizeRows = false;
			gridRewards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gridRewards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridRewards.BackgroundColor = Color.FromArgb(28, 30, 31);
			gridRewards.BorderStyle = BorderStyle.None;
			gridRewards.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			gridRewards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			gridRewards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridRewards.Columns.AddRange(new DataGridViewColumn[] { itemIcon, item });
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			gridRewards.DefaultCellStyle = dataGridViewCellStyle2;
			gridRewards.EditMode = DataGridViewEditMode.EditOnEnter;
			gridRewards.EnableHeadersVisualStyles = false;
			gridRewards.GridColor = Color.FromArgb(91, 85, 76);
			gridRewards.Location = new Point(8, 22);
			gridRewards.Margin = new Padding(4, 3, 4, 3);
			gridRewards.MultiSelect = false;
			gridRewards.Name = "gridRewards";
			gridRewards.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			gridRewards.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			gridRewards.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			gridRewards.ScrollBars = ScrollBars.Vertical;
			gridRewards.Size = new Size(448, 217);
			gridRewards.TabIndex = 0;
			gridRewards.CellMouseClick += gridRewards_CellMouseClick;
			gridRewards.CellValueChanged += gridRewards_CellValueChanged;
			// 
			// itemIcon
			// 
			itemIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			itemIcon.Frozen = true;
			itemIcon.HeaderText = "";
			itemIcon.Name = "itemIcon";
			itemIcon.Resizable = DataGridViewTriState.False;
			itemIcon.Width = 25;
			// 
			// item
			// 
			item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			item.HeaderText = "Item";
			item.Name = "item";
			item.ReadOnly = true;
			item.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// tbCode
			// 
			tbCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbCode.BackColor = Color.FromArgb(28, 30, 31);
			tbCode.BorderStyle = BorderStyle.FixedSingle;
			tbCode.ForeColor = Color.FromArgb(208, 203, 148);
			tbCode.Location = new Point(343, 55);
			tbCode.Margin = new Padding(4, 3, 4, 3);
			tbCode.Name = "tbCode";
			tbCode.Size = new Size(279, 23);
			tbCode.TabIndex = 12;
			tbCode.TextChanged += tbCode_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(208, 203, 148);
			label2.Location = new Point(300, 59);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(35, 15);
			label2.TabIndex = 14;
			label2.Text = "Code";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnRandomGenerator
			// 
			btnRandomGenerator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnRandomGenerator.BackColor = Color.FromArgb(40, 40, 40);
			btnRandomGenerator.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRandomGenerator.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRandomGenerator.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRandomGenerator.FlatStyle = FlatStyle.Flat;
			btnRandomGenerator.ForeColor = Color.FromArgb(208, 203, 148);
			btnRandomGenerator.Location = new Point(630, 53);
			btnRandomGenerator.Margin = new Padding(4, 3, 4, 3);
			btnRandomGenerator.Name = "btnRandomGenerator";
			btnRandomGenerator.Size = new Size(115, 27);
			btnRandomGenerator.TabIndex = 1032;
			btnRandomGenerator.Text = "Generate Random";
			btnRandomGenerator.UseVisualStyleBackColor = false;
			btnRandomGenerator.Click += btnRandomGenerator_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnUpdate.BackColor = Color.FromArgb(40, 40, 40);
			btnUpdate.Enabled = false;
			btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.ForeColor = Color.FromArgb(208, 203, 148);
			btnUpdate.Location = new Point(8, 22);
			btnUpdate.Margin = new Padding(4, 3, 4, 3);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(737, 27);
			btnUpdate.TabIndex = 999;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(208, 203, 148);
			label1.Location = new Point(8, 59);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 1;
			label1.Text = "ID";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbID
			// 
			tbID.BackColor = Color.FromArgb(28, 30, 31);
			tbID.BorderStyle = BorderStyle.FixedSingle;
			tbID.ForeColor = Color.FromArgb(208, 203, 148);
			tbID.Location = new Point(34, 55);
			tbID.Margin = new Padding(4, 3, 4, 3);
			tbID.Name = "tbID";
			tbID.ReadOnly = true;
			tbID.Size = new Size(57, 23);
			tbID.TabIndex = 1;
			tbID.TextAlign = HorizontalAlignment.Center;
			// 
			// btnCopy
			// 
			btnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnCopy.BackColor = Color.FromArgb(40, 40, 40);
			btnCopy.Enabled = false;
			btnCopy.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnCopy.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnCopy.FlatStyle = FlatStyle.Flat;
			btnCopy.ForeColor = Color.FromArgb(208, 203, 148);
			btnCopy.Location = new Point(169, 322);
			btnCopy.Margin = new Padding(4, 3, 4, 3);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(70, 27);
			btnCopy.TabIndex = 0;
			btnCopy.Text = "Copy";
			btnCopy.UseVisualStyleBackColor = false;
			btnCopy.Click += btnCopy_Click;
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnDelete.BackColor = Color.FromArgb(40, 40, 40);
			btnDelete.Enabled = false;
			btnDelete.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.ForeColor = Color.FromArgb(208, 203, 148);
			btnDelete.Location = new Point(247, 322);
			btnDelete.Margin = new Padding(4, 3, 4, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(70, 27);
			btnDelete.TabIndex = 0;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// tbSearch
			// 
			tbSearch.BackColor = Color.FromArgb(28, 30, 31);
			tbSearch.BorderStyle = BorderStyle.FixedSingle;
			tbSearch.ForeColor = Color.FromArgb(208, 203, 148);
			tbSearch.Location = new Point(13, 12);
			tbSearch.Margin = new Padding(4, 3, 4, 3);
			tbSearch.Name = "tbSearch";
			tbSearch.Size = new Size(304, 23);
			tbSearch.TabIndex = 0;
			tbSearch.TextChanged += tbSearch_TextChanged;
			tbSearch.KeyDown += tbSearch_KeyDown;
			// 
			// PackageItemEventEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(1091, 361);
			Controls.Add(tbSearch);
			Controls.Add(btnDelete);
			Controls.Add(btnCopy);
			Controls.Add(MainList);
			Controls.Add(btnAddNew);
			Controls.Add(btnReload);
			Controls.Add(groupBox1);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(1100, 400);
			Name = "PackageItemEventEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Package Item Event Editor";
			FormClosing += PackageItemEventEditor_FormClosing;
			Load += PackageItemEventEditor_LoadAsync;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((ISupportInitialize)nudUsesLimit).EndInit();
			groupBox3.ResumeLayout(false);
			((ISupportInitialize)gridRewards).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.ListBox MainList;
		private System.Windows.Forms.GroupBox groupBox1;
		private TextBox tbID;
		private Button btnUpdate;
		private Button btnCopy;
		private Button btnDelete;
		private Label label1;
		private Label label2;
		private TextBox tbCode;
		private TextBox tbSearch;
		private Button btnRandomGenerator;
		private DataGridView gridRewards;
		private GroupBox groupBox3;
		private DataGridViewImageColumn itemIcon;
		private DataGridViewTextBoxColumn item;
		private NumericUpDown nudUsesLimit;
		private CheckBox cbEnable;
		private Label label3;
		private Label label4;
		private MonthCalendar mcExpirationDate;
		private Button btnSetExpirationDateManually;
		private GroupBox groupBox2;
		private Label lbTimeLeft;
	}
}