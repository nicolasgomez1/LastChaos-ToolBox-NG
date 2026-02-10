using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class Exporter
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
			clbStringsFilesSelector = new CheckedListBox();
			btnExport = new Button();
			clbNationsSelector = new CheckedListBox();
			rbExportToClient = new RadioButton();
			rbExportToLocalFolder = new RadioButton();
			btnCheckStringsFilesSelector = new Button();
			btnCheckNationsSelector = new Button();
			btnCheckDataFilesSelector = new Button();
			clbDataFilesSelector = new CheckedListBox();
			SuspendLayout();
			// 
			// clbStringsFilesSelector
			// 
			clbStringsFilesSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			clbStringsFilesSelector.BackColor = Color.FromArgb(28, 30, 31);
			clbStringsFilesSelector.BorderStyle = BorderStyle.FixedSingle;
			clbStringsFilesSelector.CheckOnClick = true;
			clbStringsFilesSelector.ForeColor = Color.FromArgb(208, 203, 148);
			clbStringsFilesSelector.FormattingEnabled = true;
			clbStringsFilesSelector.Location = new Point(101, 45);
			clbStringsFilesSelector.Margin = new Padding(4, 3, 4, 3);
			clbStringsFilesSelector.Name = "clbStringsFilesSelector";
			clbStringsFilesSelector.Size = new Size(140, 506);
			clbStringsFilesSelector.TabIndex = 12;
			clbStringsFilesSelector.TabStop = false;
			// 
			// btnExport
			// 
			btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnExport.BackColor = Color.FromArgb(40, 40, 40);
			btnExport.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnExport.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnExport.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnExport.FlatStyle = FlatStyle.Flat;
			btnExport.ForeColor = Color.FromArgb(208, 203, 148);
			btnExport.Location = new Point(314, 562);
			btnExport.Margin = new Padding(4, 3, 4, 3);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(115, 27);
			btnExport.TabIndex = 0;
			btnExport.Text = "Export";
			btnExport.UseVisualStyleBackColor = false;
			btnExport.Click += btnExport_ClickAsync;
			// 
			// clbNationsSelector
			// 
			clbNationsSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			clbNationsSelector.BackColor = Color.FromArgb(28, 30, 31);
			clbNationsSelector.BorderStyle = BorderStyle.FixedSingle;
			clbNationsSelector.CheckOnClick = true;
			clbNationsSelector.ForeColor = Color.FromArgb(208, 203, 148);
			clbNationsSelector.FormattingEnabled = true;
			clbNationsSelector.Location = new Point(13, 45);
			clbNationsSelector.Margin = new Padding(4, 3, 4, 3);
			clbNationsSelector.Name = "clbNationsSelector";
			clbNationsSelector.Size = new Size(80, 506);
			clbNationsSelector.TabIndex = 1000;
			clbNationsSelector.TabStop = false;
			// 
			// rbExportToClient
			// 
			rbExportToClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			rbExportToClient.AutoSize = true;
			rbExportToClient.ForeColor = Color.FromArgb(208, 203, 148);
			rbExportToClient.Location = new Point(13, 566);
			rbExportToClient.Margin = new Padding(4, 3, 4, 3);
			rbExportToClient.Name = "rbExportToClient";
			rbExportToClient.Size = new Size(144, 19);
			rbExportToClient.TabIndex = 1001;
			rbExportToClient.Text = "Export To Client Folder";
			rbExportToClient.UseVisualStyleBackColor = true;
			// 
			// rbExportToLocalFolder
			// 
			rbExportToLocalFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			rbExportToLocalFolder.AutoSize = true;
			rbExportToLocalFolder.ForeColor = Color.FromArgb(208, 203, 148);
			rbExportToLocalFolder.Location = new Point(165, 566);
			rbExportToLocalFolder.Margin = new Padding(4, 3, 4, 3);
			rbExportToLocalFolder.Name = "rbExportToLocalFolder";
			rbExportToLocalFolder.Size = new Size(141, 19);
			rbExportToLocalFolder.TabIndex = 1002;
			rbExportToLocalFolder.Text = "Export To Local Folder";
			rbExportToLocalFolder.UseVisualStyleBackColor = true;
			// 
			// btnCheckStringsFilesSelector
			// 
			btnCheckStringsFilesSelector.BackColor = Color.FromArgb(40, 40, 40);
			btnCheckStringsFilesSelector.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnCheckStringsFilesSelector.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnCheckStringsFilesSelector.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnCheckStringsFilesSelector.FlatStyle = FlatStyle.Flat;
			btnCheckStringsFilesSelector.ForeColor = Color.FromArgb(208, 203, 148);
			btnCheckStringsFilesSelector.Location = new Point(101, 12);
			btnCheckStringsFilesSelector.Margin = new Padding(4, 3, 4, 3);
			btnCheckStringsFilesSelector.Name = "btnCheckStringsFilesSelector";
			btnCheckStringsFilesSelector.Size = new Size(140, 27);
			btnCheckStringsFilesSelector.TabIndex = 1003;
			btnCheckStringsFilesSelector.TabStop = false;
			btnCheckStringsFilesSelector.Text = "Check All";
			btnCheckStringsFilesSelector.UseVisualStyleBackColor = false;
			btnCheckStringsFilesSelector.Click += btnCheckStringsFilesSelector_Click;
			// 
			// btnCheckNationsSelector
			// 
			btnCheckNationsSelector.BackColor = Color.FromArgb(40, 40, 40);
			btnCheckNationsSelector.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnCheckNationsSelector.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnCheckNationsSelector.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnCheckNationsSelector.FlatStyle = FlatStyle.Flat;
			btnCheckNationsSelector.ForeColor = Color.FromArgb(208, 203, 148);
			btnCheckNationsSelector.Location = new Point(13, 12);
			btnCheckNationsSelector.Margin = new Padding(4, 3, 4, 3);
			btnCheckNationsSelector.Name = "btnCheckNationsSelector";
			btnCheckNationsSelector.Size = new Size(80, 27);
			btnCheckNationsSelector.TabIndex = 1004;
			btnCheckNationsSelector.TabStop = false;
			btnCheckNationsSelector.Text = "Check All";
			btnCheckNationsSelector.UseVisualStyleBackColor = false;
			btnCheckNationsSelector.Click += btnCheckNationsSelector_Click;
			// 
			// btnCheckDataFilesSelector
			// 
			btnCheckDataFilesSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnCheckDataFilesSelector.BackColor = Color.FromArgb(40, 40, 40);
			btnCheckDataFilesSelector.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnCheckDataFilesSelector.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnCheckDataFilesSelector.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnCheckDataFilesSelector.FlatStyle = FlatStyle.Flat;
			btnCheckDataFilesSelector.ForeColor = Color.FromArgb(208, 203, 148);
			btnCheckDataFilesSelector.Location = new Point(249, 12);
			btnCheckDataFilesSelector.Margin = new Padding(4, 3, 4, 3);
			btnCheckDataFilesSelector.Name = "btnCheckDataFilesSelector";
			btnCheckDataFilesSelector.Size = new Size(180, 27);
			btnCheckDataFilesSelector.TabIndex = 1008;
			btnCheckDataFilesSelector.TabStop = false;
			btnCheckDataFilesSelector.Text = "Check All";
			btnCheckDataFilesSelector.UseVisualStyleBackColor = false;
			btnCheckDataFilesSelector.Click += btnCheckDataFilesSelector_Click;
			// 
			// clbDataFilesSelector
			// 
			clbDataFilesSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			clbDataFilesSelector.BackColor = Color.FromArgb(28, 30, 31);
			clbDataFilesSelector.BorderStyle = BorderStyle.FixedSingle;
			clbDataFilesSelector.CheckOnClick = true;
			clbDataFilesSelector.ForeColor = Color.FromArgb(208, 203, 148);
			clbDataFilesSelector.FormattingEnabled = true;
			clbDataFilesSelector.Location = new Point(249, 45);
			clbDataFilesSelector.Margin = new Padding(4, 3, 4, 3);
			clbDataFilesSelector.Name = "clbDataFilesSelector";
			clbDataFilesSelector.Size = new Size(180, 506);
			clbDataFilesSelector.TabIndex = 1007;
			clbDataFilesSelector.TabStop = false;
			// 
			// Exporter
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(442, 601);
			Controls.Add(btnCheckDataFilesSelector);
			Controls.Add(clbDataFilesSelector);
			Controls.Add(btnCheckNationsSelector);
			Controls.Add(btnCheckStringsFilesSelector);
			Controls.Add(rbExportToLocalFolder);
			Controls.Add(rbExportToClient);
			Controls.Add(clbNationsSelector);
			Controls.Add(btnExport);
			Controls.Add(clbStringsFilesSelector);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(458, 640);
			Name = "Exporter";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Strings & Lods Exporter";
			FormClosing += Exporter_FormClosing;
			Load += Exporter_Load;
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private CheckedListBox clbStringsFilesSelector;
		private Button btnExport;
		private CheckedListBox clbNationsSelector;
		private RadioButton rbExportToClient;
		private RadioButton rbExportToLocalFolder;
		private Button btnCheckStringsFilesSelector;
		private Button btnCheckNationsSelector;
		private Button btnCheckDataFilesSelector;
		private CheckedListBox clbDataFilesSelector;
	}
}