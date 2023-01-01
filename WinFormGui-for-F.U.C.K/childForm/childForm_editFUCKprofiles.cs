using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFGF.U.C.K.childForm
{
    public partial class childForm_editFUCKprofiles : MaterialForm
    {
        public childForm_editFUCKprofiles()
        {
            InitializeComponent();

            // https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
        }

        MaterialSkinManager themeManager = MaterialSkinManager.Instance;

        private void enableDarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(enableDarkThemeSwitch.Checked)
                themeManager.Theme= MaterialSkinManager.Themes.DARK;
            else
                themeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void fileListComboBox_Click(object sender, EventArgs e)
        {
            fileListComboBox.Items.Clear(); // 每次點選清單，先清空上次讀取到的項目

            // 讀取F.U.C.K profile資料夾的檔案清單
            // https://stackoverflow.com/questions/36363675/getting-list-of-files-from-directory-into-combobox
            string[] files = Directory.GetFiles("./FHIR-Universal-Conversion-Kit/profile");
            fileListComboBox.Items.AddRange(files.Select((string filePath) => Path.GetFileName(filePath)).ToArray());
        }
    }
}
