using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFGF.U.C.K.childForm
{
    public partial class childForm_home : Form
    {
        public childForm_home()
        {
            InitializeComponent();
        }

        private void btn_readManual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("測試是否順利覆蓋舊版本的檔案");
            if(DialogResult.Yes == MessageBox.Show("教學手冊為線上HackMD文件，連結如下:\nhttps://hackmd.io/@LuckyPig/WinFormGui-for-FUCK_manual\n是否於瀏覽器中打開?",
                "打開使用手冊?", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {// https://stackoverflow.com/questions/14819426/how-to-create-hyperlink-in-messagebox-show
                System.Diagnostics.Process.Start("https://hackmd.io/@LuckyPig/WinFormGui-for-FUCK_manual");
            }
            
        }
    }
}
