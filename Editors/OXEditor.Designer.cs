using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
    partial class OXEditor
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
			rbX = new RadioButton();
			label2 = new Label();
			rbO = new RadioButton();
			label4 = new Label();
			tbName = new TextBox();
			label1 = new Label();
			tbID = new TextBox();
			groupBox2 = new GroupBox();
			label5 = new Label();
			rbDeepL = new RadioButton();
			rbGoogle = new RadioButton();
			btnTranslate = new Button();
			cbNationSelector = new ComboBox();
			tbQuestion = new TextBox();
			label3 = new Label();
			btnUpdate = new Button();
			groupBox3 = new GroupBox();
			label6 = new Label();
			btnUpdateRewards = new Button();
			tbSearchRewards = new TextBox();
			gridRewards = new DataGridView();
			rewardStage = new DataGridViewComboBoxColumn();
			itemIcon = new DataGridViewImageColumn();
			item = new DataGridViewTextBoxColumn();
			flag = new DataGridViewTextBoxColumn();
			amount = new DataGridViewTextBoxColumn();
			btnCopy = new Button();
			tbSearch = new TextBox();
			btnDelete = new Button();
			backgroundWorker1 = new BackgroundWorker();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((ISupportInitialize)gridRewards).BeginInit();
			SuspendLayout();
			// 
			// btnReload
			// 
			btnReload.BackColor = Color.FromArgb(40, 40, 40);
			btnReload.Enabled = false;
			btnReload.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnReload.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnReload.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnReload.FlatStyle = FlatStyle.Flat;
			btnReload.ForeColor = Color.FromArgb(208, 203, 148);
			btnReload.Location = new Point(13, 316);
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
			btnAddNew.BackColor = Color.FromArgb(40, 40, 40);
			btnAddNew.Enabled = false;
			btnAddNew.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnAddNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnAddNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnAddNew.FlatStyle = FlatStyle.Flat;
			btnAddNew.ForeColor = Color.FromArgb(208, 203, 148);
			btnAddNew.Location = new Point(91, 316);
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
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(rbX);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(rbO);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(tbName);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tbID);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(btnUpdate);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(325, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(456, 331);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quiz Data";
			// 
			// rbX
			// 
			rbX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rbX.AutoSize = true;
			rbX.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbX.ForeColor = Color.Red;
			rbX.Location = new Point(417, 58);
			rbX.Margin = new Padding(4, 3, 4, 3);
			rbX.Name = "rbX";
			rbX.Size = new Size(33, 17);
			rbX.TabIndex = 1062;
			rbX.TabStop = true;
			rbX.Text = "X";
			rbX.UseVisualStyleBackColor = true;
			rbX.Click += rbOX_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(208, 203, 148);
			label2.Location = new Point(321, 59);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(46, 15);
			label2.TabIndex = 1058;
			label2.Text = "Answer";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// rbO
			// 
			rbO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rbO.AutoSize = true;
			rbO.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbO.ForeColor = Color.FromArgb(0, 53, 255);
			rbO.Location = new Point(375, 58);
			rbO.Margin = new Padding(4, 3, 4, 3);
			rbO.Name = "rbO";
			rbO.Size = new Size(34, 17);
			rbO.TabIndex = 1061;
			rbO.TabStop = true;
			rbO.Text = "O";
			rbO.UseVisualStyleBackColor = true;
			rbO.Click += rbOX_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(208, 203, 148);
			label4.Location = new Point(99, 59);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(39, 15);
			label4.TabIndex = 1055;
			label4.Text = "Name";
			label4.TextAlign = ContentAlignment.MiddleRight;
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
			tbName.Size = new Size(167, 23);
			tbName.TabIndex = 1056;
			tbName.TextChanged += tbName_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(208, 203, 148);
			label1.Location = new Point(8, 59);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 1052;
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
			tbID.TabIndex = 1053;
			tbID.TextAlign = HorizontalAlignment.Center;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(rbDeepL);
			groupBox2.Controls.Add(rbGoogle);
			groupBox2.Controls.Add(btnTranslate);
			groupBox2.Controls.Add(cbNationSelector);
			groupBox2.Controls.Add(tbQuestion);
			groupBox2.Controls.Add(label3);
			groupBox2.FlatStyle = FlatStyle.Flat;
			groupBox2.Location = new Point(8, 84);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(440, 241);
			groupBox2.TabIndex = 1054;
			groupBox2.TabStop = false;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.ForeColor = Color.FromArgb(208, 203, 148);
			label5.Location = new Point(236, 19);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(59, 15);
			label5.TabIndex = 1012;
			label5.Text = "Translator";
			label5.TextAlign = ContentAlignment.MiddleRight;
			// 
			// rbDeepL
			// 
			rbDeepL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rbDeepL.AutoSize = true;
			rbDeepL.Location = new Point(374, 17);
			rbDeepL.Margin = new Padding(4, 3, 4, 3);
			rbDeepL.Name = "rbDeepL";
			rbDeepL.Size = new Size(58, 19);
			rbDeepL.TabIndex = 1011;
			rbDeepL.Text = "DeepL";
			rbDeepL.UseVisualStyleBackColor = true;
			// 
			// rbGoogle
			// 
			rbGoogle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rbGoogle.AutoSize = true;
			rbGoogle.Checked = true;
			rbGoogle.Location = new Point(303, 17);
			rbGoogle.Margin = new Padding(4, 3, 4, 3);
			rbGoogle.Name = "rbGoogle";
			rbGoogle.Size = new Size(63, 19);
			rbGoogle.TabIndex = 1010;
			rbGoogle.TabStop = true;
			rbGoogle.Text = "Google";
			rbGoogle.UseVisualStyleBackColor = true;
			// 
			// btnTranslate
			// 
			btnTranslate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnTranslate.BackColor = Color.FromArgb(40, 40, 40);
			btnTranslate.Enabled = false;
			btnTranslate.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnTranslate.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnTranslate.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnTranslate.FlatStyle = FlatStyle.Flat;
			btnTranslate.Location = new Point(74, 13);
			btnTranslate.Margin = new Padding(4, 3, 4, 3);
			btnTranslate.Name = "btnTranslate";
			btnTranslate.Size = new Size(154, 27);
			btnTranslate.TabIndex = 1060;
			btnTranslate.Text = "Translate into other langs";
			btnTranslate.UseVisualStyleBackColor = false;
			btnTranslate.Click += btnTranslate_Click;
			// 
			// cbNationSelector
			// 
			cbNationSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbNationSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbNationSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbNationSelector.FormattingEnabled = true;
			cbNationSelector.Location = new Point(8, 15);
			cbNationSelector.Margin = new Padding(4, 3, 4, 3);
			cbNationSelector.Name = "cbNationSelector";
			cbNationSelector.Size = new Size(58, 23);
			cbNationSelector.TabIndex = 11;
			cbNationSelector.SelectedIndexChanged += cbNationSelector_SelectedIndexChanged;
			// 
			// tbQuestion
			// 
			tbQuestion.BackColor = Color.FromArgb(28, 30, 31);
			tbQuestion.BorderStyle = BorderStyle.FixedSingle;
			tbQuestion.ForeColor = Color.FromArgb(208, 203, 148);
			tbQuestion.Location = new Point(8, 61);
			tbQuestion.Margin = new Padding(4, 3, 4, 3);
			tbQuestion.MaxLength = 50;
			tbQuestion.Multiline = true;
			tbQuestion.Name = "tbQuestion";
			tbQuestion.ScrollBars = ScrollBars.Vertical;
			tbQuestion.Size = new Size(241, 174);
			tbQuestion.TabIndex = 13;
			tbQuestion.TextChanged += tbQuestion_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(208, 203, 148);
			label3.Location = new Point(8, 43);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 15;
			label3.Text = "Quiz";
			label3.TextAlign = ContentAlignment.MiddleRight;
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
			btnUpdate.Size = new Size(442, 27);
			btnUpdate.TabIndex = 999;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(btnUpdateRewards);
			groupBox3.Controls.Add(tbSearchRewards);
			groupBox3.Controls.Add(gridRewards);
			groupBox3.FlatStyle = FlatStyle.Flat;
			groupBox3.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox3.Location = new Point(13, 349);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(768, 374);
			groupBox3.TabIndex = 1051;
			groupBox3.TabStop = false;
			groupBox3.Text = "Rewards Data";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.FromArgb(208, 203, 148);
			label6.Location = new Point(8, 26);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(42, 15);
			label6.TabIndex = 1064;
			label6.Text = "Search";
			label6.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnUpdateRewards
			// 
			btnUpdateRewards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnUpdateRewards.BackColor = Color.FromArgb(40, 40, 40);
			btnUpdateRewards.Enabled = false;
			btnUpdateRewards.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnUpdateRewards.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnUpdateRewards.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnUpdateRewards.FlatStyle = FlatStyle.Flat;
			btnUpdateRewards.Location = new Point(301, 18);
			btnUpdateRewards.Margin = new Padding(4, 3, 4, 3);
			btnUpdateRewards.Name = "btnUpdateRewards";
			btnUpdateRewards.Size = new Size(459, 27);
			btnUpdateRewards.TabIndex = 1063;
			btnUpdateRewards.Text = "Update";
			btnUpdateRewards.UseVisualStyleBackColor = false;
			btnUpdateRewards.Click += btnUpdateRewards_Click;
			// 
			// tbSearchRewards
			// 
			tbSearchRewards.BackColor = Color.FromArgb(28, 30, 31);
			tbSearchRewards.BorderStyle = BorderStyle.FixedSingle;
			tbSearchRewards.ForeColor = Color.FromArgb(208, 203, 148);
			tbSearchRewards.Location = new Point(58, 22);
			tbSearchRewards.Margin = new Padding(4, 3, 4, 3);
			tbSearchRewards.Name = "tbSearchRewards";
			tbSearchRewards.Size = new Size(235, 23);
			tbSearchRewards.TabIndex = 1052;
			tbSearchRewards.TextChanged += tbSearchRewards_TextChanged;
			tbSearchRewards.KeyDown += tbSearchRewards_KeyDown;
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
			gridRewards.Columns.AddRange(new DataGridViewColumn[] { rewardStage, itemIcon, item, flag, amount });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 40);
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			gridRewards.DefaultCellStyle = dataGridViewCellStyle3;
			gridRewards.EditMode = DataGridViewEditMode.EditOnEnter;
			gridRewards.EnableHeadersVisualStyles = false;
			gridRewards.GridColor = Color.FromArgb(91, 85, 76);
			gridRewards.Location = new Point(8, 51);
			gridRewards.Margin = new Padding(4, 3, 4, 3);
			gridRewards.MultiSelect = false;
			gridRewards.Name = "gridRewards";
			gridRewards.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			gridRewards.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			gridRewards.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			gridRewards.ScrollBars = ScrollBars.Vertical;
			gridRewards.Size = new Size(752, 317);
			gridRewards.TabIndex = 0;
			gridRewards.CellMouseClick += gridRewards_CellMouseClick;
			gridRewards.CellValueChanged += gridRewards_CellValueChanged;
			// 
			// rewardStage
			// 
			rewardStage.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 30, 31);
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 30, 31);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(208, 203, 148);
			rewardStage.DefaultCellStyle = dataGridViewCellStyle2;
			rewardStage.FillWeight = 131.8681F;
			rewardStage.FlatStyle = FlatStyle.Flat;
			rewardStage.HeaderText = "Stage";
			rewardStage.Name = "rewardStage";
			rewardStage.Resizable = DataGridViewTriState.True;
			rewardStage.Width = 50;
			// 
			// itemIcon
			// 
			itemIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			itemIcon.HeaderText = "";
			itemIcon.Name = "itemIcon";
			itemIcon.Resizable = DataGridViewTriState.False;
			itemIcon.Width = 25;
			// 
			// item
			// 
			item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			item.FillWeight = 68.13187F;
			item.HeaderText = "Item";
			item.Name = "item";
			item.ReadOnly = true;
			item.Resizable = DataGridViewTriState.True;
			item.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// flag
			// 
			flag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			flag.HeaderText = "Flag";
			flag.Name = "flag";
			flag.ReadOnly = true;
			flag.Resizable = DataGridViewTriState.True;
			flag.SortMode = DataGridViewColumnSortMode.NotSortable;
			flag.Width = 32;
			// 
			// amount
			// 
			amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			amount.HeaderText = "Amount";
			amount.Name = "amount";
			amount.SortMode = DataGridViewColumnSortMode.NotSortable;
			amount.Width = 48;
			// 
			// btnCopy
			// 
			btnCopy.BackColor = Color.FromArgb(40, 40, 40);
			btnCopy.Enabled = false;
			btnCopy.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnCopy.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnCopy.FlatStyle = FlatStyle.Flat;
			btnCopy.ForeColor = Color.FromArgb(208, 203, 148);
			btnCopy.Location = new Point(169, 316);
			btnCopy.Margin = new Padding(4, 3, 4, 3);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(70, 27);
			btnCopy.TabIndex = 0;
			btnCopy.Text = "Copy";
			btnCopy.UseVisualStyleBackColor = false;
			btnCopy.Click += btnCopy_Click;
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
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(40, 40, 40);
			btnDelete.Enabled = false;
			btnDelete.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.ForeColor = Color.FromArgb(208, 203, 148);
			btnDelete.Location = new Point(247, 316);
			btnDelete.Margin = new Padding(4, 3, 4, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(70, 27);
			btnDelete.TabIndex = 1063;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// OXEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(794, 735);
			Controls.Add(btnDelete);
			Controls.Add(tbSearch);
			Controls.Add(btnCopy);
			Controls.Add(MainList);
			Controls.Add(btnAddNew);
			Controls.Add(btnReload);
			Controls.Add(groupBox1);
			Controls.Add(groupBox3);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(810, 774);
			Name = "OXEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "OX Editor";
			FormClosing += OXEditor_FormClosing;
			Load += OXEditor_LoadAsync;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((ISupportInitialize)gridRewards).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnCopy;
        private TextBox tbSearch;
		private DataGridView gridRewards;
		private GroupBox groupBox3;
		private Label label1;
		private TextBox tbID;
		private GroupBox groupBox2;
		private TextBox tbQuestion;
		private Label label3;
		private Label label4;
		private TextBox tbName;
		private Label label2;
		private Button btnTranslate;
		private RadioButton rbX;
		private RadioButton rbO;
		private Label label5;
		private RadioButton rbDeepL;
		private RadioButton rbGoogle;
		private ComboBox cbNationSelector;
		private TextBox tbSearchRewards;
		private Button btnUpdateRewards;
		private Button btnDelete;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label label6;
		private DataGridViewComboBoxColumn rewardStage;
		private DataGridViewImageColumn itemIcon;
		private DataGridViewTextBoxColumn item;
		private DataGridViewTextBoxColumn flag;
		private DataGridViewTextBoxColumn amount;
	}
}