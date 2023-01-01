using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGuiForF.U.C.K.childForm
{
    public partial class childForm_csv2json : Form
    {
        public childForm_csv2json()
        {
            InitializeComponent();
        }

        private void childForm_csv2json_Load(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/7194851/load-local-html-file-in-a-c-sharp-webbrowser
            string csv2jsonFilePath = Directory.GetCurrentDirectory() +
                "\\FHIR-Universal-Conversion-Kit\\csv2json_HTML_ver\\csv2json.html";

            this.webBrowser1.Url = new Uri("file://" + csv2jsonFilePath);
        }
    }
}
