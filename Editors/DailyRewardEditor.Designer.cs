using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class DailyRewardEditor
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
			groupBox1 = new GroupBox();
			gridRewards = new DataGridView();
			itemIcon = new DataGridViewImageColumn();
			item = new DataGridViewTextBoxColumn();
			flag = new DataGridViewTextBoxColumn();
			amount = new DataGridViewTextBoxColumn();
			tbSearch = new TextBox();
			label1 = new Label();
			cbChangesAppliedNotification = new CheckBox();
			groupBox1.SuspendLayout();
			((ISupportInitialize)gridRewards).BeginInit();
			SuspendLayout();
			// 
			// btnReload
			// 
			btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnReload.BackColor = Color.FromArgb(40, 40, 40);
			btnReload.Enabled = false;
			btnReload.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnReload.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnReload.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnReload.FlatStyle = FlatStyle.Flat;
			btnReload.ForeColor = Color.FromArgb(208, 203, 148);
			btnReload.Location = new Point(589, 10);
			btnReload.Margin = new Padding(4, 3, 4, 3);
			btnReload.Name = "btnReload";
			btnReload.Size = new Size(70, 27);
			btnReload.TabIndex = 0;
			btnReload.Text = "Reload";
			btnReload.UseVisualStyleBackColor = false;
			btnReload.Click += btnReload_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(gridRewards);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(13, 41);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(646, 470);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Daily Rewards Data";
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
			gridRewards.Columns.AddRange(new DataGridViewColumn[] { itemIcon, item, flag, amount });
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
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 56, 54);
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(208, 203, 148);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			gridRewards.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			gridRewards.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			gridRewards.ScrollBars = ScrollBars.Vertical;
			gridRewards.Size = new Size(630, 442);
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
			item.Resizable = DataGridViewTriState.True;
			item.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// flag
			// 
			flag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			flag.HeaderText = "Flag";
			flag.Name = "flag";
			flag.ReadOnly = true;
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
			// tbSearch
			// 
			tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbSearch.BackColor = Color.FromArgb(28, 30, 31);
			tbSearch.BorderStyle = BorderStyle.FixedSingle;
			tbSearch.ForeColor = Color.FromArgb(208, 203, 148);
			tbSearch.Location = new Point(63, 12);
			tbSearch.Margin = new Padding(4, 3, 4, 3);
			tbSearch.Name = "tbSearch";
			tbSearch.Size = new Size(281, 23);
			tbSearch.TabIndex = 0;
			tbSearch.TextChanged += tbSearch_TextChanged;
			tbSearch.KeyDown += tbSearch_KeyDown;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(208, 203, 148);
			label1.Location = new Point(13, 16);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 2;
			label1.Text = "Search";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbChangesAppliedNotification
			// 
			cbChangesAppliedNotification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbChangesAppliedNotification.AutoSize = true;
			cbChangesAppliedNotification.ForeColor = Color.FromArgb(208, 203, 148);
			cbChangesAppliedNotification.Location = new Point(352, 14);
			cbChangesAppliedNotification.Margin = new Padding(4, 3, 4, 3);
			cbChangesAppliedNotification.Name = "cbChangesAppliedNotification";
			cbChangesAppliedNotification.Size = new Size(229, 19);
			cbChangesAppliedNotification.TabIndex = 3;
			cbChangesAppliedNotification.Text = "Changes Applied Confirm Notification";
			cbChangesAppliedNotification.UseVisualStyleBackColor = true;
			cbChangesAppliedNotification.CheckedChanged += cbChangesAppliedNotification_CheckedChanged;
			// 
			// DailyRewardEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(672, 523);
			Controls.Add(cbChangesAppliedNotification);
			Controls.Add(label1);
			Controls.Add(tbSearch);
			Controls.Add(groupBox1);
			Controls.Add(btnReload);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(688, 562);
			Name = "DailyRewardEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Daily Reward Editor";
			FormClosing += DailyRewardEditor_FormClosing;
			Load += DailyRewardEditor_LoadAsync;
			groupBox1.ResumeLayout(false);
			((ISupportInitialize)gridRewards).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.GroupBox groupBox1;
		private TextBox tbSearch;
		private DataGridView gridRewards;
		private Label label1;
		private CheckBox cbChangesAppliedNotification;
		private DataGridViewImageColumn itemIcon;
		private DataGridViewTextBoxColumn item;
		private DataGridViewTextBoxColumn flag;
		private DataGridViewTextBoxColumn amount;
	}
}