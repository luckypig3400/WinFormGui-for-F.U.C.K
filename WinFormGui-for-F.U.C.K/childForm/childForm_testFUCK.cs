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
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

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
                themeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private static readonly HttpClient client = new HttpClient();
        // https://stackoverflow.com/questions/4015324/send-http-post-request-in-net

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string jsonString =
                @"{
                    ""profile"": ""dental"",
                    ""data"": [
                        {
                        ""doctor_id"": 69
                        },
                        {
                        ""doctor_id"": 168
                        }
                    ]
                }";

            var postData = new StringContent(jsonString, Encoding.UTF8, "application/json");
            // https://stackoverflow.com/questions/6117101/posting-jsonobject-with-httpclient-from-web-api

            try
            {
                var response = await client.PostAsync(url_textBox.Text, postData);
                var resString = await response.Content.ReadAsStringAsync();
                richTextBox1.Text = resString;
            }
            catch
            {
                MessageBox.Show("F.U.C.K服務沒有回應\n請檢查是否已正確啟動F.U.C.K",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
