using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFGF.U.C.K
{
    class GlobalData
    {
        public static string username = string.Empty;
        public static string connectionStr = "server=127.0.0.1;user=hairsalonDBadmin;database=csharp_hair_salon_ms;port=3306;password=hairsalonDBadmin;";
        
        public static bool restClientFormHasBeenOpened = false;
    }
}
