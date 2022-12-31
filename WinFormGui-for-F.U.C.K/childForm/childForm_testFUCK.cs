using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace WFGF.U.C.K.childForm
{
    // https://youtu.be/lvL4bDZccJU
    public partial class childForm_testFUCK : MaterialForm
    {
        public childForm_testFUCK()
        {
            InitializeComponent();

            // https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        MaterialSkinManager themeManager = MaterialSkinManager.Instance;

        private void enableDarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (enableDarkThemeSwitch.Checked)
                themeManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                themeManager.Theme= MaterialSkinManager.Themes.LIGHT;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(url_textBox.Text, "根據URL輸入框，POST測試資料");
        }
    }
}
