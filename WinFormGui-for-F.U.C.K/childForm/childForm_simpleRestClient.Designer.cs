namespace WFGF.U.C.K.childForm
{
    partial class childForm_simpleRestClient
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.dataGridView_emp = new System.Windows.Forms.DataGridView();
            this.requestMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.requestURL = new MaterialSkin.Controls.MaterialTextBox();
            this.sendRequestBtn = new MaterialSkin.Controls.MaterialButton();
            this.enableDarkThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.panel1.SuspendLayout();
            this.panel_center.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.enableDarkThemeSwitch);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 44);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "簡易Rest Client";
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.sendRequestBtn);
            this.panel_center.Controls.Add(this.requestURL);
            this.panel_center.Controls.Add(this.requestMethod);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.label2);
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_center.Location = new System.Drawing.Point(3, 108);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(1054, 89);
            this.panel_center.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(828, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Reponse (F.U.C.K的回傳結果)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Request (請注意! 只提供傳遞JSON的功能)";
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.dataGridView_emp);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(3, 197);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1054, 510);
            this.panel_bottom.TabIndex = 54;
            // 
            // dataGridView_emp
            // 
            this.dataGridView_emp.AllowUserToAddRows = false;
            this.dataGridView_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_emp.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_emp.Name = "dataGridView_emp";
            this.dataGridView_emp.RowHeadersWidth = 51;
            this.dataGridView_emp.RowTemplate.Height = 23;
            this.dataGridView_emp.Size = new System.Drawing.Size(1054, 510);
            this.dataGridView_emp.TabIndex = 0;
            // 
            // requestMethod
            // 
            this.requestMethod.AutoResize = false;
            this.requestMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.requestMethod.Depth = 0;
            this.requestMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.requestMethod.DropDownHeight = 174;
            this.requestMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestMethod.DropDownWidth = 121;
            this.requestMethod.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.requestMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requestMethod.FormattingEnabled = true;
            this.requestMethod.IntegralHeight = false;
            this.requestMethod.ItemHeight = 43;
            this.requestMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.requestMethod.Location = new System.Drawing.Point(16, 6);
            this.requestMethod.MaxDropDownItems = 4;
            this.requestMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.requestMethod.Name = "requestMethod";
            this.requestMethod.Size = new System.Drawing.Size(121, 49);
            this.requestMethod.StartIndex = 0;
            this.requestMethod.TabIndex = 53;
            // 
            // requestURL
            // 
            this.requestURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestURL.AnimateReadOnly = false;
            this.requestURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestURL.Depth = 0;
            this.requestURL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.requestURL.LeadingIcon = null;
            this.requestURL.Location = new System.Drawing.Point(156, 5);
            this.requestURL.MaxLength = 50;
            this.requestURL.MouseState = MaterialSkin.MouseState.OUT;
            this.requestURL.Multiline = false;
            this.requestURL.Name = "requestURL";
            this.requestURL.Size = new System.Drawing.Size(695, 50);
            this.requestURL.TabIndex = 54;
            this.requestURL.Text = "http://localhost:1337";
            this.requestURL.TrailingIcon = null;
            // 
            // sendRequestBtn
            // 
            this.sendRequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendRequestBtn.AutoSize = false;
            this.sendRequestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendRequestBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendRequestBtn.Depth = 0;
            this.sendRequestBtn.HighEmphasis = true;
            this.sendRequestBtn.Icon = null;
            this.sendRequestBtn.Location = new System.Drawing.Point(870, 5);
            this.sendRequestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendRequestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendRequestBtn.Name = "sendRequestBtn";
            this.sendRequestBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendRequestBtn.Size = new System.Drawing.Size(101, 50);
            this.sendRequestBtn.TabIndex = 55;
            this.sendRequestBtn.Text = "Send";
            this.sendRequestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendRequestBtn.UseAccentColor = false;
            this.sendRequestBtn.UseVisualStyleBackColor = true;
            // 
            // enableDarkThemeSwitch
            // 
            this.enableDarkThemeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableDarkThemeSwitch.AutoSize = true;
            this.enableDarkThemeSwitch.Depth = 0;
            this.enableDarkThemeSwitch.Location = new System.Drawing.Point(870, 4);
            this.enableDarkThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.enableDarkThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enableDarkThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.enableDarkThemeSwitch.Name = "enableDarkThemeSwitch";
            this.enableDarkThemeSwitch.Ripple = true;
            this.enableDarkThemeSwitch.Size = new System.Drawing.Size(154, 37);
            this.enableDarkThemeSwitch.TabIndex = 1;
            this.enableDarkThemeSwitch.Text = "啟用深色模式";
            this.enableDarkThemeSwitch.UseVisualStyleBackColor = true;
            this.enableDarkThemeSwitch.CheckedChanged += new System.EventHandler(this.enableDarkThemeSwitch_CheckedChanged);
            // 
            // childForm_simpleRestClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "childForm_simpleRestClient";
            this.Text = "childForm_simpleRestClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.DataGridView dataGridView_emp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton sendRequestBtn;
        private MaterialSkin.Controls.MaterialTextBox requestURL;
        private MaterialSkin.Controls.MaterialComboBox requestMethod;
        private MaterialSkin.Controls.MaterialSwitch enableDarkThemeSwitch;
    }
}
