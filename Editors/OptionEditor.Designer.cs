using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class OptionEditor
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
			groupBox3 = new GroupBox();
			gridLevels = new DataGridView();
			level = new DataGridViewTextBoxColumn();
			prob = new DataGridViewTextBoxColumn();
			label6 = new Label();
			btnAccessoryTypeFlag = new Button();
			label5 = new Label();
			btnWearTypeFlag = new Button();
			label4 = new Label();
			btnWeaponTypeFlag = new Button();
			btnUpdate = new Button();
			cbTypeSelector = new ComboBox();
			label1 = new Label();
			label3 = new Label();
			groupBox2 = new GroupBox();
			cbNationSelector = new ComboBox();
			tbName = new TextBox();
			label2 = new Label();
			tbID = new TextBox();
			btnCopy = new Button();
			btnDelete = new Button();
			tbSearch = new TextBox();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			((ISupportInitialize)gridLevels).BeginInit();
			groupBox2.SuspendLayout();
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
			btnReload.Location = new Point(13, 490);
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
			btnAddNew.Location = new Point(91, 490);
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
			MainList.Size = new Size(304, 437);
			MainList.TabIndex = 1;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(btnAccessoryTypeFlag);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(btnWearTypeFlag);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(btnWeaponTypeFlag);
			groupBox1.Controls.Add(btnUpdate);
			groupBox1.Controls.Add(cbTypeSelector);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(tbID);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(325, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(587, 505);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Option Data";
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(gridLevels);
			groupBox3.FlatStyle = FlatStyle.Flat;
			groupBox3.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox3.Location = new Point(8, 154);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(571, 345);
			groupBox3.TabIndex = 1038;
			groupBox3.TabStop = false;
			groupBox3.Text = "Levels";
			// 
			// gridLevels
			// 
			gridLevels.AllowUserToAddRows = false;
			gridLevels.AllowUserToDeleteRows = false;
			gridLevels.AllowUserToResizeRows = false;
			gridLevels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gridLevels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridLevels.BackgroundColor = Color.FromArgb(28, 30, 31);
			gridLevels.BorderStyle = BorderStyle.None;
			gridLevels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			gridLevels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			gridLevels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridLevels.Columns.AddRange(new DataGridViewColumn[] { level, prob });
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			gridLevels.DefaultCellStyle = dataGridViewCellStyle2;
			gridLevels.EditMode = DataGridViewEditMode.EditOnEnter;
			gridLevels.EnableHeadersVisualStyles = false;
			gridLevels.GridColor = Color.FromArgb(91, 85, 76);
			gridLevels.Location = new Point(8, 22);
			gridLevels.Margin = new Padding(4, 3, 4, 3);
			gridLevels.MultiSelect = false;
			gridLevels.Name = "gridLevels";
			gridLevels.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			gridLevels.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			gridLevels.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			gridLevels.ScrollBars = ScrollBars.Vertical;
			gridLevels.Size = new Size(555, 317);
			gridLevels.TabIndex = 0;
			gridLevels.CellMouseClick += gridLevels_CellMouseClick;
			gridLevels.CellValueChanged += gridLevels_CellValueChanged;
			// 
			// level
			// 
			level.HeaderText = "Level / Percent / Value";
			level.Name = "level";
			// 
			// prob
			// 
			prob.HeaderText = "Probability";
			prob.Name = "prob";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.FromArgb(208, 203, 148);
			label6.Location = new Point(360, 127);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(106, 15);
			label6.TabIndex = 1037;
			label6.Text = "Allowed Accessory";
			label6.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnAccessoryTypeFlag
			// 
			btnAccessoryTypeFlag.BackColor = Color.FromArgb(40, 40, 40);
			btnAccessoryTypeFlag.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnAccessoryTypeFlag.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnAccessoryTypeFlag.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnAccessoryTypeFlag.FlatStyle = FlatStyle.Flat;
			btnAccessoryTypeFlag.ForeColor = Color.FromArgb(208, 203, 148);
			btnAccessoryTypeFlag.Location = new Point(474, 121);
			btnAccessoryTypeFlag.Margin = new Padding(4, 3, 4, 3);
			btnAccessoryTypeFlag.Name = "btnAccessoryTypeFlag";
			btnAccessoryTypeFlag.Size = new Size(105, 27);
			btnAccessoryTypeFlag.TabIndex = 1036;
			btnAccessoryTypeFlag.UseVisualStyleBackColor = false;
			btnAccessoryTypeFlag.Click += btnAccessoryTypeFlag_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.FromArgb(208, 203, 148);
			label5.Location = new Point(379, 94);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(87, 15);
			label5.TabIndex = 1035;
			label5.Text = "Allowed Armor";
			label5.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnWearTypeFlag
			// 
			btnWearTypeFlag.BackColor = Color.FromArgb(40, 40, 40);
			btnWearTypeFlag.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnWearTypeFlag.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnWearTypeFlag.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnWearTypeFlag.FlatStyle = FlatStyle.Flat;
			btnWearTypeFlag.ForeColor = Color.FromArgb(208, 203, 148);
			btnWearTypeFlag.Location = new Point(474, 88);
			btnWearTypeFlag.Margin = new Padding(4, 3, 4, 3);
			btnWearTypeFlag.Name = "btnWearTypeFlag";
			btnWearTypeFlag.Size = new Size(105, 27);
			btnWearTypeFlag.TabIndex = 1034;
			btnWearTypeFlag.UseVisualStyleBackColor = false;
			btnWearTypeFlag.Click += btnWearTypeFlag_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(208, 203, 148);
			label4.Location = new Point(369, 61);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(97, 15);
			label4.TabIndex = 1033;
			label4.Text = "Allowed Weapon";
			label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnWeaponTypeFlag
			// 
			btnWeaponTypeFlag.BackColor = Color.FromArgb(40, 40, 40);
			btnWeaponTypeFlag.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnWeaponTypeFlag.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnWeaponTypeFlag.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnWeaponTypeFlag.FlatStyle = FlatStyle.Flat;
			btnWeaponTypeFlag.ForeColor = Color.FromArgb(208, 203, 148);
			btnWeaponTypeFlag.Location = new Point(474, 55);
			btnWeaponTypeFlag.Margin = new Padding(4, 3, 4, 3);
			btnWeaponTypeFlag.Name = "btnWeaponTypeFlag";
			btnWeaponTypeFlag.Size = new Size(105, 27);
			btnWeaponTypeFlag.TabIndex = 1032;
			btnWeaponTypeFlag.UseVisualStyleBackColor = false;
			btnWeaponTypeFlag.Click += btnWeaponTypeFlag_Click;
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
			btnUpdate.Size = new Size(571, 27);
			btnUpdate.TabIndex = 999;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// cbTypeSelector
			// 
			cbTypeSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTypeSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbTypeSelector.FormattingEnabled = true;
			cbTypeSelector.Location = new Point(139, 55);
			cbTypeSelector.Margin = new Padding(4, 3, 4, 3);
			cbTypeSelector.Name = "cbTypeSelector";
			cbTypeSelector.Size = new Size(222, 23);
			cbTypeSelector.TabIndex = 16;
			cbTypeSelector.SelectedIndexChanged += cbTypeSelector_SelectedIndexChanged;
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
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(208, 203, 148);
			label3.Location = new Point(99, 59);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(32, 15);
			label3.TabIndex = 1006;
			label3.Text = "Type";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(cbNationSelector);
			groupBox2.Controls.Add(tbName);
			groupBox2.Controls.Add(label2);
			groupBox2.FlatStyle = FlatStyle.Flat;
			groupBox2.Location = new Point(8, 84);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(344, 50);
			groupBox2.TabIndex = 1000;
			groupBox2.TabStop = false;
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
			// tbName
			// 
			tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbName.BackColor = Color.FromArgb(28, 30, 31);
			tbName.BorderStyle = BorderStyle.FixedSingle;
			tbName.ForeColor = Color.FromArgb(208, 203, 148);
			tbName.Location = new Point(120, 17);
			tbName.Margin = new Padding(4, 3, 4, 3);
			tbName.Name = "tbName";
			tbName.Size = new Size(216, 23);
			tbName.TabIndex = 12;
			tbName.TextChanged += tbName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(208, 203, 148);
			label2.Location = new Point(73, 21);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 14;
			label2.Text = "Name";
			label2.TextAlign = ContentAlignment.MiddleRight;
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
			btnCopy.Location = new Point(169, 490);
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
			btnDelete.Location = new Point(247, 490);
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
			// OptionEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(925, 529);
			Controls.Add(tbSearch);
			Controls.Add(btnDelete);
			Controls.Add(btnCopy);
			Controls.Add(MainList);
			Controls.Add(btnAddNew);
			Controls.Add(btnReload);
			Controls.Add(groupBox1);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(941, 568);
			Name = "OptionEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Option Editor";
			FormClosing += OptionEditor_FormClosing;
			Load += OptionEditor_LoadAsync;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox3.ResumeLayout(false);
			((ISupportInitialize)gridLevels).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
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
		private TextBox tbName;
		private ComboBox cbNationSelector;
		private GroupBox groupBox2;
		private Label label3;
		private TextBox tbSearch;
		private Label label4;
		private Button btnWeaponTypeFlag;
		private Label label5;
		private Button btnWearTypeFlag;
		private Label label6;
		private Button btnAccessoryTypeFlag;
		private DataGridView gridLevels;
		private ComboBox cbTypeSelector;
		private GroupBox groupBox3;
		private DataGridViewTextBoxColumn level;
		private DataGridViewTextBoxColumn prob;
	}
}