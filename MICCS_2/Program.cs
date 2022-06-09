using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICCS_2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sValue = "";
            Microsoft.Win32.RegistryKey masterKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\mirzasoft\\MICCS\\UserData");
            if (null != masterKey)
            {
                sValue = (string)masterKey.GetValue("UserPrename");
                if (sValue == null)
                {
                    sValue = "tre";
                }
                masterKey.Close();
            }
            if (sValue == "tre")
            {
                Application.Run(new Installation());
            }
            else
            {
                Application.Run(new MICCS(false));
            }
        }



    }
}
