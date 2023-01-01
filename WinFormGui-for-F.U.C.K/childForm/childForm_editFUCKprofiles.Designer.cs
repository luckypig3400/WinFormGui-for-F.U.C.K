namespace WFGF.U.C.K.childForm
{
    partial class childForm_editFUCKprofiles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enableDarkThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentFilePathOutput = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.loadFileDialogBtn = new MaterialSkin.Controls.MaterialButton();
            this.fileListComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.reloadFileWithoutSaveBtn = new MaterialSkin.Controls.MaterialButton();
            this.saveFilelBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel_datagridview = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileEditorTextbox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.enableDarkThemeSwitch);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 44);
            this.panel1.TabIndex = 1;
            // 
            // enableDarkThemeSwitch
            // 
            this.enableDarkThemeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableDarkThemeSwitch.AutoSize = true;
            this.enableDarkThemeSwitch.Depth = 0;
            this.enableDarkThemeSwitch.Location = new System.Drawing.Point(882, 4);
            this.enableDarkThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.enableDarkThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enableDarkThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.enableDarkThemeSwitch.Name = "enableDarkThemeSwitch";
            this.enableDarkThemeSwitch.Ripple = true;
            this.enableDarkThemeSwitch.Size = new System.Drawing.Size(154, 37);
            this.enableDarkThemeSwitch.TabIndex = 2;
            this.enableDarkThemeSwitch.Text = "啟用深色模式";
            this.enableDarkThemeSwitch.UseVisualStyleBackColor = true;
            this.enableDarkThemeSwitch.CheckedChanged += new System.EventHandler(this.enableDarkThemeSwitch_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "F.U.C.K Profile 編輯器";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(564, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 599);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox2.Controls.Add(this.currentFilePathOutput);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.loadFileDialogBtn);
            this.groupBox2.Controls.Add(this.fileListComboBox);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 413);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "讀取檔案";
            // 
            // currentFilePathOutput
            // 
            this.currentFilePathOutput.AnimateReadOnly = false;
            this.currentFilePathOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentFilePathOutput.Depth = 0;
            this.currentFilePathOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentFilePathOutput.LeadingIcon = null;
            this.currentFilePathOutput.Location = new System.Drawing.Point(45, 225);
            this.currentFilePathOutput.MaxLength = 65536;
            this.currentFilePathOutput.MouseState = MaterialSkin.MouseState.OUT;
            this.currentFilePathOutput.Multiline = false;
            this.currentFilePathOutput.Name = "currentFilePathOutput";
            this.currentFilePathOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.currentFilePathOutput.Size = new System.Drawing.Size(398, 50);
            this.currentFilePathOutput.TabIndex = 5;
            this.currentFilePathOutput.Text = "";
            this.currentFilePathOutput.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(45, 172);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(186, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "目前編輯檔案的路徑:";
            // 
            // loadFileDialogBtn
            // 
            this.loadFileDialogBtn.AutoSize = false;
            this.loadFileDialogBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadFileDialogBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loadFileDialogBtn.Depth = 0;
            this.loadFileDialogBtn.HighEmphasis = true;
            this.loadFileDialogBtn.Icon = null;
            this.loadFileDialogBtn.Location = new System.Drawing.Point(85, 325);
            this.loadFileDialogBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadFileDialogBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadFileDialogBtn.Name = "loadFileDialogBtn";
            this.loadFileDialogBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loadFileDialogBtn.Size = new System.Drawing.Size(322, 55);
            this.loadFileDialogBtn.TabIndex = 2;
            this.loadFileDialogBtn.Text = "或是手動選擇其他檔案";
            this.loadFileDialogBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadFileDialogBtn.UseAccentColor = false;
            this.loadFileDialogBtn.UseVisualStyleBackColor = true;
            this.loadFileDialogBtn.Click += new System.EventHandler(this.loadFileDialogBtn_Click);
            // 
            // fileListComboBox
            // 
            this.fileListComboBox.AutoResize = false;
            this.fileListComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fileListComboBox.Depth = 0;
            this.fileListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.fileListComboBox.DropDownHeight = 174;
            this.fileListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileListComboBox.DropDownWidth = 121;
            this.fileListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fileListComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileListComboBox.FormattingEnabled = true;
            this.fileListComboBox.IntegralHeight = false;
            this.fileListComboBox.ItemHeight = 43;
            this.fileListComboBox.Location = new System.Drawing.Point(45, 94);
            this.fileListComboBox.MaxDropDownItems = 4;
            this.fileListComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.fileListComboBox.Name = "fileListComboBox";
            this.fileListComboBox.Size = new System.Drawing.Size(398, 49);
            this.fileListComboBox.StartIndex = 0;
            this.fileListComboBox.TabIndex = 1;
            this.fileListComboBox.SelectedIndexChanged += new System.EventHandler(this.fileListComboBox_SelectedIndexChanged);
            this.fileListComboBox.Click += new System.EventHandler(this.fileListComboBox_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(45, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "從清單挑選檔案";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.reloadFileWithoutSaveBtn);
            this.groupBox1.Controls.Add(this.saveFilelBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "儲存檔案";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(135, 40);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(205, 29);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "編輯完別忘了存檔 !";
            // 
            // reloadFileWithoutSaveBtn
            // 
            this.reloadFileWithoutSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadFileWithoutSaveBtn.AutoSize = false;
            this.reloadFileWithoutSaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reloadFileWithoutSaveBtn.BackColor = System.Drawing.Color.White;
            this.reloadFileWithoutSaveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.reloadFileWithoutSaveBtn.Depth = 0;
            this.reloadFileWithoutSaveBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.reloadFileWithoutSaveBtn.HighEmphasis = false;
            this.reloadFileWithoutSaveBtn.Icon = null;
            this.reloadFileWithoutSaveBtn.Location = new System.Drawing.Point(274, 85);
            this.reloadFileWithoutSaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reloadFileWithoutSaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.reloadFileWithoutSaveBtn.Name = "reloadFileWithoutSaveBtn";
            this.reloadFileWithoutSaveBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.reloadFileWithoutSaveBtn.Size = new System.Drawing.Size(169, 64);
            this.reloadFileWithoutSaveBtn.TabIndex = 1;
            this.reloadFileWithoutSaveBtn.Text = "捨棄變更\r\n重讀檔案";
            this.reloadFileWithoutSaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.reloadFileWithoutSaveBtn.UseAccentColor = false;
            this.reloadFileWithoutSaveBtn.UseVisualStyleBackColor = false;
            this.reloadFileWithoutSaveBtn.Click += new System.EventHandler(this.reloadFileWithoutSaveBtn_Click);
            // 
            // saveFilelBtn
            // 
            this.saveFilelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFilelBtn.AutoSize = false;
            this.saveFilelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveFilelBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveFilelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveFilelBtn.Depth = 0;
            this.saveFilelBtn.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveFilelBtn.HighEmphasis = true;
            this.saveFilelBtn.Icon = null;
            this.saveFilelBtn.Location = new System.Drawing.Point(50, 85);
            this.saveFilelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveFilelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveFilelBtn.Name = "saveFilelBtn";
            this.saveFilelBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveFilelBtn.Size = new System.Drawing.Size(169, 64);
            this.saveFilelBtn.TabIndex = 0;
            this.saveFilelBtn.Text = "儲存檔案";
            this.saveFilelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveFilelBtn.UseAccentColor = false;
            this.saveFilelBtn.UseVisualStyleBackColor = false;
            this.saveFilelBtn.Click += new System.EventHandler(this.saveFilelBtn_Click);
            // 
            // panel_datagridview
            // 
            this.panel_datagridview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_datagridview.Location = new System.Drawing.Point(558, 108);
            this.panel_datagridview.Name = "panel_datagridview";
            this.panel_datagridview.Size = new System.Drawing.Size(6, 599);
            this.panel_datagridview.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fileEditorTextbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 599);
            this.panel2.TabIndex = 5;
            // 
            // fileEditorTextbox
            // 
            this.fileEditorTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileEditorTextbox.Location = new System.Drawing.Point(0, 0);
            this.fileEditorTextbox.Name = "fileEditorTextbox";
            this.fileEditorTextbox.Size = new System.Drawing.Size(555, 599);
            this.fileEditorTextbox.TabIndex = 0;
            this.fileEditorTextbox.Text = "";
            // 
            // childForm_editFUCKprofiles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_datagridview);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "childForm_editFUCKprofiles";
            this.Text = "childForm_editFUCKprofiles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_datagridview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox fileEditorTextbox;
        private MaterialSkin.Controls.MaterialButton reloadFileWithoutSaveBtn;
        private MaterialSkin.Controls.MaterialButton saveFilelBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton loadFileDialogBtn;
        private MaterialSkin.Controls.MaterialComboBox fileListComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox currentFilePathOutput;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSwitch enableDarkThemeSwitch;
    }
}
