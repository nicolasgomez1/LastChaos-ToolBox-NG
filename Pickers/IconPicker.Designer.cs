namespace LastChaos_ToolBoxNG
{
    partial class IconPicker
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
			btnSelect = new Button();
			cbFileSelector = new ComboBox();
			pbImageViewer = new PictureBox();
			lbLocation = new Label();
			pbIcon = new PictureBox();
			((ISupportInitialize)pbImageViewer).BeginInit();
			((ISupportInitialize)pbIcon).BeginInit();
			SuspendLayout();
			// 
			// btnSelect
			// 
			btnSelect.Enabled = false;
			btnSelect.FlatAppearance.BorderColor = Color.FromArgb(91, 85, 76);
			btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
			btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 56, 54);
			btnSelect.FlatStyle = FlatStyle.Flat;
			btnSelect.ForeColor = Color.FromArgb(208, 203, 148);
			btnSelect.Location = new Point(284, 10);
			btnSelect.Margin = new Padding(4, 3, 4, 3);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(70, 27);
			btnSelect.TabIndex = 6;
			btnSelect.Text = "Select";
			btnSelect.UseVisualStyleBackColor = true;
			btnSelect.Click += btnSelect_Click;
			// 
			// cbFileSelector
			// 
			cbFileSelector.BackColor = Color.FromArgb(28, 30, 31);
			cbFileSelector.ForeColor = Color.FromArgb(208, 203, 148);
			cbFileSelector.FormattingEnabled = true;
			cbFileSelector.Location = new Point(13, 12);
			cbFileSelector.Margin = new Padding(4, 3, 4, 3);
			cbFileSelector.Name = "cbFileSelector";
			cbFileSelector.Size = new Size(140, 23);
			cbFileSelector.TabIndex = 7;
			cbFileSelector.SelectedIndexChanged += cbFileSelector_SelectedIndexChanged;
			// 
			// pbImageViewer
			// 
			pbImageViewer.BackColor = Color.FromArgb(28, 30, 31);
			pbImageViewer.Location = new Point(13, 46);
			pbImageViewer.Margin = new Padding(4);
			pbImageViewer.Name = "pbImageViewer";
			pbImageViewer.Size = new Size(512, 512);
			pbImageViewer.TabIndex = 8;
			pbImageViewer.TabStop = false;
			pbImageViewer.Click += pbImageViewer_Click;
			// 
			// lbLocation
			// 
			lbLocation.AutoSize = true;
			lbLocation.ForeColor = Color.FromArgb(208, 203, 148);
			lbLocation.Location = new Point(450, 16);
			lbLocation.Margin = new Padding(4, 0, 4, 0);
			lbLocation.Name = "lbLocation";
			lbLocation.Size = new Size(75, 15);
			lbLocation.TabIndex = 10;
			lbLocation.Text = "Row: 0 Col: 0";
			lbLocation.TextAlign = ContentAlignment.MiddleRight;
			// 
			// pbIcon
			// 
			pbIcon.BackgroundImage = Properties.Resources.DefaultItem;
			pbIcon.ErrorImage = null;
			pbIcon.InitialImage = null;
			pbIcon.Location = new Point(244, 7);
			pbIcon.Margin = new Padding(4, 3, 4, 3);
			pbIcon.Name = "pbIcon";
			pbIcon.Size = new Size(32, 32);
			pbIcon.TabIndex = 14;
			pbIcon.TabStop = false;
			// 
			// IconPicker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(40, 40, 40);
			ClientSize = new Size(538, 571);
			Controls.Add(pbIcon);
			Controls.Add(lbLocation);
			Controls.Add(pbImageViewer);
			Controls.Add(cbFileSelector);
			Controls.Add(btnSelect);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resources.NG;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MaximumSize = new Size(554, 610);
			MinimizeBox = false;
			MinimumSize = new Size(554, 610);
			Name = "IconPicker";
			ShowInTaskbar = false;
			Text = "Icon Picker";
			Load += IconPicker_Load;
			((ISupportInitialize)pbImageViewer).EndInit();
			((ISupportInitialize)pbIcon).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbFileSelector;
        private System.Windows.Forms.PictureBox pbImageViewer;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.PictureBox pbIcon;
    }
}