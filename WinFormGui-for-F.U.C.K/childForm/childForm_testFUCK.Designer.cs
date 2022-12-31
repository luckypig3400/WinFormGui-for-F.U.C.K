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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.url_textBox = new System.Windows.Forms.TextBox();
            this.btn_selectA = new System.Windows.Forms.Button();
            this.label_QType = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1060, 44);
            this.panel_top.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "測試F.U.C.K";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.panel_left.Controls.Add(this.groupBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 44);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(505, 666);
            this.panel_left.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.url_textBox);
            this.groupBox1.Controls.Add(this.btn_selectA);
            this.groupBox1.Controls.Add(this.label_QType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "簡易測試";
            // 
            // url_textBox
            // 
            this.url_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.url_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.url_textBox.Location = new System.Drawing.Point(141, 51);
            this.url_textBox.Name = "url_textBox";
            this.url_textBox.Size = new System.Drawing.Size(322, 22);
            this.url_textBox.TabIndex = 5;
            this.url_textBox.Text = "http://localhost:1337";
            // 
            // btn_selectA
            // 
            this.btn_selectA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_selectA.FlatAppearance.BorderSize = 0;
            this.btn_selectA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectA.ForeColor = System.Drawing.Color.White;
            this.btn_selectA.Location = new System.Drawing.Point(322, 116);
            this.btn_selectA.Name = "btn_selectA";
            this.btn_selectA.Size = new System.Drawing.Size(141, 40);
            this.btn_selectA.TabIndex = 3;
            this.btn_selectA.Text = "點擊查詢";
            this.btn_selectA.UseVisualStyleBackColor = false;
            this.btn_selectA.Click += new System.EventHandler(this.btn_selectA_Click);
            // 
            // label_QType
            // 
            this.label_QType.AutoSize = true;
            this.label_QType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_QType.Location = new System.Drawing.Point(14, 51);
            this.label_QType.Name = "label_QType";
            this.label_QType.Size = new System.Drawing.Size(121, 24);
            this.label_QType.TabIndex = 6;
            this.label_QType.Text = "F.U.C.K URL:";
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(505, 44);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(555, 666);
            this.panel_right.TabIndex = 6;
            // 
            // childForm_testFUCK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1060, 710);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childForm_testFUCK";
            this.Text = "childForm_attendanceInfo";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox url_textBox;
        private System.Windows.Forms.Button btn_selectA;
        private System.Windows.Forms.Label label_QType;
        private System.Windows.Forms.Panel panel_right;
    }
}
