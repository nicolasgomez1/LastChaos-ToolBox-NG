using System.Windows.Forms;

namespace LastChaos_ToolBoxNG
{
	partial class DBStringTranslator
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
			btnTranslate = new Button();
			rbUpdateDB = new RadioButton();
			rbDumpToFile = new RadioButton();
			cbTableSelector = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			cbOutputLanguageSelector = new ComboBox();
			label3 = new Label();
			tbStartFromRowNumber = new TextBox();
			pbProgress = new ProgressBar();
			rbGoogle = new RadioButton();
			rbDeepL = new RadioButton();
			label4 = new Label();
			panel1 = new Panel();
			panel2 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnTranslate
			// 
			btnTranslate.BackColor = Color.FromArgb(40, 40, 40);
			btnTranslate.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnTranslate.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnTranslate.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnTranslate.FlatStyle = FlatStyle.Flat;
			btnTranslate.ForeColor = Color.FromArgb(208, 203, 148);
			btnTranslate.Location = new Point(13, 64);
			btnTranslate.Margin = new Padding(4, 3, 4, 3);
			btnTranslate.Name = "btnTranslate";
			btnTranslate.Size = new Size(485, 27);
			btnTranslate.TabIndex = 999;
			btnTranslate.Text = "Translate";
			btnTranslate.UseVisualStyleBackColor = false;
			btnTranslate.Click += btnTranslate_Click;
			// 
			// rbUpdateDB
			// 
			rbUpdateDB.AutoSize = true;
			rbUpdateDB.ForeColor = Color.FromArgb(208, 203, 148);
			rbUpdateDB.Location = new Point(4, 3);
			rbUpdateDB.Margin = new Padding(4, 3, 4, 3);
			rbUpdateDB.Name = "rbUpdateDB";
			rbUpdateDB.Size = new Size(157, 19);
			rbUpdateDB.TabIndex = 1001;
			rbUpdateDB.TabStop = true;
			rbUpdateDB.Text = "Update Database Directly";
			rbUpdateDB.UseVisualStyleBackColor = true;
			// 
			// rbDumpToFile
			// 
			rbDumpToFile.AutoSize = true;
			rbDumpToFile.Checked = true;
			rbDumpToFile.ForeColor = Color.FromArgb(208, 203, 148);
			rbDumpToFile.Location = new Point(169, 3);
			rbDumpToFile.Margin = new Padding(4, 3, 4, 3);
			rbDumpToFile.Name = "rbDumpToFile";
			rbDumpToFile.Size = new Size(98, 19);
			rbDumpToFile.TabIndex = 1002;
			rbDumpToFile.TabStop = true;
			rbDumpToFile.Text = "Dump to Files";
			rbDumpToFile.UseVisualStyleBackColor = true;
			// 
			// cbTableSelector
			// 
			cbTableSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbTableSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTableSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbTableSelector.FormattingEnabled = true;
			cbTableSelector.Location = new Point(56, 5);
			cbTableSelector.Margin = new Padding(4, 3, 4, 3);
			cbTableSelector.Name = "cbTableSelector";
			cbTableSelector.Size = new Size(139, 23);
			cbTableSelector.TabIndex = 1003;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(208, 203, 148);
			label1.Location = new Point(13, 9);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 1004;
			label1.Text = "Table";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(208, 203, 148);
			label2.Location = new Point(203, 9);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(95, 15);
			label2.TabIndex = 1006;
			label2.Text = "Target Language";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbOutputLanguageSelector
			// 
			cbOutputLanguageSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbOutputLanguageSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			cbOutputLanguageSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbOutputLanguageSelector.FormattingEnabled = true;
			cbOutputLanguageSelector.Location = new Point(306, 5);
			cbOutputLanguageSelector.Margin = new Padding(4, 3, 4, 3);
			cbOutputLanguageSelector.Name = "cbOutputLanguageSelector";
			cbOutputLanguageSelector.Size = new Size(58, 23);
			cbOutputLanguageSelector.TabIndex = 1005;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(208, 203, 148);
			label3.Location = new Point(372, 9);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(88, 15);
			label3.TabIndex = 1007;
			label3.Text = "Start From Row";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbStartFromRowNumber
			// 
			tbStartFromRowNumber.BackColor = Color.FromArgb(28, 30, 31);
			tbStartFromRowNumber.BorderStyle = BorderStyle.FixedSingle;
			tbStartFromRowNumber.ForeColor = Color.FromArgb(208, 203, 148);
			tbStartFromRowNumber.Location = new Point(468, 5);
			tbStartFromRowNumber.Margin = new Padding(4, 3, 4, 3);
			tbStartFromRowNumber.Name = "tbStartFromRowNumber";
			tbStartFromRowNumber.Size = new Size(30, 23);
			tbStartFromRowNumber.TabIndex = 1008;
			tbStartFromRowNumber.Text = "0";
			tbStartFromRowNumber.TextAlign = HorizontalAlignment.Center;
			// 
			// pbProgress
			// 
			pbProgress.BackColor = Color.FromArgb(28, 30, 31);
			pbProgress.Location = new Point(13, 97);
			pbProgress.Margin = new Padding(4, 3, 4, 3);
			pbProgress.Name = "pbProgress";
			pbProgress.Size = new Size(485, 27);
			pbProgress.Step = 1;
			pbProgress.TabIndex = 1009;
			// 
			// rbGoogle
			// 
			rbGoogle.AutoSize = true;
			rbGoogle.Checked = true;
			rbGoogle.ForeColor = Color.FromArgb(208, 203, 148);
			rbGoogle.Location = new Point(71, 1);
			rbGoogle.Margin = new Padding(4, 3, 4, 3);
			rbGoogle.Name = "rbGoogle";
			rbGoogle.Size = new Size(63, 19);
			rbGoogle.TabIndex = 1010;
			rbGoogle.TabStop = true;
			rbGoogle.Text = "Google";
			rbGoogle.UseVisualStyleBackColor = true;
			// 
			// rbDeepL
			// 
			rbDeepL.AutoSize = true;
			rbDeepL.ForeColor = Color.FromArgb(208, 203, 148);
			rbDeepL.Location = new Point(142, 1);
			rbDeepL.Margin = new Padding(4, 3, 4, 3);
			rbDeepL.Name = "rbDeepL";
			rbDeepL.Size = new Size(58, 19);
			rbDeepL.TabIndex = 1011;
			rbDeepL.Text = "DeepL";
			rbDeepL.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(208, 203, 148);
			label4.Location = new Point(4, 3);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(59, 15);
			label4.TabIndex = 1012;
			label4.Text = "Translator";
			label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			panel1.Controls.Add(label4);
			panel1.Controls.Add(rbDeepL);
			panel1.Controls.Add(rbGoogle);
			panel1.Location = new Point(293, 34);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(205, 24);
			panel1.TabIndex = 1048;
			// 
			// panel2
			// 
			panel2.Controls.Add(rbUpdateDB);
			panel2.Controls.Add(rbDumpToFile);
			panel2.Location = new Point(13, 34);
			panel2.Margin = new Padding(4, 3, 4, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(270, 24);
			panel2.TabIndex = 1049;
			// 
			// DBStringTranslator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(511, 136);
			Controls.Add(pbProgress);
			Controls.Add(tbStartFromRowNumber);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(cbOutputLanguageSelector);
			Controls.Add(label1);
			Controls.Add(cbTableSelector);
			Controls.Add(btnTranslate);
			Controls.Add(panel1);
			Controls.Add(panel2);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MaximumSize = new Size(527, 175);
			MinimizeBox = false;
			MinimumSize = new Size(527, 175);
			Name = "DBStringTranslator";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DataBase String Translator";
			Load += DBStringTranslator_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private Button btnTranslate;
		private RadioButton rbUpdateDB;
		private RadioButton rbDumpToFile;
		private ComboBox cbTableSelector;
		private Label label1;
		private Label label2;
		private ComboBox cbOutputLanguageSelector;
		private Label label3;
		private TextBox tbStartFromRowNumber;
		private ProgressBar pbProgress;
		private RadioButton rbGoogle;
		private RadioButton rbDeepL;
		private Label label4;
		private Panel panel1;
		private Panel panel2;
	}
}