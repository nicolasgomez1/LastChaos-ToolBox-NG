using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class UpdateHelper
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
			TreeNode treeNode1 = new TreeNode("Collect data to create an Update");
			TreeNode treeNode2 = new TreeNode("Clear Working Directory");
			TreeNode treeNode3 = new TreeNode("Creating & Copying Folder and File structures");
			TreeNode treeNode4 = new TreeNode("Compressing Files");
			lvFileList = new ListView();
			time = new ColumnHeader();
			event_type = new ColumnHeader();
			file_path = new ColumnHeader();
			tvStage = new TreeView();
			btnStartWatcher = new Button();
			btnClearList = new Button();
			btnRemoveSelected = new Button();
			btnMakeUpdateFile = new Button();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// lvFileList
			// 
			lvFileList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lvFileList.BackColor = Color.FromArgb(28, 30, 31);
			lvFileList.BorderStyle = BorderStyle.None;
			lvFileList.Columns.AddRange(new ColumnHeader[] { time, event_type, file_path });
			lvFileList.ForeColor = Color.FromArgb(208, 203, 148);
			lvFileList.FullRowSelect = true;
			lvFileList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			lvFileList.Location = new Point(8, 55);
			lvFileList.Margin = new Padding(4, 3, 4, 3);
			lvFileList.Name = "lvFileList";
			lvFileList.Size = new Size(642, 217);
			lvFileList.TabIndex = 0;
			lvFileList.UseCompatibleStateImageBehavior = false;
			lvFileList.View = View.Details;
			// 
			// time
			// 
			time.Text = "Time";
			time.Width = 52;
			// 
			// event_type
			// 
			event_type.Text = "Event Type";
			event_type.Width = 70;
			// 
			// file_path
			// 
			file_path.Text = "File Path";
			file_path.Width = 520;
			// 
			// tvStage
			// 
			tvStage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tvStage.BackColor = Color.FromArgb(28, 30, 31);
			tvStage.BorderStyle = BorderStyle.FixedSingle;
			tvStage.ForeColor = Color.FromArgb(208, 203, 148);
			tvStage.Location = new Point(13, 12);
			tvStage.Margin = new Padding(4, 3, 4, 3);
			tvStage.Name = "tvStage";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Collect data to create an Update";
			treeNode2.Name = "Node1";
			treeNode2.Text = "Clear Working Directory";
			treeNode3.Name = "Node2";
			treeNode3.Text = "Creating & Copying Folder and File structures";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Compressing Files";
			tvStage.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
			tvStage.Scrollable = false;
			tvStage.ShowPlusMinus = false;
			tvStage.Size = new Size(528, 256);
			tvStage.TabIndex = 1001;
			// 
			// btnStartWatcher
			// 
			btnStartWatcher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnStartWatcher.BackColor = Color.FromArgb(40, 40, 40);
			btnStartWatcher.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnStartWatcher.FlatAppearance.CheckedBackColor = Color.Lime;
			btnStartWatcher.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnStartWatcher.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnStartWatcher.FlatStyle = FlatStyle.Flat;
			btnStartWatcher.ForeColor = Color.FromArgb(208, 203, 148);
			btnStartWatcher.Location = new Point(549, 12);
			btnStartWatcher.Margin = new Padding(4, 3, 4, 3);
			btnStartWatcher.Name = "btnStartWatcher";
			btnStartWatcher.Size = new Size(122, 27);
			btnStartWatcher.TabIndex = 1002;
			btnStartWatcher.Text = "Start Watcher";
			btnStartWatcher.UseVisualStyleBackColor = false;
			btnStartWatcher.Click += btnStartWatcher_Click;
			// 
			// btnClearList
			// 
			btnClearList.BackColor = Color.FromArgb(40, 40, 40);
			btnClearList.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnClearList.FlatAppearance.CheckedBackColor = Color.Lime;
			btnClearList.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnClearList.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnClearList.FlatStyle = FlatStyle.Flat;
			btnClearList.ForeColor = Color.FromArgb(208, 203, 148);
			btnClearList.Location = new Point(8, 22);
			btnClearList.Margin = new Padding(4, 3, 4, 3);
			btnClearList.Name = "btnClearList";
			btnClearList.Size = new Size(317, 27);
			btnClearList.TabIndex = 1004;
			btnClearList.Text = "Clear List";
			btnClearList.UseVisualStyleBackColor = false;
			btnClearList.Click += btnClearList_Click;
			// 
			// btnRemoveSelected
			// 
			btnRemoveSelected.BackColor = Color.FromArgb(40, 40, 40);
			btnRemoveSelected.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnRemoveSelected.FlatAppearance.CheckedBackColor = Color.Lime;
			btnRemoveSelected.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnRemoveSelected.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnRemoveSelected.FlatStyle = FlatStyle.Flat;
			btnRemoveSelected.ForeColor = Color.FromArgb(208, 203, 148);
			btnRemoveSelected.Location = new Point(333, 22);
			btnRemoveSelected.Margin = new Padding(4, 3, 4, 3);
			btnRemoveSelected.Name = "btnRemoveSelected";
			btnRemoveSelected.Size = new Size(317, 27);
			btnRemoveSelected.TabIndex = 1005;
			btnRemoveSelected.Text = "Remove Selected";
			btnRemoveSelected.UseVisualStyleBackColor = false;
			btnRemoveSelected.Click += btnRemoveSelected_Click;
			// 
			// btnMakeUpdateFile
			// 
			btnMakeUpdateFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMakeUpdateFile.BackColor = Color.FromArgb(40, 40, 40);
			btnMakeUpdateFile.Enabled = false;
			btnMakeUpdateFile.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnMakeUpdateFile.FlatAppearance.CheckedBackColor = Color.Lime;
			btnMakeUpdateFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnMakeUpdateFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnMakeUpdateFile.FlatStyle = FlatStyle.Flat;
			btnMakeUpdateFile.ForeColor = Color.FromArgb(208, 203, 148);
			btnMakeUpdateFile.Location = new Point(549, 45);
			btnMakeUpdateFile.Margin = new Padding(4, 3, 4, 3);
			btnMakeUpdateFile.Name = "btnMakeUpdateFile";
			btnMakeUpdateFile.Size = new Size(122, 27);
			btnMakeUpdateFile.TabIndex = 1006;
			btnMakeUpdateFile.Text = "Make Update File";
			btnMakeUpdateFile.UseVisualStyleBackColor = false;
			btnMakeUpdateFile.Click += btnMakeUpdateFile_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(lvFileList);
			groupBox1.Controls.Add(btnRemoveSelected);
			groupBox1.Controls.Add(btnClearList);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(13, 274);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(658, 278);
			groupBox1.TabIndex = 1007;
			groupBox1.TabStop = false;
			groupBox1.Text = "History";
			// 
			// UpdateHelper
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(684, 564);
			Controls.Add(groupBox1);
			Controls.Add(btnMakeUpdateFile);
			Controls.Add(btnStartWatcher);
			Controls.Add(tvStage);
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MinimumSize = new Size(700, 603);
			Name = "UpdateHelper";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Update Helper";
			FormClosing += UpdateHelper_FormClosing;
			Load += UpdateHelper_Load;
			ResizeEnd += UpdateHelper_ResizeEnd;
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);

		}

		#endregion
		private ListView lvFileList;
		private ColumnHeader time;
		private ColumnHeader event_type;
		private ColumnHeader file_path;
		private TreeView tvStage;
		private Button btnStartWatcher;
		private Button btnClearList;
		private Button btnRemoveSelected;
		private Button btnMakeUpdateFile;
		private GroupBox groupBox1;
	}
}