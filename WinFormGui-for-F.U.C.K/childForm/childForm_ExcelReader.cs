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

using ExcelDataReader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            if (enableDarkThemeSwitch.Checked)
            {
                themeManager.Theme = MaterialSkinManager.Themes.DARK;

                dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
                dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 50, 50, 50);

                // https://stackoverflow.com/questions/1247800/how-to-change-the-color-of-winform-datagridview-header
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dataGridView1.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                themeManager.Theme = MaterialSkinManager.Themes.LIGHT;

                dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dataGridView1.RowHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            }
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
            currentFilePathOutput.Text = filePath;

            readExcel(filePath);
        }

        private void loadFileDialogBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            // https://learn.microsoft.com/zh-tw/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-7.0
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\FHIR-Universal-Conversion-Kit\\twcore\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                currentFilePathOutput.Text = filePath;

                readExcel(filePath);
            }
        }

        DataTableCollection tableCollection;
        private void sheetPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[sheetPickerComboBox.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void readExcel(string excel_path)
        {
            if (excel_path == "")
            {
                MessageBox.Show("請記得先從清單中選擇或是\n透過手動選擇要讀取的Excel檔案",
                    "小提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // 打開excel檔
                    // https://docs.google.com/document/d/1EFHZr48atBa0ZmJZqlWV_5V182bv80mB/edit#heading=h.ixbbze15oskq
                    var stream = System.IO.File.Open(excel_path,
                                                    System.IO.FileMode.Open,
                                                    System.IO.FileAccess.Read);

                    ExcelDataReader.IExcelDataReader reader =
                        ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    DataSet result = reader.AsDataSet(conf);
                    tableCollection = result.Tables;
                    sheetPickerComboBox.Items.Clear();
                    foreach (DataTable table in tableCollection)
                    {
                        sheetPickerComboBox.Items.Add(table.TableName);//add sheet to combobox}
                    }

                    MessageBox.Show("成功讀取該Excel檔案!\n請接著選擇要讀取的工作表(Sheet)",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("無法讀取該檔案!\n請確定該檔案為excel文件以及提供的路徑正確",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
