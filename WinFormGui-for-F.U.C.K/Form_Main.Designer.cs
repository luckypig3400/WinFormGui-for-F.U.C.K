namespace WFGF.U.C.K
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_bigMenu = new System.Windows.Forms.Panel();
            this.panel_businessSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_business_other = new System.Windows.Forms.Button();
            this.sbtn_business_income = new System.Windows.Forms.Button();
            this.sbtn_cusInfo = new System.Windows.Forms.Button();
            this.btn_business = new System.Windows.Forms.Button();
            this.debugBtn = new System.Windows.Forms.Button();
            this.btn_csv2json = new System.Windows.Forms.Button();
            this.panel_ExcelSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_Excel_Editor = new System.Windows.Forms.Button();
            this.sbtn_Excel_Reader = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_FUCKprofileEditor = new System.Windows.Forms.Button();
            this.btn_simpleRestCleint = new System.Windows.Forms.Button();
            this.panel_basicSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_killNodeJS = new System.Windows.Forms.Button();
            this.sbtn_FUCK_restart = new System.Windows.Forms.Button();
            this.sbtn_FUCK_test = new System.Windows.Forms.Button();
            this.sbtn_FUCK_launch = new System.Windows.Forms.Button();
            this.btn_serviceFUCKoptions = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_lily = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_bigMenu.SuspendLayout();
            this.panel_businessSubMenu.SuspendLayout();
            this.panel_ExcelSubMenu.SuspendLayout();
            this.panel_basicSubMenu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel_top.Controls.Add(this.label8);
            this.panel_top.Controls.Add(this.pictureBox2);
            this.panel_top.Controls.Add(this.btn_min);
            this.panel_top.Controls.Add(this.btn_max);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1280, 50);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.label8.Location = new System.Drawing.Point(61, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(610, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "WFGF.U.C.K--Windows Form Gui for FHIR-Universal-Conversion-Kit";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormGuiForF.U.C.K.Properties.Resources.fuck_logo;
            this.pictureBox2.Location = new System.Drawing.Point(19, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(1132, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 50);
            this.btn_min.TabIndex = 0;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(1181, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 50);
            this.btn_max.TabIndex = 0;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1230, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            this.btn_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseMove);
            // 
            // panel_bigMenu
            // 
            this.panel_bigMenu.AutoScroll = true;
            this.panel_bigMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.panel_bigMenu.Controls.Add(this.panel_businessSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_business);
            this.panel_bigMenu.Controls.Add(this.debugBtn);
            this.panel_bigMenu.Controls.Add(this.btn_csv2json);
            this.panel_bigMenu.Controls.Add(this.panel_ExcelSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_Excel);
            this.panel_bigMenu.Controls.Add(this.btn_FUCKprofileEditor);
            this.panel_bigMenu.Controls.Add(this.btn_simpleRestCleint);
            this.panel_bigMenu.Controls.Add(this.panel_basicSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_serviceFUCKoptions);
            this.panel_bigMenu.Controls.Add(this.btn_home);
            this.panel_bigMenu.Controls.Add(this.panel_logo);
            this.panel_bigMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bigMenu.Location = new System.Drawing.Point(0, 50);
            this.panel_bigMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bigMenu.Name = "panel_bigMenu";
            this.panel_bigMenu.Size = new System.Drawing.Size(247, 750);
            this.panel_bigMenu.TabIndex = 0;
            // 
            // panel_businessSubMenu
            // 
            this.panel_businessSubMenu.AutoSize = true;
            this.panel_businessSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_businessSubMenu.Controls.Add(this.sbtn_business_other);
            this.panel_businessSubMenu.Controls.Add(this.sbtn_business_income);
            this.panel_businessSubMenu.Controls.Add(this.sbtn_cusInfo);
            this.panel_businessSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_businessSubMenu.Location = new System.Drawing.Point(0, 838);
            this.panel_businessSubMenu.Name = "panel_businessSubMenu";
            this.panel_businessSubMenu.Size = new System.Drawing.Size(226, 150);
            this.panel_businessSubMenu.TabIndex = 9;
            // 
            // sbtn_business_other
            // 
            this.sbtn_business_other.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_business_other.FlatAppearance.BorderSize = 0;
            this.sbtn_business_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_business_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_business_other.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_business_other.Location = new System.Drawing.Point(0, 100);
            this.sbtn_business_other.Name = "sbtn_business_other";
            this.sbtn_business_other.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_business_other.Size = new System.Drawing.Size(226, 50);
            this.sbtn_business_other.TabIndex = 1;
            this.sbtn_business_other.Text = "右側查詢左側顯示";
            this.sbtn_business_other.UseVisualStyleBackColor = true;
            this.sbtn_business_other.Click += new System.EventHandler(this.sbtn_business_other_Click);
            // 
            // sbtn_business_income
            // 
            this.sbtn_business_income.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_business_income.FlatAppearance.BorderSize = 0;
            this.sbtn_business_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_business_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_business_income.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_business_income.Location = new System.Drawing.Point(0, 50);
            this.sbtn_business_income.Name = "sbtn_business_income";
            this.sbtn_business_income.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_business_income.Size = new System.Drawing.Size(226, 50);
            this.sbtn_business_income.TabIndex = 0;
            this.sbtn_business_income.Text = "左側查詢右側顯示";
            this.sbtn_business_income.UseVisualStyleBackColor = true;
            this.sbtn_business_income.Click += new System.EventHandler(this.sbtn_business_income_Click);
            // 
            // sbtn_cusInfo
            // 
            this.sbtn_cusInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_cusInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_cusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_cusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_cusInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_cusInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_cusInfo.Name = "sbtn_cusInfo";
            this.sbtn_cusInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_cusInfo.Size = new System.Drawing.Size(226, 50);
            this.sbtn_cusInfo.TabIndex = 0;
            this.sbtn_cusInfo.Text = "上方查詢下方顯示";
            this.sbtn_cusInfo.UseVisualStyleBackColor = true;
            this.sbtn_cusInfo.Click += new System.EventHandler(this.sbtn_cusInfo_Click);
            // 
            // btn_business
            // 
            this.btn_business.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_business.FlatAppearance.BorderSize = 0;
            this.btn_business.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_business.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_business.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_business.Image = ((System.Drawing.Image)(resources.GetObject("btn_business.Image")));
            this.btn_business.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_business.Location = new System.Drawing.Point(0, 783);
            this.btn_business.Name = "btn_business";
            this.btn_business.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_business.Size = new System.Drawing.Size(226, 55);
            this.btn_business.TabIndex = 8;
            this.btn_business.Text = "  介面模板";
            this.btn_business.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_business.UseVisualStyleBackColor = true;
            this.btn_business.Visible = false;
            this.btn_business.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // debugBtn
            // 
            this.debugBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.debugBtn.FlatAppearance.BorderSize = 0;
            this.debugBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.debugBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.debugBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debugBtn.Location = new System.Drawing.Point(0, 728);
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.debugBtn.Size = new System.Drawing.Size(226, 55);
            this.debugBtn.TabIndex = 18;
            this.debugBtn.Text = "  Debug按鈕";
            this.debugBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.debugBtn.UseVisualStyleBackColor = true;
            this.debugBtn.Visible = false;
            this.debugBtn.Click += new System.EventHandler(this.debugBtn_Click);
            // 
            // btn_csv2json
            // 
            this.btn_csv2json.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_csv2json.FlatAppearance.BorderSize = 0;
            this.btn_csv2json.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_csv2json.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_csv2json.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_csv2json.Image = ((System.Drawing.Image)(resources.GetObject("btn_csv2json.Image")));
            this.btn_csv2json.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_csv2json.Location = new System.Drawing.Point(0, 673);
            this.btn_csv2json.Name = "btn_csv2json";
            this.btn_csv2json.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_csv2json.Size = new System.Drawing.Size(226, 55);
            this.btn_csv2json.TabIndex = 14;
            this.btn_csv2json.Text = "  CSV轉JSON";
            this.btn_csv2json.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_csv2json.UseVisualStyleBackColor = true;
            this.btn_csv2json.Click += new System.EventHandler(this.btn_csv2json_Click);
            // 
            // panel_ExcelSubMenu
            // 
            this.panel_ExcelSubMenu.AutoSize = true;
            this.panel_ExcelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_ExcelSubMenu.Controls.Add(this.sbtn_Excel_Editor);
            this.panel_ExcelSubMenu.Controls.Add(this.sbtn_Excel_Reader);
            this.panel_ExcelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ExcelSubMenu.Location = new System.Drawing.Point(0, 573);
            this.panel_ExcelSubMenu.Name = "panel_ExcelSubMenu";
            this.panel_ExcelSubMenu.Size = new System.Drawing.Size(226, 100);
            this.panel_ExcelSubMenu.TabIndex = 16;
            // 
            // sbtn_Excel_Editor
            // 
            this.sbtn_Excel_Editor.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_Excel_Editor.FlatAppearance.BorderSize = 0;
            this.sbtn_Excel_Editor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_Excel_Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_Excel_Editor.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_Excel_Editor.Location = new System.Drawing.Point(0, 50);
            this.sbtn_Excel_Editor.Name = "sbtn_Excel_Editor";
            this.sbtn_Excel_Editor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_Excel_Editor.Size = new System.Drawing.Size(226, 50);
            this.sbtn_Excel_Editor.TabIndex = 1;
            this.sbtn_Excel_Editor.Text = "編輯Excel";
            this.sbtn_Excel_Editor.UseVisualStyleBackColor = true;
            this.sbtn_Excel_Editor.Click += new System.EventHandler(this.sbtn_Excel_Editor_Click);
            // 
            // sbtn_Excel_Reader
            // 
            this.sbtn_Excel_Reader.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_Excel_Reader.FlatAppearance.BorderSize = 0;
            this.sbtn_Excel_Reader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_Excel_Reader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_Excel_Reader.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_Excel_Reader.Location = new System.Drawing.Point(0, 0);
            this.sbtn_Excel_Reader.Name = "sbtn_Excel_Reader";
            this.sbtn_Excel_Reader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_Excel_Reader.Size = new System.Drawing.Size(226, 50);
            this.sbtn_Excel_Reader.TabIndex = 0;
            this.sbtn_Excel_Reader.Text = "預覽Excel";
            this.sbtn_Excel_Reader.UseVisualStyleBackColor = true;
            this.sbtn_Excel_Reader.Click += new System.EventHandler(this.sbtn_Excel_Reader_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Excel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel.Image")));
            this.btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel.Location = new System.Drawing.Point(0, 518);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Excel.Size = new System.Drawing.Size(226, 55);
            this.btn_Excel.TabIndex = 17;
            this.btn_Excel.Text = "  Excel範例文件";
            this.btn_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_FUCKprofileEditor
            // 
            this.btn_FUCKprofileEditor.AutoSize = true;
            this.btn_FUCKprofileEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FUCKprofileEditor.FlatAppearance.BorderSize = 0;
            this.btn_FUCKprofileEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FUCKprofileEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FUCKprofileEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_FUCKprofileEditor.Image = ((System.Drawing.Image)(resources.GetObject("btn_FUCKprofileEditor.Image")));
            this.btn_FUCKprofileEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FUCKprofileEditor.Location = new System.Drawing.Point(0, 450);
            this.btn_FUCKprofileEditor.Name = "btn_FUCKprofileEditor";
            this.btn_FUCKprofileEditor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_FUCKprofileEditor.Size = new System.Drawing.Size(226, 68);
            this.btn_FUCKprofileEditor.TabIndex = 12;
            this.btn_FUCKprofileEditor.Text = "  編輯F.U.C.K\r\n       Profile";
            this.btn_FUCKprofileEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FUCKprofileEditor.UseVisualStyleBackColor = true;
            this.btn_FUCKprofileEditor.Click += new System.EventHandler(this.btn_FUCKprofileEditor_Click);
            // 
            // btn_simpleRestCleint
            // 
            this.btn_simpleRestCleint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_simpleRestCleint.FlatAppearance.BorderSize = 0;
            this.btn_simpleRestCleint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpleRestCleint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_simpleRestCleint.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_simpleRestCleint.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpleRestCleint.Image")));
            this.btn_simpleRestCleint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpleRestCleint.Location = new System.Drawing.Point(0, 395);
            this.btn_simpleRestCleint.Name = "btn_simpleRestCleint";
            this.btn_simpleRestCleint.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_simpleRestCleint.Size = new System.Drawing.Size(226, 55);
            this.btn_simpleRestCleint.TabIndex = 15;
            this.btn_simpleRestCleint.Text = "  簡易RestClient";
            this.btn_simpleRestCleint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_simpleRestCleint.UseVisualStyleBackColor = true;
            this.btn_simpleRestCleint.Click += new System.EventHandler(this.btn_simpleRestCleint_Click);
            // 
            // panel_basicSubMenu
            // 
            this.panel_basicSubMenu.AutoSize = true;
            this.panel_basicSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_basicSubMenu.Controls.Add(this.sbtn_killNodeJS);
            this.panel_basicSubMenu.Controls.Add(this.sbtn_FUCK_restart);
            this.panel_basicSubMenu.Controls.Add(this.sbtn_FUCK_test);
            this.panel_basicSubMenu.Controls.Add(this.sbtn_FUCK_launch);
            this.panel_basicSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_basicSubMenu.Location = new System.Drawing.Point(0, 195);
            this.panel_basicSubMenu.Name = "panel_basicSubMenu";
            this.panel_basicSubMenu.Size = new System.Drawing.Size(226, 200);
            this.panel_basicSubMenu.TabIndex = 3;
            // 
            // sbtn_killNodeJS
            // 
            this.sbtn_killNodeJS.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_killNodeJS.FlatAppearance.BorderSize = 0;
            this.sbtn_killNodeJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_killNodeJS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_killNodeJS.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_killNodeJS.Location = new System.Drawing.Point(0, 150);
            this.sbtn_killNodeJS.Name = "sbtn_killNodeJS";
            this.sbtn_killNodeJS.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_killNodeJS.Size = new System.Drawing.Size(226, 50);
            this.sbtn_killNodeJS.TabIndex = 3;
            this.sbtn_killNodeJS.Text = "停止所有Node.js服務";
            this.sbtn_killNodeJS.UseVisualStyleBackColor = true;
            this.sbtn_killNodeJS.Click += new System.EventHandler(this.sbtn_killNodeJS_Click);
            // 
            // sbtn_FUCK_restart
            // 
            this.sbtn_FUCK_restart.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_FUCK_restart.FlatAppearance.BorderSize = 0;
            this.sbtn_FUCK_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_FUCK_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_FUCK_restart.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_FUCK_restart.Location = new System.Drawing.Point(0, 100);
            this.sbtn_FUCK_restart.Name = "sbtn_FUCK_restart";
            this.sbtn_FUCK_restart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_FUCK_restart.Size = new System.Drawing.Size(226, 50);
            this.sbtn_FUCK_restart.TabIndex = 1;
            this.sbtn_FUCK_restart.Text = "重啟F.U.C.K";
            this.sbtn_FUCK_restart.UseVisualStyleBackColor = true;
            this.sbtn_FUCK_restart.Click += new System.EventHandler(this.sbtn_FUCK_restart_Click);
            // 
            // sbtn_FUCK_test
            // 
            this.sbtn_FUCK_test.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_FUCK_test.FlatAppearance.BorderSize = 0;
            this.sbtn_FUCK_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_FUCK_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_FUCK_test.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_FUCK_test.Location = new System.Drawing.Point(0, 50);
            this.sbtn_FUCK_test.Name = "sbtn_FUCK_test";
            this.sbtn_FUCK_test.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_FUCK_test.Size = new System.Drawing.Size(226, 50);
            this.sbtn_FUCK_test.TabIndex = 2;
            this.sbtn_FUCK_test.Text = "測試F.U.C.K";
            this.sbtn_FUCK_test.UseVisualStyleBackColor = true;
            this.sbtn_FUCK_test.Click += new System.EventHandler(this.sbtn_FUCK_test_Click);
            // 
            // sbtn_FUCK_launch
            // 
            this.sbtn_FUCK_launch.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_FUCK_launch.FlatAppearance.BorderSize = 0;
            this.sbtn_FUCK_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_FUCK_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_FUCK_launch.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_FUCK_launch.Location = new System.Drawing.Point(0, 0);
            this.sbtn_FUCK_launch.Name = "sbtn_FUCK_launch";
            this.sbtn_FUCK_launch.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_FUCK_launch.Size = new System.Drawing.Size(226, 50);
            this.sbtn_FUCK_launch.TabIndex = 0;
            this.sbtn_FUCK_launch.Text = "啟動F.U.C.K";
            this.sbtn_FUCK_launch.UseVisualStyleBackColor = true;
            this.sbtn_FUCK_launch.Click += new System.EventHandler(this.sbtn_FUCK_launch_Click);
            // 
            // btn_serviceFUCKoptions
            // 
            this.btn_serviceFUCKoptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_serviceFUCKoptions.FlatAppearance.BorderSize = 0;
            this.btn_serviceFUCKoptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serviceFUCKoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_serviceFUCKoptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_serviceFUCKoptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_serviceFUCKoptions.Image")));
            this.btn_serviceFUCKoptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_serviceFUCKoptions.Location = new System.Drawing.Point(0, 140);
            this.btn_serviceFUCKoptions.Name = "btn_serviceFUCKoptions";
            this.btn_serviceFUCKoptions.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_serviceFUCKoptions.Size = new System.Drawing.Size(226, 55);
            this.btn_serviceFUCKoptions.TabIndex = 2;
            this.btn_serviceFUCKoptions.Text = "  服務選單";
            this.btn_serviceFUCKoptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_serviceFUCKoptions.UseVisualStyleBackColor = true;
            this.btn_serviceFUCKoptions.Click += new System.EventHandler(this.btn_serviceFUCKoptions_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_home.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 85);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(226, 55);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "  首 頁";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.AutoSize = true;
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(226, 85);
            this.panel_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "WFGF.U.C.K";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormGuiForF.U.C.K.Properties.Resources.fuck_logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.panel_bottom.Controls.Add(this.label_time);
            this.panel_bottom.Controls.Add(this.label2);
            this.panel_bottom.Controls.Add(this.label_lily);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(247, 760);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1033, 40);
            this.panel_bottom.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(693, 10);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(114, 25);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "HH:MM:SS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "C# Windows Form GUI for FHIR-Universal-Conversion-Kit";
            // 
            // label_lily
            // 
            this.label_lily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lily.AutoSize = true;
            this.label_lily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_lily.ForeColor = System.Drawing.Color.White;
            this.label_lily.Location = new System.Drawing.Point(921, 9);
            this.label_lily.Name = "label_lily";
            this.label_lily.Size = new System.Drawing.Size(105, 25);
            this.label_lily.TabIndex = 0;
            this.label_lily.Text = "Lily Edition";
            this.label_lily.Click += new System.EventHandler(this.label_Lily_Click);
            this.label_lily.MouseLeave += new System.EventHandler(this.label_lily_MouseLeave);
            this.label_lily.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_lily_MouseMove);
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(247, 50);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1033, 710);
            this.panel_childForm.TabIndex = 0;
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_bigMenu);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinFormGui-for-F.U.C.K";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_bigMenu.ResumeLayout(false);
            this.panel_bigMenu.PerformLayout();
            this.panel_businessSubMenu.ResumeLayout(false);
            this.panel_ExcelSubMenu.ResumeLayout(false);
            this.panel_basicSubMenu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bigMenu;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_basicSubMenu;
        private System.Windows.Forms.Button sbtn_FUCK_launch;
        private System.Windows.Forms.Button sbtn_FUCK_restart;
        private System.Windows.Forms.Panel panel_businessSubMenu;
        private System.Windows.Forms.Button sbtn_business_other;
        private System.Windows.Forms.Button sbtn_business_income;
        private System.Windows.Forms.Button sbtn_cusInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.Label label_lily;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btn_serviceFUCKoptions;
        public System.Windows.Forms.Button btn_business;
        public System.Windows.Forms.Button btn_csv2json;
        public System.Windows.Forms.Button btn_FUCKprofileEditor;
        private System.Windows.Forms.Button sbtn_FUCK_test;
        private System.Windows.Forms.Button sbtn_killNodeJS;
        public System.Windows.Forms.Button btn_simpleRestCleint;
        private System.Windows.Forms.Panel panel_ExcelSubMenu;
        private System.Windows.Forms.Button sbtn_Excel_Editor;
        private System.Windows.Forms.Button sbtn_Excel_Reader;
        public System.Windows.Forms.Button btn_Excel;
        public System.Windows.Forms.Button debugBtn;
    }
}
