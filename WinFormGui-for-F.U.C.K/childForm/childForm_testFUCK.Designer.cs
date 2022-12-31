namespace WFGF.U.C.K.childForm
{
    partial class childForm_testFUCK
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.enableDarkThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.url_textBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel_top.Controls.Add(this.enableDarkThemeSwitch);
            this.panel_top.Controls.Add(this.materialLabel1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 64);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1054, 44);
            this.panel_top.TabIndex = 4;
            // 
            // enableDarkThemeSwitch
            // 
            this.enableDarkThemeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableDarkThemeSwitch.AutoSize = true;
            this.enableDarkThemeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.enableDarkThemeSwitch.Depth = 0;
            this.enableDarkThemeSwitch.Location = new System.Drawing.Point(885, 4);
            this.enableDarkThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.enableDarkThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enableDarkThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.enableDarkThemeSwitch.Name = "enableDarkThemeSwitch";
            this.enableDarkThemeSwitch.Ripple = true;
            this.enableDarkThemeSwitch.Size = new System.Drawing.Size(154, 37);
            this.enableDarkThemeSwitch.TabIndex = 1;
            this.enableDarkThemeSwitch.Text = "啟用深色模式";
            this.enableDarkThemeSwitch.UseVisualStyleBackColor = false;
            this.enableDarkThemeSwitch.CheckedChanged += new System.EventHandler(this.enableDarkThemeSwitch_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "測試F.U.C.K";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.panel_left.Controls.Add(this.groupBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(3, 108);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(505, 599);
            this.panel_left.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.materialButton1);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.url_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "簡易測試";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(323, 115);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(140, 44);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "開始測試";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "F.U.C.K URL:";
            // 
            // url_textBox
            // 
            this.url_textBox.AnimateReadOnly = false;
            this.url_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.url_textBox.Depth = 0;
            this.url_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.url_textBox.LeadingIcon = null;
            this.url_textBox.Location = new System.Drawing.Point(141, 39);
            this.url_textBox.MaxLength = 50;
            this.url_textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.url_textBox.Multiline = false;
            this.url_textBox.Name = "url_textBox";
            this.url_textBox.Size = new System.Drawing.Size(322, 50);
            this.url_textBox.TabIndex = 9;
            this.url_textBox.Text = "http://localhost:1337";
            this.url_textBox.TrailingIcon = null;
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(508, 108);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(549, 599);
            this.panel_right.TabIndex = 6;
            // 
            // childForm_testFUCK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.Name = "childForm_testFUCK";
            this.Text = "childForm_testF.U.C.K";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_right;
        private MaterialSkin.Controls.MaterialTextBox url_textBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch enableDarkThemeSwitch;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
