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
            MessageBox.Show("提供HackMD的連結", "Readme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
