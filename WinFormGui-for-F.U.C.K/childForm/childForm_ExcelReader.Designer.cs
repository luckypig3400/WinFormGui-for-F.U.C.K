namespace WFGF.U.C.K.childForm
{
    partial class childForm_ExcelReader
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Excel 閱讀器";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 108);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 58);
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
            this.currentFilePathOutput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.materialLabel3.Text = "目前讀取檔案的路徑:";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(496, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 599);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 599);
            this.dataGridView1.TabIndex = 0;
            // 
            // childForm_ExcelReader
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "childForm_ExcelReader";
            this.Text = "childForm_ExcelReader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton loadFileDialogBtn;
        private MaterialSkin.Controls.MaterialComboBox fileListComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox currentFilePathOutput;
        private MaterialSkin.Controls.MaterialSwitch enableDarkThemeSwitch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
