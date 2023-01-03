using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

        public void reloadTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);

            if (enableDarkThemeSwitch.Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        MaterialSkinManager themeManager = MaterialSkinManager.Instance;

        private void enableDarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(enableDarkThemeSwitch.Checked)
                themeManager.Theme= MaterialSkinManager.Themes.DARK;
            else
                themeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public static readonly HttpClient client = new HttpClient();
        // https://stackoverflow.com/questions/4015324/send-http-post-request-in-net

        private async void sendRequestBtn_Click(object sender, EventArgs e)
        {
            responseOutputTextBox.Text = "Waiting for server response...";
            if ("POST" == requestMethod.SelectedItem.ToString())
            {
                string jsonString = jsonInputTextbox.Text;
                var postData = new StringContent(jsonString, Encoding.UTF8, "application/json");
                // https://stackoverflow.com/questions/6117101/posting-jsonobject-with-httpclient-from-web-api

                try
                {
                    var response = await client.PostAsync(requestURL.Text, postData);
                    var resString = await response.Content.ReadAsStringAsync();
                    responseOutputTextBox.Text = resString;
                }
                catch
                {
                    MessageBox.Show("F.U.C.K服務沒有回應\n請檢查是否已正確啟動F.U.C.K\n或是URL是否填寫正確",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    responseOutputTextBox.Text = "";
                }
            }
            else if("GET" == requestMethod.SelectedItem.ToString())
            {
                try
                {
                    // https://stackoverflow.com/questions/4015324/send-http-post-request-in-net
                    var responseString = await client.GetStringAsync(requestURL.Text);
                    responseOutputTextBox.Text = responseString;
                }
                catch(Exception getError)
                {
                    MessageBox.Show(getError.ToString(), "GET Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    responseOutputTextBox.Text = "";
                }
            }
        }

        private void loadExampleJSONBtn_Click(object sender, EventArgs e)
        {
            string exampleJsonString =
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

            jsonInputTextbox.Text = exampleJsonString;
        }

        private void childForm_simpleRestClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalData.restClientFormHasBeenOpened = false;
        }
    }
}
