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
    public partial class childForm_ExcelReader : MaterialForm
    {
        public childForm_ExcelReader()
        {
            InitializeComponent();

            // https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
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
            string[] files = Directory.GetFiles("./FHIR-Universal-Conversion-Kit/twcore/excel-template-with10-sample-data");
            fileListComboBox.Items.AddRange(files.Select((string filePath) => Path.GetFileName(filePath)).ToArray());
        }

        private void fileListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory();
            filePath += "\\FHIR-Universal-Conversion-Kit\\twcore\\excel-template-with10-sample-data\\" + fileListComboBox.SelectedItem.ToString();
            currentFilePathOutput.Text= filePath;

            string fileContent = System.IO.File.ReadAllText(filePath);
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
        }

        private void loadFileDialogBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            // https://learn.microsoft.com/zh-tw/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-7.0
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "javascript files (*.js)|*.js|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\FHIR-Universal-Conversion-Kit\\profile\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                currentFilePathOutput.Text = filePath;

                string fileContent = System.IO.File.ReadAllText(filePath);
                // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
            }
        }
    }
}
