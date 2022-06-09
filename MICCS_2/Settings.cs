using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICCS_2
{
    public partial class Settings : Form
    {
        string UserPrename = "";
        string UserName = "";
        string UserEMail = "";
        int UserAge = 0;
        int UserGTAG = 0;
        int UserGMONAT = 0;

        public Settings()
        {
            InitializeComponent();

            UserPrename = ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserPrename", "- Fehler aufgetreten -");
            UserName = ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserName", "- Fehler aufgetreten -");
            UserEMail = ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserEMail", "- Fehler aufgetreten -");
            UserAge = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserAge", "0"));
            UserGTAG = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGTag", "0"));
            UserGMONAT = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGMonat", "0"));

            trab_Volume.Value = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\ClientData", "SpeechVolume", "80"));
            lb_volume.Text = trab_Volume.Value.ToString();

            textb_Prename.Text = UserPrename;
            textb_Name.Text = UserName;
            textb_EMail.Text = UserEMail;
            nud_alter.Value = UserAge;
            nud_gmonat.Value = UserGMONAT;
            nud_gtag.Value = UserGTAG;
        }

        private void trab_Volume_Scroll(object sender, EventArgs e)
        {
            lb_volume.Text = trab_Volume.Value.ToString();
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\ClientData", "SpeechVolume", trab_Volume.Value.ToString());
        }

        // REGISTRY
        void WriteSetting(string path, string paramName, string paramValue)
        {
            Microsoft.Win32.RegistryKey masterKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path);
            if (null != masterKey)
            {
                masterKey.SetValue(paramName, paramValue);
                masterKey.Close();
            }

        }
        string ReadSetting(string path, string paramName, string DefaultValue)
        {
            string sValue = null;

            sValue = "";
            Microsoft.Win32.RegistryKey masterKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path);
            if (null != masterKey)
            {
                sValue = (string)masterKey.GetValue(paramName);
                if (sValue == null)
                {
                    sValue = "";
                    //masterKey.SetValue(paramName, sValue);
                }
                masterKey.Close();
            }

            return sValue;
        }

        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ubernehmen_Click(object sender, EventArgs e)
        {
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserName", textb_Name.Text);
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserPrename", textb_Prename.Text);
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserEMail", textb_EMail.Text);
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserAge", nud_alter.Value.ToString());
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGTag", nud_gtag.Value.ToString());
            WriteSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGMonat", nud_gmonat.Value.ToString());
        }
    }
}
