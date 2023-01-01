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

        private void fileListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = "./FHIR-Universal-Conversion-Kit/profile/" + fileListComboBox.SelectedItem.ToString();

            string fileContent = System.IO.File.ReadAllText(filePath);
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file

            fileEditorTextbox.Text = fileContent;
        }

        private void reloadFileWithoutSaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmDialog = MessageBox.Show("真的要在不存檔的情況下\n重新載入此文件嗎?",
                "Be Careful !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(confirmDialog == DialogResult.Yes)
            {
                string filePath = "./FHIR-Universal-Conversion-Kit/profile/";
                if (fileListComboBox.SelectedItem != null)
                {
                    filePath = "./FHIR-Universal-Conversion-Kit/profile/" + fileListComboBox.SelectedItem.ToString();

                    string fileContent = File.ReadAllText(filePath);
                    // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
                    fileEditorTextbox.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("您還沒有選取任何檔案喔!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFilelBtn_Click(object sender, EventArgs e)
        {
            string fileContent = fileEditorTextbox.Text;

            try
            {
                string filePath = "./FHIR-Universal-Conversion-Kit/profile/";
                if (fileListComboBox.SelectedItem != null)
                {
                    filePath = "./FHIR-Universal-Conversion-Kit/profile/" + fileListComboBox.SelectedItem.ToString();

                    File.WriteAllText(filePath, fileContent);
                    // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file

                    MessageBox.Show("檔案順利儲存!\n ヾ(≧▽≦*)o");
                }
                else
                {
                    MessageBox.Show("您還沒有選取任何檔案喔!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("檔案可能正被其他程式占用中或是檔案路徑有誤\n\n請檢查路徑是否存在及關閉可能正在使用該檔案的程式!",
                    "無法存檔!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            }
        }
    }
}
