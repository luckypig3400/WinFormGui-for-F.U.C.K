using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFGF.U.C.K.childForm
{
    public partial class childForm_testFUCK : Form
    {
        public childForm_testFUCK()
        {
            InitializeComponent();
        }

        private void btn_selectA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("根據URL輸入框，POST測試資料");
        }

    }
}
