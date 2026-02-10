using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class MonsterComboEditor
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			btnReload = new Button();
			btnAddNew = new Button();
			MainList = new ListBox();
			groupBox1 = new GroupBox();
			groupBox3 = new GroupBox();
			cbNationSelector = new ComboBox();
			label2 = new Label();
			tbName = new TextBox();
			groupBox2 = new GroupBox();
			gridRegens = new DataGridView();
			mob = new DataGridViewTextBoxColumn();
			amount = new DataGridViewTextBoxColumn();
			enable = new DataGridViewCheckBoxColumn();
			step = new DataGridViewComboBoxColumn();
			tbGoldCost = new TextBox();
			label4 = new Label();
			tbPoint = new TextBox();
			pbIcon = new PictureBox();
			label3 = new Label();
			cbEnable = new CheckBox();
			btnUpdate = new Button();
			label1 = new Label();
			tbID = new TextBox();
			btnCopy = new Button();
			btnDelete = new Button();
			tbSearch = new TextBox();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			((ISupportInitialize)gridRegens).BeginInit();
			((ISupportInitialize)pbIcon).BeginInit();
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
			btnReload.Location = new Point(13, 476);
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
			btnAddNew.Location = new Point(91, 476);
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
			MainList.Size = new Size(304, 422);
			MainList.TabIndex = 1;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(tbGoldCost);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(tbPoint);
			groupBox1.Controls.Add(pbIcon);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(cbEnable);
			groupBox1.Controls.Add(btnUpdate);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tbID);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(325, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(504, 491);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Combo Data";
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(cbNationSelector);
			groupBox3.Controls.Add(label2);
			groupBox3.Controls.Add(tbName);
			groupBox3.FlatStyle = FlatStyle.Flat;
			groupBox3.Location = new Point(8, 84);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(430, 50);
			groupBox3.TabIndex = 1067;
			groupBox3.TabStop = false;
			// 
			// cbNationSelector
			// 
			cbNationSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbNationSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbNationSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbNationSelector.FormattingEnabled = true;
			cbNationSelector.Location = new Point(8, 17);
			cbNationSelector.Margin = new Padding(4, 3, 4, 3);
			cbNationSelector.Name = "cbNationSelector";
			cbNationSelector.Size = new Size(57, 23);
			cbNationSelector.TabIndex = 11;
			cbNationSelector.SelectedIndexChanged += cbNationSelector_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(208, 203, 148);
			label2.Location = new Point(73, 21);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 1038;
			label2.Text = "Name";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbName
			// 
			tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbName.BackColor = Color.FromArgb(28, 30, 31);
			tbName.BorderStyle = BorderStyle.FixedSingle;
			tbName.ForeColor = Color.FromArgb(208, 203, 148);
			tbName.Location = new Point(120, 17);
			tbName.Margin = new Padding(4, 3, 4, 3);
			tbName.Name = "tbName";
			tbName.Size = new Size(302, 23);
			tbName.TabIndex = 1039;
			tbName.TextChanged += tbName_TextChanged;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(gridRegens);
			groupBox2.FlatStyle = FlatStyle.Flat;
			groupBox2.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox2.Location = new Point(8, 140);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(488, 345);
			groupBox2.TabIndex = 1066;
			groupBox2.TabStop = false;
			groupBox2.Text = "Mobs Regens";
			// 
			// gridRegens
			// 
			gridRegens.AllowUserToAddRows = false;
			gridRegens.AllowUserToDeleteRows = false;
			gridRegens.AllowUserToResizeRows = false;
			gridRegens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gridRegens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridRegens.BackgroundColor = Color.FromArgb(28, 30, 31);
			gridRegens.BorderStyle = BorderStyle.None;
			gridRegens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			gridRegens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			gridRegens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridRegens.Columns.AddRange(new DataGridViewColumn[] { mob, amount, enable, step });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 40);
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			gridRegens.DefaultCellStyle = dataGridViewCellStyle3;
			gridRegens.EditMode = DataGridViewEditMode.EditOnEnter;
			gridRegens.EnableHeadersVisualStyles = false;
			gridRegens.GridColor = Color.FromArgb(91, 85, 76);
			gridRegens.Location = new Point(8, 22);
			gridRegens.Margin = new Padding(4, 3, 4, 3);
			gridRegens.MultiSelect = false;
			gridRegens.Name = "gridRegens";
			gridRegens.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			gridRegens.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			gridRegens.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			gridRegens.ScrollBars = ScrollBars.Vertical;
			gridRegens.Size = new Size(472, 317);
			gridRegens.TabIndex = 0;
			gridRegens.CellMouseClick += gridLevels_CellMouseClick;
			gridRegens.CellValueChanged += gridLevels_CellValueChanged;
			// 
			// mob
			// 
			mob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			mob.FillWeight = 99.49239F;
			mob.HeaderText = "Mob";
			mob.Name = "mob";
			mob.ReadOnly = true;
			mob.Resizable = DataGridViewTriState.True;
			mob.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// amount
			// 
			amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			amount.FillWeight = 99.49239F;
			amount.HeaderText = "Amount";
			amount.Name = "amount";
			amount.SortMode = DataGridViewColumnSortMode.NotSortable;
			amount.Width = 48;
			// 
			// enable
			// 
			enable.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			enable.FillWeight = 101.5228F;
			enable.HeaderText = "Enable";
			enable.Name = "enable";
			enable.Width = 45;
			// 
			// step
			// 
			step.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 30, 31);
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 30, 31);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(208, 203, 148);
			step.DefaultCellStyle = dataGridViewCellStyle2;
			step.FillWeight = 99.49239F;
			step.FlatStyle = FlatStyle.Flat;
			step.HeaderText = "Step";
			step.Name = "step";
			step.Width = 34;
			// 
			// tbGoldCost
			// 
			tbGoldCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbGoldCost.BackColor = Color.FromArgb(166, 166, 166);
			tbGoldCost.BorderStyle = BorderStyle.FixedSingle;
			tbGoldCost.ForeColor = Color.FromArgb(208, 203, 148);
			tbGoldCost.Location = new Point(390, 55);
			tbGoldCost.Margin = new Padding(4, 3, 4, 3);
			tbGoldCost.Name = "tbGoldCost";
			tbGoldCost.Size = new Size(106, 23);
			tbGoldCost.TabIndex = 1065;
			tbGoldCost.TextChanged += tbGoldCost_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(208, 203, 148);
			label4.Location = new Point(168, 59);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(82, 15);
			label4.TabIndex = 1062;
			label4.Text = "Reward Points";
			label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbPoint
			// 
			tbPoint.BackColor = Color.FromArgb(28, 30, 31);
			tbPoint.BorderStyle = BorderStyle.FixedSingle;
			tbPoint.ForeColor = Color.FromArgb(208, 203, 148);
			tbPoint.Location = new Point(258, 55);
			tbPoint.Margin = new Padding(4, 3, 4, 3);
			tbPoint.Name = "tbPoint";
			tbPoint.Size = new Size(57, 23);
			tbPoint.TabIndex = 1063;
			tbPoint.TextAlign = HorizontalAlignment.Center;
			tbPoint.TextChanged += tbPoint_TextChanged;
			// 
			// pbIcon
			// 
			pbIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pbIcon.BackgroundImage = Properties.Resources.DefaultMonster;
			pbIcon.Cursor = Cursors.Hand;
			pbIcon.ErrorImage = null;
			pbIcon.InitialImage = null;
			pbIcon.Location = new Point(446, 84);
			pbIcon.Margin = new Padding(4, 3, 4, 3);
			pbIcon.Name = "pbIcon";
			pbIcon.Size = new Size(50, 50);
			pbIcon.TabIndex = 1064;
			pbIcon.TabStop = false;
			pbIcon.Click += pbIcon_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(208, 203, 148);
			label3.Location = new Point(323, 59);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(59, 15);
			label3.TabIndex = 1060;
			label3.Text = "Gold Cost";
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
			cbEnable.TabIndex = 1059;
			cbEnable.Text = "Enable";
			cbEnable.UseVisualStyleBackColor = true;
			cbEnable.CheckedChanged += cbEnable_CheckedChanged;
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
			btnUpdate.Size = new Size(488, 27);
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
			btnCopy.Location = new Point(169, 476);
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
			btnDelete.Location = new Point(247, 476);
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
			// MonsterComboEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(842, 512);
			Controls.Add(tbSearch);
			Controls.Add(btnDelete);
			Controls.Add(btnCopy);
			Controls.Add(MainList);
			Controls.Add(btnAddNew);
			Controls.Add(btnReload);
			Controls.Add(groupBox1);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(858, 551);
			Name = "MonsterComboEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Monster Combo Editor";
			FormClosing += MonsterComboEditor_FormClosing;
			Load += MonsterComboEditor_LoadAsync;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			((ISupportInitialize)gridRegens).EndInit();
			((ISupportInitialize)pbIcon).EndInit();
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
		private TextBox tbSearch;
		private DataGridView gridRegens;
		private CheckBox cbEnable;
		private Label label3;
		private TextBox tbPoint;
		private Label label4;
		private PictureBox pbIcon;
		private TextBox tbGoldCost;
		private TextBox tbName;
		private Label label2;
		private GroupBox groupBox2;
		private DataGridViewTextBoxColumn mob;
		private DataGridViewTextBoxColumn amount;
		private DataGridViewCheckBoxColumn enable;
		private DataGridViewComboBoxColumn step;
		private GroupBox groupBox3;
		private ComboBox cbNationSelector;
	}
}