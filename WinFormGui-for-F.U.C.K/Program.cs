﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SHRMS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // high dpi start
            if(Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            // high dpi end
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
        // high dpi start
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();
        // high dpi end
    }
}
