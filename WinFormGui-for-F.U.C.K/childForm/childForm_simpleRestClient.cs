using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class childForm_simpleRestClient : MaterialForm
    {
        public childForm_simpleRestClient()
        {
            InitializeComponent();

            // https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        MaterialSkinManager themeManager = MaterialSkinManager.Instance;

        private void enableDarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(enableDarkThemeSwitch.Checked)
                themeManager.Theme= MaterialSkinManager.Themes.DARK;
            else
                themeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}
