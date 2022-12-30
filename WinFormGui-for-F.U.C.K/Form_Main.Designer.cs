﻿namespace SHRMS
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
            this.btn_systemManage = new System.Windows.Forms.Button();
            this.btn_personalInfo = new System.Windows.Forms.Button();
            this.btn_financialReport = new System.Windows.Forms.Button();
            this.panel_salarySubMenu = new System.Windows.Forms.Panel();
            this.sbtn_salaryReport = new System.Windows.Forms.Button();
            this.sbtn_salaryAssistantCal = new System.Windows.Forms.Button();
            this.sbtn_salaryHairdresserCal = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.panel_businessSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_business_report = new System.Windows.Forms.Button();
            this.sbtn_business_other = new System.Windows.Forms.Button();
            this.sbtn_business_income = new System.Windows.Forms.Button();
            this.btn_business = new System.Windows.Forms.Button();
            this.panel_cusSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_cusCardUse = new System.Windows.Forms.Button();
            this.sbtn_cusCardSell = new System.Windows.Forms.Button();
            this.sbtn_cusAdd = new System.Windows.Forms.Button();
            this.sbtn_cusAnalyze = new System.Windows.Forms.Button();
            this.sbtn_cusInfo = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.panel_empSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_empAdd = new System.Windows.Forms.Button();
            this.sbtn_empAchievement = new System.Windows.Forms.Button();
            this.sbtn_empInfo = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.panel_productSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_product_report = new System.Windows.Forms.Button();
            this.sbtn_product_refund = new System.Windows.Forms.Button();
            this.sbtn_product_in = new System.Windows.Forms.Button();
            this.sbtn_product_manage = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.panel_basicSubMenu = new System.Windows.Forms.Panel();
            this.sbtn_serviceManage = new System.Windows.Forms.Button();
            this.sbtn_providerAdd = new System.Windows.Forms.Button();
            this.sbtn_providerInfo = new System.Windows.Forms.Button();
            this.btn_basic = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_logOut = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_bigMenu.SuspendLayout();
            this.panel_salarySubMenu.SuspendLayout();
            this.panel_businessSubMenu.SuspendLayout();
            this.panel_cusSubMenu.SuspendLayout();
            this.panel_empSubMenu.SuspendLayout();
            this.panel_productSubMenu.SuspendLayout();
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
            this.pictureBox2.Image = global::HairSalonMS.Properties.Resources.fuck_logo;
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
            this.panel_bigMenu.Controls.Add(this.btn_systemManage);
            this.panel_bigMenu.Controls.Add(this.btn_personalInfo);
            this.panel_bigMenu.Controls.Add(this.btn_financialReport);
            this.panel_bigMenu.Controls.Add(this.panel_salarySubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_salary);
            this.panel_bigMenu.Controls.Add(this.panel_businessSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_business);
            this.panel_bigMenu.Controls.Add(this.panel_cusSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_customer);
            this.panel_bigMenu.Controls.Add(this.panel_empSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_employee);
            this.panel_bigMenu.Controls.Add(this.panel_productSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_product);
            this.panel_bigMenu.Controls.Add(this.panel_basicSubMenu);
            this.panel_bigMenu.Controls.Add(this.btn_basic);
            this.panel_bigMenu.Controls.Add(this.btn_home);
            this.panel_bigMenu.Controls.Add(this.panel_logo);
            this.panel_bigMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bigMenu.Location = new System.Drawing.Point(0, 50);
            this.panel_bigMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bigMenu.Name = "panel_bigMenu";
            this.panel_bigMenu.Size = new System.Drawing.Size(247, 750);
            this.panel_bigMenu.TabIndex = 0;
            // 
            // btn_systemManage
            // 
            this.btn_systemManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_systemManage.FlatAppearance.BorderSize = 0;
            this.btn_systemManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_systemManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_systemManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_systemManage.Image = ((System.Drawing.Image)(resources.GetObject("btn_systemManage.Image")));
            this.btn_systemManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_systemManage.Location = new System.Drawing.Point(0, 1630);
            this.btn_systemManage.Name = "btn_systemManage";
            this.btn_systemManage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_systemManage.Size = new System.Drawing.Size(226, 55);
            this.btn_systemManage.TabIndex = 14;
            this.btn_systemManage.Text = "  系統管理";
            this.btn_systemManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_systemManage.UseVisualStyleBackColor = true;
            this.btn_systemManage.Click += new System.EventHandler(this.btn_systemManage_Click);
            // 
            // btn_personalInfo
            // 
            this.btn_personalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_personalInfo.FlatAppearance.BorderSize = 0;
            this.btn_personalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_personalInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_personalInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_personalInfo.Image")));
            this.btn_personalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personalInfo.Location = new System.Drawing.Point(0, 1575);
            this.btn_personalInfo.Name = "btn_personalInfo";
            this.btn_personalInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_personalInfo.Size = new System.Drawing.Size(226, 55);
            this.btn_personalInfo.TabIndex = 13;
            this.btn_personalInfo.Text = "  個人資訊";
            this.btn_personalInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personalInfo.UseVisualStyleBackColor = true;
            this.btn_personalInfo.Click += new System.EventHandler(this.btn_personalInfo_Click);
            // 
            // btn_financialReport
            // 
            this.btn_financialReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_financialReport.FlatAppearance.BorderSize = 0;
            this.btn_financialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financialReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_financialReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_financialReport.Image = ((System.Drawing.Image)(resources.GetObject("btn_financialReport.Image")));
            this.btn_financialReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financialReport.Location = new System.Drawing.Point(0, 1520);
            this.btn_financialReport.Name = "btn_financialReport";
            this.btn_financialReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_financialReport.Size = new System.Drawing.Size(226, 55);
            this.btn_financialReport.TabIndex = 12;
            this.btn_financialReport.Text = "  財務報表";
            this.btn_financialReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_financialReport.UseVisualStyleBackColor = true;
            this.btn_financialReport.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // panel_salarySubMenu
            // 
            this.panel_salarySubMenu.AutoSize = true;
            this.panel_salarySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_salarySubMenu.Controls.Add(this.sbtn_salaryReport);
            this.panel_salarySubMenu.Controls.Add(this.sbtn_salaryAssistantCal);
            this.panel_salarySubMenu.Controls.Add(this.sbtn_salaryHairdresserCal);
            this.panel_salarySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_salarySubMenu.Location = new System.Drawing.Point(0, 1370);
            this.panel_salarySubMenu.Name = "panel_salarySubMenu";
            this.panel_salarySubMenu.Size = new System.Drawing.Size(226, 150);
            this.panel_salarySubMenu.TabIndex = 11;
            // 
            // sbtn_salaryReport
            // 
            this.sbtn_salaryReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_salaryReport.FlatAppearance.BorderSize = 0;
            this.sbtn_salaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_salaryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_salaryReport.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_salaryReport.Location = new System.Drawing.Point(0, 100);
            this.sbtn_salaryReport.Name = "sbtn_salaryReport";
            this.sbtn_salaryReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_salaryReport.Size = new System.Drawing.Size(226, 50);
            this.sbtn_salaryReport.TabIndex = 2;
            this.sbtn_salaryReport.Text = "薪資總表";
            this.sbtn_salaryReport.UseVisualStyleBackColor = true;
            this.sbtn_salaryReport.Click += new System.EventHandler(this.sbtn_salaryReport_Click);
            // 
            // sbtn_salaryAssistantCal
            // 
            this.sbtn_salaryAssistantCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_salaryAssistantCal.FlatAppearance.BorderSize = 0;
            this.sbtn_salaryAssistantCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_salaryAssistantCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_salaryAssistantCal.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_salaryAssistantCal.Location = new System.Drawing.Point(0, 50);
            this.sbtn_salaryAssistantCal.Name = "sbtn_salaryAssistantCal";
            this.sbtn_salaryAssistantCal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_salaryAssistantCal.Size = new System.Drawing.Size(226, 50);
            this.sbtn_salaryAssistantCal.TabIndex = 1;
            this.sbtn_salaryAssistantCal.Text = "助理抽成計算表";
            this.sbtn_salaryAssistantCal.UseVisualStyleBackColor = true;
            this.sbtn_salaryAssistantCal.Click += new System.EventHandler(this.sbtn_salaryAssistantCal_Click);
            // 
            // sbtn_salaryHairdresserCal
            // 
            this.sbtn_salaryHairdresserCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_salaryHairdresserCal.FlatAppearance.BorderSize = 0;
            this.sbtn_salaryHairdresserCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_salaryHairdresserCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_salaryHairdresserCal.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_salaryHairdresserCal.Location = new System.Drawing.Point(0, 0);
            this.sbtn_salaryHairdresserCal.Name = "sbtn_salaryHairdresserCal";
            this.sbtn_salaryHairdresserCal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_salaryHairdresserCal.Size = new System.Drawing.Size(226, 50);
            this.sbtn_salaryHairdresserCal.TabIndex = 0;
            this.sbtn_salaryHairdresserCal.Text = "設計師抽成計算表";
            this.sbtn_salaryHairdresserCal.UseVisualStyleBackColor = true;
            this.sbtn_salaryHairdresserCal.Click += new System.EventHandler(this.sbtn_salaryHairdresserCal_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_salary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_salary.Image = ((System.Drawing.Image)(resources.GetObject("btn_salary.Image")));
            this.btn_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.Location = new System.Drawing.Point(0, 1315);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_salary.Size = new System.Drawing.Size(226, 55);
            this.btn_salary.TabIndex = 10;
            this.btn_salary.Text = "  薪資管理";
            this.btn_salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // panel_businessSubMenu
            // 
            this.panel_businessSubMenu.AutoSize = true;
            this.panel_businessSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_businessSubMenu.Controls.Add(this.sbtn_business_report);
            this.panel_businessSubMenu.Controls.Add(this.sbtn_business_other);
            this.panel_businessSubMenu.Controls.Add(this.sbtn_business_income);
            this.panel_businessSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_businessSubMenu.Location = new System.Drawing.Point(0, 1165);
            this.panel_businessSubMenu.Name = "panel_businessSubMenu";
            this.panel_businessSubMenu.Size = new System.Drawing.Size(226, 150);
            this.panel_businessSubMenu.TabIndex = 9;
            // 
            // sbtn_business_report
            // 
            this.sbtn_business_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_business_report.FlatAppearance.BorderSize = 0;
            this.sbtn_business_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_business_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_business_report.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_business_report.Location = new System.Drawing.Point(0, 100);
            this.sbtn_business_report.Name = "sbtn_business_report";
            this.sbtn_business_report.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_business_report.Size = new System.Drawing.Size(226, 50);
            this.sbtn_business_report.TabIndex = 2;
            this.sbtn_business_report.Text = "營業報表(日/月/年)";
            this.sbtn_business_report.UseVisualStyleBackColor = true;
            this.sbtn_business_report.Click += new System.EventHandler(this.sbtn_business_report_Click);
            // 
            // sbtn_business_other
            // 
            this.sbtn_business_other.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_business_other.FlatAppearance.BorderSize = 0;
            this.sbtn_business_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_business_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_business_other.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_business_other.Location = new System.Drawing.Point(0, 50);
            this.sbtn_business_other.Name = "sbtn_business_other";
            this.sbtn_business_other.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_business_other.Size = new System.Drawing.Size(226, 50);
            this.sbtn_business_other.TabIndex = 1;
            this.sbtn_business_other.Text = "其他收入/支出作業";
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
            this.sbtn_business_income.Location = new System.Drawing.Point(0, 0);
            this.sbtn_business_income.Name = "sbtn_business_income";
            this.sbtn_business_income.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_business_income.Size = new System.Drawing.Size(226, 50);
            this.sbtn_business_income.TabIndex = 0;
            this.sbtn_business_income.Text = "營業收入作業";
            this.sbtn_business_income.UseVisualStyleBackColor = true;
            this.sbtn_business_income.Click += new System.EventHandler(this.sbtn_business_income_Click);
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
            this.btn_business.Location = new System.Drawing.Point(0, 1110);
            this.btn_business.Name = "btn_business";
            this.btn_business.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_business.Size = new System.Drawing.Size(226, 55);
            this.btn_business.TabIndex = 8;
            this.btn_business.Text = "  營業管理";
            this.btn_business.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_business.UseVisualStyleBackColor = true;
            this.btn_business.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // panel_cusSubMenu
            // 
            this.panel_cusSubMenu.AutoSize = true;
            this.panel_cusSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_cusSubMenu.Controls.Add(this.sbtn_cusCardUse);
            this.panel_cusSubMenu.Controls.Add(this.sbtn_cusCardSell);
            this.panel_cusSubMenu.Controls.Add(this.sbtn_cusAdd);
            this.panel_cusSubMenu.Controls.Add(this.sbtn_cusAnalyze);
            this.panel_cusSubMenu.Controls.Add(this.sbtn_cusInfo);
            this.panel_cusSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cusSubMenu.Location = new System.Drawing.Point(0, 860);
            this.panel_cusSubMenu.Name = "panel_cusSubMenu";
            this.panel_cusSubMenu.Size = new System.Drawing.Size(226, 250);
            this.panel_cusSubMenu.TabIndex = 7;
            // 
            // sbtn_cusCardUse
            // 
            this.sbtn_cusCardUse.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_cusCardUse.FlatAppearance.BorderSize = 0;
            this.sbtn_cusCardUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_cusCardUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_cusCardUse.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_cusCardUse.Location = new System.Drawing.Point(0, 200);
            this.sbtn_cusCardUse.Name = "sbtn_cusCardUse";
            this.sbtn_cusCardUse.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_cusCardUse.Size = new System.Drawing.Size(226, 50);
            this.sbtn_cusCardUse.TabIndex = 4;
            this.sbtn_cusCardUse.Text = "卡券使用管理";
            this.sbtn_cusCardUse.UseVisualStyleBackColor = true;
            this.sbtn_cusCardUse.Click += new System.EventHandler(this.sbtn_cusCardUse_Click);
            // 
            // sbtn_cusCardSell
            // 
            this.sbtn_cusCardSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_cusCardSell.FlatAppearance.BorderSize = 0;
            this.sbtn_cusCardSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_cusCardSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_cusCardSell.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_cusCardSell.Location = new System.Drawing.Point(0, 150);
            this.sbtn_cusCardSell.Name = "sbtn_cusCardSell";
            this.sbtn_cusCardSell.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_cusCardSell.Size = new System.Drawing.Size(226, 50);
            this.sbtn_cusCardSell.TabIndex = 3;
            this.sbtn_cusCardSell.Text = "卡券販售管理";
            this.sbtn_cusCardSell.UseVisualStyleBackColor = true;
            this.sbtn_cusCardSell.Click += new System.EventHandler(this.sbtn_cusCardSell_Click);
            // 
            // sbtn_cusAdd
            // 
            this.sbtn_cusAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_cusAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_cusAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_cusAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_cusAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_cusAdd.Location = new System.Drawing.Point(0, 100);
            this.sbtn_cusAdd.Name = "sbtn_cusAdd";
            this.sbtn_cusAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_cusAdd.Size = new System.Drawing.Size(226, 50);
            this.sbtn_cusAdd.TabIndex = 2;
            this.sbtn_cusAdd.Text = "新增顧客";
            this.sbtn_cusAdd.UseVisualStyleBackColor = true;
            this.sbtn_cusAdd.Click += new System.EventHandler(this.sbtn_cusAdd_Click);
            // 
            // sbtn_cusAnalyze
            // 
            this.sbtn_cusAnalyze.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_cusAnalyze.FlatAppearance.BorderSize = 0;
            this.sbtn_cusAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_cusAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_cusAnalyze.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_cusAnalyze.Location = new System.Drawing.Point(0, 50);
            this.sbtn_cusAnalyze.Name = "sbtn_cusAnalyze";
            this.sbtn_cusAnalyze.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_cusAnalyze.Size = new System.Drawing.Size(226, 50);
            this.sbtn_cusAnalyze.TabIndex = 1;
            this.sbtn_cusAnalyze.Text = "顧客消費分析";
            this.sbtn_cusAnalyze.UseVisualStyleBackColor = true;
            this.sbtn_cusAnalyze.Click += new System.EventHandler(this.sbtn_cusAnalyze_Click);
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
            this.sbtn_cusInfo.Text = "查詢/編輯顧客";
            this.sbtn_cusInfo.UseVisualStyleBackColor = true;
            this.sbtn_cusInfo.Click += new System.EventHandler(this.sbtn_cusInfo_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_customer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_customer.Image")));
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(0, 805);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_customer.Size = new System.Drawing.Size(226, 55);
            this.btn_customer.TabIndex = 6;
            this.btn_customer.Text = "  顧客管理";
            this.btn_customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // panel_empSubMenu
            // 
            this.panel_empSubMenu.AutoSize = true;
            this.panel_empSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_empSubMenu.Controls.Add(this.sbtn_empAdd);
            this.panel_empSubMenu.Controls.Add(this.sbtn_empAchievement);
            this.panel_empSubMenu.Controls.Add(this.sbtn_empInfo);
            this.panel_empSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empSubMenu.Location = new System.Drawing.Point(0, 655);
            this.panel_empSubMenu.Name = "panel_empSubMenu";
            this.panel_empSubMenu.Size = new System.Drawing.Size(226, 150);
            this.panel_empSubMenu.TabIndex = 5;
            // 
            // sbtn_empAdd
            // 
            this.sbtn_empAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_empAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_empAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_empAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_empAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_empAdd.Location = new System.Drawing.Point(0, 100);
            this.sbtn_empAdd.Name = "sbtn_empAdd";
            this.sbtn_empAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_empAdd.Size = new System.Drawing.Size(226, 50);
            this.sbtn_empAdd.TabIndex = 2;
            this.sbtn_empAdd.Text = "新增員工";
            this.sbtn_empAdd.UseVisualStyleBackColor = true;
            this.sbtn_empAdd.Click += new System.EventHandler(this.sbtn_empAdd_Click);
            // 
            // sbtn_empAchievement
            // 
            this.sbtn_empAchievement.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_empAchievement.FlatAppearance.BorderSize = 0;
            this.sbtn_empAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_empAchievement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_empAchievement.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_empAchievement.Location = new System.Drawing.Point(0, 50);
            this.sbtn_empAchievement.Name = "sbtn_empAchievement";
            this.sbtn_empAchievement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_empAchievement.Size = new System.Drawing.Size(226, 50);
            this.sbtn_empAchievement.TabIndex = 1;
            this.sbtn_empAchievement.Text = "員工業績分析";
            this.sbtn_empAchievement.UseVisualStyleBackColor = true;
            this.sbtn_empAchievement.Click += new System.EventHandler(this.sbtn_empAchievement_Click);
            // 
            // sbtn_empInfo
            // 
            this.sbtn_empInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_empInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_empInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_empInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_empInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_empInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_empInfo.Name = "sbtn_empInfo";
            this.sbtn_empInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_empInfo.Size = new System.Drawing.Size(226, 50);
            this.sbtn_empInfo.TabIndex = 0;
            this.sbtn_empInfo.Text = "查詢/編輯員工";
            this.sbtn_empInfo.UseVisualStyleBackColor = true;
            this.sbtn_empInfo.Click += new System.EventHandler(this.sbtn_empInfo_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_employee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_employee.Image = ((System.Drawing.Image)(resources.GetObject("btn_employee.Image")));
            this.btn_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee.Location = new System.Drawing.Point(0, 600);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_employee.Size = new System.Drawing.Size(226, 55);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "  員工管理";
            this.btn_employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // panel_productSubMenu
            // 
            this.panel_productSubMenu.AutoSize = true;
            this.panel_productSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_productSubMenu.Controls.Add(this.sbtn_product_report);
            this.panel_productSubMenu.Controls.Add(this.sbtn_product_refund);
            this.panel_productSubMenu.Controls.Add(this.sbtn_product_in);
            this.panel_productSubMenu.Controls.Add(this.sbtn_product_manage);
            this.panel_productSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_productSubMenu.Location = new System.Drawing.Point(0, 400);
            this.panel_productSubMenu.Name = "panel_productSubMenu";
            this.panel_productSubMenu.Size = new System.Drawing.Size(226, 200);
            this.panel_productSubMenu.TabIndex = 15;
            // 
            // sbtn_product_report
            // 
            this.sbtn_product_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_product_report.FlatAppearance.BorderSize = 0;
            this.sbtn_product_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_product_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_product_report.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_product_report.Location = new System.Drawing.Point(0, 150);
            this.sbtn_product_report.Name = "sbtn_product_report";
            this.sbtn_product_report.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_product_report.Size = new System.Drawing.Size(226, 50);
            this.sbtn_product_report.TabIndex = 1;
            this.sbtn_product_report.Text = "庫存存量表";
            this.sbtn_product_report.UseVisualStyleBackColor = true;
            this.sbtn_product_report.Click += new System.EventHandler(this.sbtn_product_report_Click);
            // 
            // sbtn_product_refund
            // 
            this.sbtn_product_refund.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_product_refund.FlatAppearance.BorderSize = 0;
            this.sbtn_product_refund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_product_refund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_product_refund.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_product_refund.Location = new System.Drawing.Point(0, 100);
            this.sbtn_product_refund.Name = "sbtn_product_refund";
            this.sbtn_product_refund.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_product_refund.Size = new System.Drawing.Size(226, 50);
            this.sbtn_product_refund.TabIndex = 2;
            this.sbtn_product_refund.Text = "產品退貨作業";
            this.sbtn_product_refund.UseVisualStyleBackColor = true;
            this.sbtn_product_refund.Click += new System.EventHandler(this.sbtn_product_refund_Click);
            // 
            // sbtn_product_in
            // 
            this.sbtn_product_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_product_in.FlatAppearance.BorderSize = 0;
            this.sbtn_product_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_product_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_product_in.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_product_in.Location = new System.Drawing.Point(0, 50);
            this.sbtn_product_in.Name = "sbtn_product_in";
            this.sbtn_product_in.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_product_in.Size = new System.Drawing.Size(226, 50);
            this.sbtn_product_in.TabIndex = 0;
            this.sbtn_product_in.Text = "產品進貨作業";
            this.sbtn_product_in.UseVisualStyleBackColor = true;
            this.sbtn_product_in.Click += new System.EventHandler(this.sbtn_product_in_Click);
            // 
            // sbtn_product_manage
            // 
            this.sbtn_product_manage.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_product_manage.FlatAppearance.BorderSize = 0;
            this.sbtn_product_manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_product_manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_product_manage.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_product_manage.Location = new System.Drawing.Point(0, 0);
            this.sbtn_product_manage.Name = "sbtn_product_manage";
            this.sbtn_product_manage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_product_manage.Size = new System.Drawing.Size(226, 50);
            this.sbtn_product_manage.TabIndex = 2;
            this.sbtn_product_manage.Text = "產品基本資料";
            this.sbtn_product_manage.UseVisualStyleBackColor = true;
            this.sbtn_product_manage.Click += new System.EventHandler(this.sbtn_product_manage_Click);
            // 
            // btn_product
            // 
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FlatAppearance.BorderSize = 0;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_product.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(0, 345);
            this.btn_product.Name = "btn_product";
            this.btn_product.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_product.Size = new System.Drawing.Size(226, 55);
            this.btn_product.TabIndex = 16;
            this.btn_product.Text = "  庫存管理";
            this.btn_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // panel_basicSubMenu
            // 
            this.panel_basicSubMenu.AutoSize = true;
            this.panel_basicSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel_basicSubMenu.Controls.Add(this.sbtn_serviceManage);
            this.panel_basicSubMenu.Controls.Add(this.sbtn_providerAdd);
            this.panel_basicSubMenu.Controls.Add(this.sbtn_providerInfo);
            this.panel_basicSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_basicSubMenu.Location = new System.Drawing.Point(0, 195);
            this.panel_basicSubMenu.Name = "panel_basicSubMenu";
            this.panel_basicSubMenu.Size = new System.Drawing.Size(226, 150);
            this.panel_basicSubMenu.TabIndex = 3;
            // 
            // sbtn_serviceManage
            // 
            this.sbtn_serviceManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_serviceManage.FlatAppearance.BorderSize = 0;
            this.sbtn_serviceManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_serviceManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_serviceManage.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_serviceManage.Location = new System.Drawing.Point(0, 100);
            this.sbtn_serviceManage.Name = "sbtn_serviceManage";
            this.sbtn_serviceManage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_serviceManage.Size = new System.Drawing.Size(226, 50);
            this.sbtn_serviceManage.TabIndex = 1;
            this.sbtn_serviceManage.Text = "美髮服務項目";
            this.sbtn_serviceManage.UseVisualStyleBackColor = true;
            this.sbtn_serviceManage.Click += new System.EventHandler(this.sbtn_serviceManage_Click);
            // 
            // sbtn_providerAdd
            // 
            this.sbtn_providerAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_providerAdd.FlatAppearance.BorderSize = 0;
            this.sbtn_providerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_providerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_providerAdd.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_providerAdd.Location = new System.Drawing.Point(0, 50);
            this.sbtn_providerAdd.Name = "sbtn_providerAdd";
            this.sbtn_providerAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_providerAdd.Size = new System.Drawing.Size(226, 50);
            this.sbtn_providerAdd.TabIndex = 2;
            this.sbtn_providerAdd.Text = "新增廠商";
            this.sbtn_providerAdd.UseVisualStyleBackColor = true;
            this.sbtn_providerAdd.Click += new System.EventHandler(this.sbtn_providerAdd_Click);
            // 
            // sbtn_providerInfo
            // 
            this.sbtn_providerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtn_providerInfo.FlatAppearance.BorderSize = 0;
            this.sbtn_providerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtn_providerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtn_providerInfo.ForeColor = System.Drawing.Color.LightGray;
            this.sbtn_providerInfo.Location = new System.Drawing.Point(0, 0);
            this.sbtn_providerInfo.Name = "sbtn_providerInfo";
            this.sbtn_providerInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sbtn_providerInfo.Size = new System.Drawing.Size(226, 50);
            this.sbtn_providerInfo.TabIndex = 0;
            this.sbtn_providerInfo.Text = "廠商基本資料";
            this.sbtn_providerInfo.UseVisualStyleBackColor = true;
            this.sbtn_providerInfo.Click += new System.EventHandler(this.sbtn_providerInfo_Click);
            // 
            // btn_basic
            // 
            this.btn_basic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_basic.FlatAppearance.BorderSize = 0;
            this.btn_basic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_basic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_basic.Image = ((System.Drawing.Image)(resources.GetObject("btn_basic.Image")));
            this.btn_basic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_basic.Location = new System.Drawing.Point(0, 140);
            this.btn_basic.Name = "btn_basic";
            this.btn_basic.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_basic.Size = new System.Drawing.Size(226, 55);
            this.btn_basic.TabIndex = 2;
            this.btn_basic.Text = "  基本資料管理";
            this.btn_basic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_basic.UseVisualStyleBackColor = true;
            this.btn_basic.Click += new System.EventHandler(this.btn_dept_Click);
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
            this.pictureBox1.Image = global::HairSalonMS.Properties.Resources.fuck_logo;
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
            this.panel_bottom.Controls.Add(this.label_logOut);
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
            // label_logOut
            // 
            this.label_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_logOut.AutoSize = true;
            this.label_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_logOut.ForeColor = System.Drawing.Color.White;
            this.label_logOut.Location = new System.Drawing.Point(947, 9);
            this.label_logOut.Name = "label_logOut";
            this.label_logOut.Size = new System.Drawing.Size(82, 25);
            this.label_logOut.TabIndex = 0;
            this.label_logOut.Text = "F.U.C.K";
            this.label_logOut.Click += new System.EventHandler(this.label_logOut_Click);
            this.label_logOut.MouseLeave += new System.EventHandler(this.label_logOut_MouseLeave);
            this.label_logOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_logOut_MouseMove);
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
            this.Text = "Form_Main";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_bigMenu.ResumeLayout(false);
            this.panel_bigMenu.PerformLayout();
            this.panel_salarySubMenu.ResumeLayout(false);
            this.panel_businessSubMenu.ResumeLayout(false);
            this.panel_cusSubMenu.ResumeLayout(false);
            this.panel_empSubMenu.ResumeLayout(false);
            this.panel_productSubMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button sbtn_providerInfo;
        private System.Windows.Forms.Button sbtn_serviceManage;
        private System.Windows.Forms.Panel panel_salarySubMenu;
        private System.Windows.Forms.Button sbtn_salaryReport;
        private System.Windows.Forms.Button sbtn_salaryAssistantCal;
        private System.Windows.Forms.Button sbtn_salaryHairdresserCal;
        private System.Windows.Forms.Panel panel_businessSubMenu;
        private System.Windows.Forms.Button sbtn_business_other;
        private System.Windows.Forms.Button sbtn_business_income;
        private System.Windows.Forms.Panel panel_cusSubMenu;
        private System.Windows.Forms.Button sbtn_cusAdd;
        private System.Windows.Forms.Button sbtn_cusAnalyze;
        private System.Windows.Forms.Button sbtn_cusInfo;
        private System.Windows.Forms.Panel panel_empSubMenu;
        private System.Windows.Forms.Button sbtn_empAdd;
        private System.Windows.Forms.Button sbtn_empAchievement;
        private System.Windows.Forms.Button sbtn_empInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.Label label_logOut;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btn_basic;
        public System.Windows.Forms.Button btn_salary;
        public System.Windows.Forms.Button btn_business;
        public System.Windows.Forms.Button btn_customer;
        public System.Windows.Forms.Button btn_employee;
        public System.Windows.Forms.Button btn_personalInfo;
        public System.Windows.Forms.Button btn_systemManage;
        public System.Windows.Forms.Button btn_financialReport;
        private System.Windows.Forms.Button sbtn_product_manage;
        private System.Windows.Forms.Button sbtn_cusCardUse;
        private System.Windows.Forms.Button sbtn_cusCardSell;
        private System.Windows.Forms.Button sbtn_business_report;
        private System.Windows.Forms.Panel panel_productSubMenu;
        private System.Windows.Forms.Button sbtn_product_report;
        private System.Windows.Forms.Button sbtn_product_refund;
        private System.Windows.Forms.Button sbtn_product_in;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button sbtn_providerAdd;
    }
}
