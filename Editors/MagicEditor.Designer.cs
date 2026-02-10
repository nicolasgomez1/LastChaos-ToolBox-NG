using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class MagicEditor
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
			gridLevels = new DataGridView();
			power = new DataGridViewTextBoxColumn();
			hitrate = new DataGridViewTextBoxColumn();
			cbHtP = new ComboBox();
			cbHsP = new ComboBox();
			cbPtP = new ComboBox();
			cbPsP = new ComboBox();
			cbToggle = new CheckBox();
			label15 = new Label();
			label14 = new Label();
			label13 = new Label();
			label12 = new Label();
			lAttribute = new Label();
			tbAttribute = new TextBox();
			cbHitTypeSelector = new ComboBox();
			label9 = new Label();
			cbDamageTypeSelector = new ComboBox();
			label8 = new Label();
			cbSubTypeSelector = new ComboBox();
			label7 = new Label();
			tbName = new TextBox();
			label2 = new Label();
			btnUpdate = new Button();
			cbTypeSelector = new ComboBox();
			label1 = new Label();
			label3 = new Label();
			tbID = new TextBox();
			btnCopy = new Button();
			btnDelete = new Button();
			tbSearch = new TextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((ISupportInitialize)gridLevels).BeginInit();
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
			btnReload.Location = new Point(13, 536);
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
			btnAddNew.Location = new Point(91, 536);
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
			MainList.Size = new Size(304, 482);
			MainList.TabIndex = 1;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(cbHtP);
			groupBox1.Controls.Add(cbHsP);
			groupBox1.Controls.Add(cbPtP);
			groupBox1.Controls.Add(cbPsP);
			groupBox1.Controls.Add(cbToggle);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(label14);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(lAttribute);
			groupBox1.Controls.Add(tbAttribute);
			groupBox1.Controls.Add(cbHitTypeSelector);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(cbDamageTypeSelector);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(cbSubTypeSelector);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(tbName);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnUpdate);
			groupBox1.Controls.Add(cbTypeSelector);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(tbID);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(325, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(530, 551);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Magic Data";
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(gridLevels);
			groupBox2.FlatStyle = FlatStyle.Flat;
			groupBox2.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox2.Location = new Point(8, 200);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(514, 345);
			groupBox2.TabIndex = 1064;
			groupBox2.TabStop = false;
			groupBox2.Text = "Levels";
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
			gridLevels.Columns.AddRange(new DataGridViewColumn[] { power, hitrate });
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
			gridLevels.Size = new Size(498, 317);
			gridLevels.TabIndex = 0;
			gridLevels.CellMouseClick += gridLevels_CellMouseClick;
			gridLevels.CellValueChanged += gridLevels_CellValueChanged;
			// 
			// power
			// 
			power.HeaderText = "Power";
			power.Name = "power";
			// 
			// hitrate
			// 
			hitrate.HeaderText = "Hit Rate";
			hitrate.Name = "hitrate";
			// 
			// cbHtP
			// 
			cbHtP.BackColor = Color.FromArgb(28, 30, 31);
			cbHtP.DropDownStyle = ComboBoxStyle.DropDownList;
			cbHtP.ForeColor = Color.FromArgb(208, 203, 148);
			cbHtP.FormattingEnabled = true;
			cbHtP.Location = new Point(405, 171);
			cbHtP.Margin = new Padding(4, 3, 4, 3);
			cbHtP.Name = "cbHtP";
			cbHtP.Size = new Size(117, 23);
			cbHtP.TabIndex = 1063;
			cbHtP.SelectedIndexChanged += cbHtP_SelectedIndexChanged;
			// 
			// cbHsP
			// 
			cbHsP.BackColor = Color.FromArgb(28, 30, 31);
			cbHsP.DropDownStyle = ComboBoxStyle.DropDownList;
			cbHsP.ForeColor = Color.FromArgb(208, 203, 148);
			cbHsP.FormattingEnabled = true;
			cbHsP.Location = new Point(405, 142);
			cbHsP.Margin = new Padding(4, 3, 4, 3);
			cbHsP.Name = "cbHsP";
			cbHsP.Size = new Size(117, 23);
			cbHsP.TabIndex = 1062;
			cbHsP.SelectedIndexChanged += cbHsP_SelectedIndexChanged;
			// 
			// cbPtP
			// 
			cbPtP.BackColor = Color.FromArgb(28, 30, 31);
			cbPtP.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPtP.ForeColor = Color.FromArgb(208, 203, 148);
			cbPtP.FormattingEnabled = true;
			cbPtP.Location = new Point(405, 113);
			cbPtP.Margin = new Padding(4, 3, 4, 3);
			cbPtP.Name = "cbPtP";
			cbPtP.Size = new Size(117, 23);
			cbPtP.TabIndex = 1061;
			cbPtP.SelectedIndexChanged += cbPtP_SelectedIndexChanged;
			// 
			// cbPsP
			// 
			cbPsP.BackColor = Color.FromArgb(28, 30, 31);
			cbPsP.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPsP.ForeColor = Color.FromArgb(208, 203, 148);
			cbPsP.FormattingEnabled = true;
			cbPsP.Location = new Point(405, 84);
			cbPsP.Margin = new Padding(4, 3, 4, 3);
			cbPsP.Name = "cbPsP";
			cbPsP.Size = new Size(117, 23);
			cbPsP.TabIndex = 1060;
			cbPsP.SelectedIndexChanged += cbPsP_SelectedIndexChanged;
			// 
			// cbToggle
			// 
			cbToggle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbToggle.AutoSize = true;
			cbToggle.ForeColor = Color.FromArgb(208, 203, 148);
			cbToggle.Location = new Point(460, 57);
			cbToggle.Margin = new Padding(4, 3, 4, 3);
			cbToggle.Name = "cbToggle";
			cbToggle.Size = new Size(62, 19);
			cbToggle.TabIndex = 1059;
			cbToggle.Text = "Toggle";
			cbToggle.UseVisualStyleBackColor = true;
			cbToggle.Visible = false;
			cbToggle.CheckedChanged += cbToggle_CheckedChanged;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.ForeColor = Color.FromArgb(208, 203, 148);
			label15.Location = new Point(312, 175);
			label15.Margin = new Padding(4, 0, 4, 0);
			label15.Name = "label15";
			label15.Size = new Size(85, 15);
			label15.TabIndex = 1056;
			label15.Text = "Target Hit Rate";
			label15.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.ForeColor = Color.FromArgb(208, 203, 148);
			label14.Location = new Point(326, 146);
			label14.Margin = new Padding(4, 0, 4, 0);
			label14.Name = "label14";
			label14.Size = new Size(71, 15);
			label14.TabIndex = 1054;
			label14.Text = "Self Hit Rate";
			label14.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.ForeColor = Color.FromArgb(208, 203, 148);
			label13.Location = new Point(274, 117);
			label13.Margin = new Padding(4, 0, 4, 0);
			label13.Name = "label13";
			label13.Size = new Size(123, 15);
			label13.TabIndex = 1052;
			label13.Text = "Target Damage Power";
			label13.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.ForeColor = Color.FromArgb(208, 203, 148);
			label12.Location = new Point(288, 88);
			label12.Margin = new Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new Size(109, 15);
			label12.TabIndex = 1050;
			label12.Text = "Self Damage Power";
			label12.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lAttribute
			// 
			lAttribute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lAttribute.AutoSize = true;
			lAttribute.ForeColor = Color.FromArgb(208, 203, 148);
			lAttribute.Location = new Point(355, 59);
			lAttribute.Margin = new Padding(4, 0, 4, 0);
			lAttribute.Name = "lAttribute";
			lAttribute.Size = new Size(54, 15);
			lAttribute.TabIndex = 1048;
			lAttribute.Text = "Attribute";
			lAttribute.TextAlign = ContentAlignment.MiddleRight;
			lAttribute.Visible = false;
			// 
			// tbAttribute
			// 
			tbAttribute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			tbAttribute.BackColor = Color.FromArgb(28, 30, 31);
			tbAttribute.BorderStyle = BorderStyle.FixedSingle;
			tbAttribute.ForeColor = Color.FromArgb(208, 203, 148);
			tbAttribute.Location = new Point(417, 55);
			tbAttribute.Margin = new Padding(4, 3, 4, 3);
			tbAttribute.Name = "tbAttribute";
			tbAttribute.Size = new Size(35, 23);
			tbAttribute.TabIndex = 1049;
			tbAttribute.Text = "0";
			tbAttribute.TextAlign = HorizontalAlignment.Center;
			tbAttribute.Visible = false;
			tbAttribute.TextChanged += tbAttribute_TextChanged;
			// 
			// cbHitTypeSelector
			// 
			cbHitTypeSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbHitTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbHitTypeSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbHitTypeSelector.FormattingEnabled = true;
			cbHitTypeSelector.Location = new Point(95, 171);
			cbHitTypeSelector.Margin = new Padding(4, 3, 4, 3);
			cbHitTypeSelector.Name = "cbHitTypeSelector";
			cbHitTypeSelector.Size = new Size(171, 23);
			cbHitTypeSelector.TabIndex = 1044;
			cbHitTypeSelector.SelectedIndexChanged += cbHitTypeSelector_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = Color.FromArgb(208, 203, 148);
			label9.Location = new Point(36, 175);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(51, 15);
			label9.TabIndex = 1045;
			label9.Text = "Hit Type";
			label9.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbDamageTypeSelector
			// 
			cbDamageTypeSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbDamageTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbDamageTypeSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbDamageTypeSelector.FormattingEnabled = true;
			cbDamageTypeSelector.Location = new Point(95, 142);
			cbDamageTypeSelector.Margin = new Padding(4, 3, 4, 3);
			cbDamageTypeSelector.Name = "cbDamageTypeSelector";
			cbDamageTypeSelector.Size = new Size(171, 23);
			cbDamageTypeSelector.TabIndex = 1042;
			cbDamageTypeSelector.SelectedIndexChanged += cbDamageTypeSelector_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = Color.FromArgb(208, 203, 148);
			label8.Location = new Point(8, 146);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(79, 15);
			label8.TabIndex = 1043;
			label8.Text = "Damage Type";
			label8.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbSubTypeSelector
			// 
			cbSubTypeSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbSubTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbSubTypeSelector.Enabled = false;
			cbSubTypeSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbSubTypeSelector.FormattingEnabled = true;
			cbSubTypeSelector.Location = new Point(95, 113);
			cbSubTypeSelector.Margin = new Padding(4, 3, 4, 3);
			cbSubTypeSelector.Name = "cbSubTypeSelector";
			cbSubTypeSelector.Size = new Size(171, 23);
			cbSubTypeSelector.TabIndex = 1040;
			cbSubTypeSelector.SelectedIndexChanged += cbSubTypeSelector_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.FromArgb(208, 203, 148);
			label7.Location = new Point(32, 117);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(55, 15);
			label7.TabIndex = 1041;
			label7.Text = "Sub Type";
			label7.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbName
			// 
			tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbName.BackColor = Color.FromArgb(28, 30, 31);
			tbName.BorderStyle = BorderStyle.FixedSingle;
			tbName.ForeColor = Color.FromArgb(208, 203, 148);
			tbName.Location = new Point(146, 55);
			tbName.Margin = new Padding(4, 3, 4, 3);
			tbName.Name = "tbName";
			tbName.Size = new Size(201, 23);
			tbName.TabIndex = 1039;
			tbName.TextChanged += tbName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(208, 203, 148);
			label2.Location = new Point(99, 59);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 1038;
			label2.Text = "Name";
			label2.TextAlign = ContentAlignment.MiddleRight;
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
			btnUpdate.Location = new Point(8, 22);
			btnUpdate.Margin = new Padding(4, 3, 4, 3);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(514, 27);
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
			cbTypeSelector.Location = new Point(95, 84);
			cbTypeSelector.Margin = new Padding(4, 3, 4, 3);
			cbTypeSelector.Name = "cbTypeSelector";
			cbTypeSelector.Size = new Size(171, 23);
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
			label3.Location = new Point(55, 88);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(32, 15);
			label3.TabIndex = 1006;
			label3.Text = "Type";
			label3.TextAlign = ContentAlignment.MiddleRight;
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
			btnCopy.Location = new Point(169, 536);
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
			btnDelete.Location = new Point(247, 536);
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
			// MagicEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(868, 575);
			Controls.Add(tbSearch);
			Controls.Add(btnDelete);
			Controls.Add(btnCopy);
			Controls.Add(MainList);
			Controls.Add(btnAddNew);
			Controls.Add(btnReload);
			Controls.Add(groupBox1);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(884, 614);
			Name = "MagicEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Magic Editor";
			FormClosing += MagicEditor_FormClosing;
			Load += MagicEditor_LoadAsync;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((ISupportInitialize)gridLevels).EndInit();
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
		private Label label3;
		private TextBox tbSearch;
		private DataGridView gridLevels;
		private ComboBox cbTypeSelector;
		private DataGridViewTextBoxColumn power;
		private DataGridViewTextBoxColumn hitrate;
		private Label label2;
		private TextBox tbName;
		private ComboBox cbSubTypeSelector;
		private Label label7;
		private ComboBox cbDamageTypeSelector;
		private Label label8;
		private ComboBox cbHitTypeSelector;
		private Label label9;
		private Label lAttribute;
		private TextBox tbAttribute;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private CheckBox cbToggle;
		private ComboBox cbPsP;
		private ComboBox cbPtP;
		private ComboBox cbHsP;
		private ComboBox cbHtP;
		private GroupBox groupBox2;
	}
}