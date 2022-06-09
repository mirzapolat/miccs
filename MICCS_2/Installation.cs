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
    public partial class Installation : Form
    {
        public Installation()
        {
            InitializeComponent();
        }

        void WriteUserSetting(string path, string paramName, string paramValue)
        {
            Microsoft.Win32.RegistryKey masterKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path);
            if (null != masterKey)
            {
                masterKey.SetValue(paramName, paramValue);
                masterKey.Close();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_Vorname.Text != "" && nud_Tag.Text != "0" && nud_Monat.Text != "0" && nud_Alter.Text != "0")
            {
                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserName", tb_Name.Text);
                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserPrename", tb_Vorname.Text);
                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserEMail", tb_EMail.Text);
                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserAge", nud_Alter.Text);
                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGTag", nud_Tag.Text);
                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGMonat", nud_Monat.Text);

                WriteUserSetting("SOFTWARE\\mirzasoft\\MICCS\\ClientData", "SpeechVolume", "80");

                MICCS frm = new MICCS(true);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Manche Felder sind unvollständig ausgefüllt oder falsch angekreuzt.");
            }
        }

        private void cb_Erlaube_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Erlaube.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
