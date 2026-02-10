using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
    partial class TreasureMapEditor
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
			btnReload = new Button();
			groupBox1 = new GroupBox();
			btnUpdate = new Button();
			groupBox2 = new GroupBox();
			lbAreas = new ListBox();
			pbWorldMap = new PictureBox();
			btnHelp = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((ISupportInitialize)pbWorldMap).BeginInit();
			SuspendLayout();
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
			tbSearch.TabIndex = 2;
			tbSearch.TextChanged += tbSearch_TextChanged;
			tbSearch.KeyDown += tbSearch_KeyDown;
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
			MainList.Size = new Size(304, 512);
			MainList.TabIndex = 4;
			MainList.SelectedIndexChanged += MainList_SelectedIndexChanged;
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
			btnReload.Location = new Point(13, 558);
			btnReload.Margin = new Padding(4, 3, 4, 3);
			btnReload.Name = "btnReload";
			btnReload.Size = new Size(70, 27);
			btnReload.TabIndex = 3;
			btnReload.Text = "Reload";
			btnReload.UseVisualStyleBackColor = false;
			btnReload.Click += btnReload_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(btnUpdate);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(pbWorldMap);
			groupBox1.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox1.Location = new Point(325, 12);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(696, 573);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Treasure Map Data";
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
			btnUpdate.Location = new Point(7, 22);
			btnUpdate.Margin = new Padding(4, 3, 4, 3);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(681, 27);
			btnUpdate.TabIndex = 1000;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(lbAreas);
			groupBox2.ForeColor = Color.FromArgb(208, 203, 148);
			groupBox2.Location = new Point(527, 55);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(161, 512);
			groupBox2.TabIndex = 15;
			groupBox2.TabStop = false;
			groupBox2.Text = "Areas Data";
			// 
			// lbAreas
			// 
			lbAreas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lbAreas.BackColor = Color.FromArgb(28, 30, 31);
			lbAreas.BorderStyle = BorderStyle.FixedSingle;
			lbAreas.ForeColor = Color.FromArgb(208, 203, 148);
			lbAreas.FormattingEnabled = true;
			lbAreas.Location = new Point(8, 22);
			lbAreas.Margin = new Padding(4, 3, 4, 3);
			lbAreas.Name = "lbAreas";
			lbAreas.Size = new Size(145, 482);
			lbAreas.TabIndex = 6;
			lbAreas.SelectedIndexChanged += lbAreas_SelectedIndexChanged;
			lbAreas.KeyDown += lbAreas_KeyDown;
			// 
			// pbWorldMap
			// 
			pbWorldMap.BackColor = Color.FromArgb(70, 70, 70);
			pbWorldMap.ErrorImage = null;
			pbWorldMap.InitialImage = null;
			pbWorldMap.Location = new Point(7, 55);
			pbWorldMap.Margin = new Padding(4, 3, 4, 3);
			pbWorldMap.Name = "pbWorldMap";
			pbWorldMap.Size = new Size(512, 512);
			pbWorldMap.TabIndex = 14;
			pbWorldMap.TabStop = false;
			pbWorldMap.Paint += pbWorldMap_Paint;
			pbWorldMap.MouseClick += pbWorldMap_MouseClick;
			pbWorldMap.MouseDown += pbWorldMap_MouseDown;
			pbWorldMap.MouseMove += pbWorldMap_MouseMove;
			pbWorldMap.MouseUp += pbWorldMap_MouseUp;
			// 
			// btnHelp
			// 
			btnHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnHelp.BackColor = Color.FromArgb(40, 40, 40);
			btnHelp.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnHelp.FlatStyle = FlatStyle.Flat;
			btnHelp.ForeColor = Color.FromArgb(208, 203, 148);
			btnHelp.Location = new Point(91, 558);
			btnHelp.Margin = new Padding(4, 3, 4, 3);
			btnHelp.Name = "btnHelp";
			btnHelp.Size = new Size(226, 27);
			btnHelp.TabIndex = 6;
			btnHelp.Text = "How To";
			btnHelp.UseVisualStyleBackColor = false;
			btnHelp.Click += btnHelp_Click;
			// 
			// TreasureMapEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(1034, 597);
			Controls.Add(btnHelp);
			Controls.Add(groupBox1);
			Controls.Add(tbSearch);
			Controls.Add(MainList);
			Controls.Add(btnReload);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			KeyPreview = true;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimumSize = new Size(1050, 636);
			Name = "TreasureMapEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Treasure Map Editor";
			FormClosing += TreasureMapEditor_FormClosing;
			Load += TreasureMapEditor_LoadAsync;
			KeyDown += TreasureMapEditor_KeyDown;
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			((ISupportInitialize)pbWorldMap).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private TextBox tbSearch;
		private ListBox MainList;
		private Button btnReload;
		private GroupBox groupBox1;
		private PictureBox pbWorldMap;
		private GroupBox groupBox2;
		private Button btnUpdate;
		private ListBox lbAreas;
		private Button btnHelp;
	}
}