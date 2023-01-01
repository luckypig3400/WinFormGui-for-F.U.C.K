using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using WFGF.U.C.K.childForm;
using System.Diagnostics;

namespace WFGF.U.C.K
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            panel_initialize();
            timer_time.Start();
            childForm_home frm = new childForm_home();
            openChildForm(frm);

        }

        private void panel_initialize()
        {
            panel_businessSubMenu.Visible = false;
            panel_basicSubMenu.Visible = false;
            panel_ExcelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_businessSubMenu.Visible == true)
                panel_businessSubMenu.Visible = false;
            if (panel_basicSubMenu.Visible == true)
                panel_basicSubMenu.Visible = false;
            if (panel_ExcelSubMenu.Visible == true)
                panel_ExcelSubMenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        Button btn_temp = new Button();
        Button btn_temp_sub = new Button();

        private void selectedBackground(Button selectedButton)
        {
            btn_temp_sub.BackColor = Color.FromArgb(57, 62, 70);
            btn_temp.BackColor = Color.FromArgb(42, 54, 59);
            btn_temp = selectedButton;
            btn_temp.BackColor = Color.FromArgb(0, 120, 215);
        }
        private void selectedBackground_sub(Button selectedButton)
        {
            btn_temp.BackColor = Color.FromArgb(42, 54, 59);
            btn_temp_sub.BackColor = Color.FromArgb(57, 62, 70);
            btn_temp_sub = selectedButton;
            btn_temp_sub.BackColor = Color.FromArgb(0, 120, 215);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
           
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            kill_FUCK_servirce(); // 離開APP前關閉F.U.C.K
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void openChildForm(Form childForm)
        {
            foreach (Control item in this.panel_childForm.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            childForm.TopLevel = false;
            //panel_childForm.Controls.Add(childForm);
            //childForm.MdiParent = this;
            childForm.Parent = this.panel_childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_home);
            hideSubMenu();
            childForm_home frm = new childForm_home();
            openChildForm(frm);
        }

        private void btn_serviceFUCKoptions_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_serviceFUCKoptions);
            showSubMenu(panel_basicSubMenu);
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_business);
            showSubMenu(panel_businessSubMenu);
        }

        private void btn_FUCKprofileEditor_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_FUCKprofileEditor);
            childForm_editFUCKprofiles frm = new childForm_editFUCKprofiles();
            openChildForm(frm); 
        }

        private void btn_systemManage_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_csv2json);
            hideSubMenu();
            childForm_systemManage frm = new childForm_systemManage();
            openChildForm(frm);
        }

        // https://stackoverflow.com/questions/1271938/how-to-run-batch-file-from-c-sharp-in-the-background            
        Process FUCKprocess = new Process();
        ProcessStartInfo fuckStartInfo = new ProcessStartInfo();

        private void sbtn_FUCK_launch_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/1469764/run-command-prompt-commands
            fuckStartInfo.WindowStyle = ProcessWindowStyle.Hidden; //隱藏cmd視窗
            fuckStartInfo.FileName = "cmd.exe";
            fuckStartInfo.Arguments = "/C cd FHIR-Universal-Conversion-Kit/src && npm install && node app.js";
            FUCKprocess.StartInfo = fuckStartInfo;

            // check if FUCKprocess already started
            try
            {// 服務尚未啟動，抓不到Process ID 所以會Error
                if (FUCKprocess.Id != 0)
                {
                    MessageBox.Show("服務已經在運行中...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("首次啟動:依電腦性能不同，大約\n需等待10~30秒安裝相依套件\n\n日後啟動:約3秒完成\n\n建議使用下方選項測試是否順利啟動!",
                "服務啟動通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FUCKprocess.Start();
            }
        }

        private void sbtn_FUCK_test_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_FUCK_test);
            childForm_testFUCK frm = new childForm_testFUCK();
            openChildForm(frm);
        }

        private void sbtn_FUCK_restart_Click(object sender, EventArgs e)
        {
            kill_FUCK_servirce();

            // https://stackoverflow.com/questions/1469764/run-command-prompt-commands
            fuckStartInfo.WindowStyle = ProcessWindowStyle.Hidden; //隱藏cmd視窗
            fuckStartInfo.FileName = "cmd.exe";
            fuckStartInfo.Arguments = "/C cd FHIR-Universal-Conversion-Kit/src && npm install && node app.js";
            FUCKprocess.StartInfo = fuckStartInfo;
            FUCKprocess.Start();

            MessageBox.Show("成功停止F.U.C.K服務 !\n\n請稍候3~5秒再進行測試", "服務正在重啟中...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void kill_FUCK_servirce()
        {
            try
            {
                FUCKprocess.Kill();// 關閉cmd視窗
                foreach (var node in Process.GetProcessesByName("node"))
                {
                    // 找出所有在背景執行的node.js並關閉，雖然會關到其他服務使用的node.js但這是最簡單的辦法
                    // https://stackoverflow.com/questions/51302514/stop-command-line-process-started-in-c-sharp-on-close-of-application
                    node.Kill();

                    // 另外可參考比較複雜的註冊child process並關閉的方法
                    // https://stackoverflow.com/questions/3342941/kill-child-process-when-parent-process-is-killed
                }
            }
            catch {
                MessageBox.Show("F.U.C.K已終止或尚未啟動!", "溫馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sbtn_cusInfo_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_cusInfo);
            childForm_templateUpSearchBottomResult frm = new childForm_templateUpSearchBottomResult();
            openChildForm(frm);
        }

        private void sbtn_business_income_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_business_income);
            childForm_templateLeftSearchRightResult frm = new childForm_templateLeftSearchRightResult();
            openChildForm(frm);
        }

        private void sbtn_business_other_Click(object sender, EventArgs e)
        {
            selectedBackground_sub(sbtn_business_other);
            childForm_templateRightSearchLeftResult frm = new childForm_templateRightSearchLeftResult();
            openChildForm(frm);
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = System.DateTime.Now.ToLocalTime();
            label_time.Text = nowTime.ToString();
        }

        private void label_logOut_Click(object sender, EventArgs e)
        {
            // Form_sign frm_sign = new Form_sign();
            // frm_sign.Show();//不能用ShowDialog()

            // 原本模板有登入介面，刪除後改為直接離開此程式
            kill_FUCK_servirce(); // 離開APP前關閉F.U.C.K
            this.Close();
            this.Dispose();
        }

        private void label_logOut_MouseMove(object sender, MouseEventArgs e)
        {
            label_logOut.ForeColor = Color.Red;
        }

        private void label_logOut_MouseLeave(object sender, EventArgs e)
        {
            label_logOut.ForeColor = Color.White;
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_close.BackColor = Color.FromArgb(255, 22, 93);
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void sbtn_killNodeJS_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            DialogResult confirmResult = MessageBox.Show("若您的F.U.C.K服務一直無法通過測試\n可以嘗試停止電腦中所有Node.exe\n\n確定要停止所有Node.js服務?",
                "注意!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (var node in Process.GetProcessesByName("node"))
                {
                    // 找出所有在背景執行的node.js並關閉，雖然會關到其他服務使用的node.js但這是最簡單的辦法
                    // https://stackoverflow.com/questions/51302514/stop-command-line-process-started-in-c-sharp-on-close-of-application
                    node.Kill();
                }

                MessageBox.Show("成功停止所有Node.js服務\n您可以啟動F.U.C.K服務再行測試\n\n若問題仍未解決您可以考慮尋找電腦中\n占用 1337 port的程式並暫時將其停止!",
                    "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // do nothing
            }
        }

        private void btn_simpleRestCleint_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_simpleRestCleint);
            childForm_simpleRestClient frm = new childForm_simpleRestClient();
            openChildForm(frm);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            selectedBackground(btn_Excel);
            showSubMenu(panel_ExcelSubMenu);
        }
    }
}
