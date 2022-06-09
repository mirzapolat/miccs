using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace MICCS_2
{
    public partial class MICCS : Form
    {
        SpeechRecognitionEngine speechRecEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynther = new SpeechSynthesizer();

        // DATA
        string UserPrename = "";
        int UserAge = 0;
        int UserGTAG = 0;
        int UserGMONAT = 0;

        int SpeechVolume = 80;
        bool ruhemodus = false;

        // MAIN
        public MICCS(bool neu)
        {
            InitializeComponent();

            UserPrename = ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserPrename", "");
            UserAge = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserAge", "1"));
            UserGTAG = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGTag", "1"));
            UserGMONAT = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\UserData", "UserGMonat", "1"));
            SpeechVolume = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\ClientData", "SpeechVolume", "80"));

            speechSynther.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speechSynther.SetOutputToDefaultAudioDevice();
            speechSynther.Volume = SpeechVolume;

            if (neu == true)
            {
                string trexte = "Hallo " + UserPrename + ", ich bin Mix, dein ganz persönliches Computersteuerungsprogramm. Mit sprachbefehlen, kannst du mir sagen, was ich machen soll. Probiere es einfach mal aus. Viel Spaß und Erfolg!";
                say(trexte);
            }
            else
            {
                say("Hallo " + UserPrename + ". Wie kann ich helfen?");
            }

            // SPEECH RECOGNIZION
            Choices commands = new Choices();
            Vocabulaire(commands);

            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(commands);

            Grammar grammar = new Grammar(gbuilder);

            speechRecEngine.LoadGrammar(grammar);
            speechRecEngine.SetInputToDefaultAudioDevice();
            speechRecEngine.SpeechRecognized += recEngine_Recognized;
            speechRecEngine.RecognizeAsync(RecognizeMode.Multiple);

        }
        private void MICCS_Load(object sender, EventArgs e)
        {
            notifyIconFunction();
            tmr_Aktualisierungen.Enabled = true;
        }

        // VOKABELN
        void Vocabulaire(Choices comma)
        {
            comma.Add("hallo");
            comma.Add("tschüss");
            comma.Add("was kannst du");
            comma.Add("was bist du");
            comma.Add("wer bist du");
            comma.Add("was heißt mix");
            comma.Add("genaue uhrzeit");
            comma.Add("uhrzeit");
            comma.Add("datum");
            comma.Add("wochentag");
            comma.Add("wetter");
            comma.Add("temperatur");
            comma.Add("beenden");
            comma.Add("taschenrechner");
            comma.Add("editor");
            comma.Add("paint");
            comma.Add("media player");
            comma.Add("herunterfahren");
            comma.Add("neustarten");
            comma.Add("systemsteuerung");
            comma.Add("sage mir die genaue uhrzeit");
            comma.Add("wie spät ist es");
            comma.Add("wie viel uhr ist es");
            comma.Add("wie wird das wetter");
            comma.Add("wie viel grad ist es");
            comma.Add("öffne den taschenrechner");
            comma.Add("öffne den editor");
            comma.Add("öffne notepad");
            comma.Add("öffne paint");
            comma.Add("fahre den computer herunter");
            comma.Add("starte den computer neu");
            comma.Add("öffne die systemsteuerung");


        }

        // RECONGNIZION
        private void recEngine_Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            say(AntwortGeben(e.Result.Text));
        }

        // SPRECHEN
        private void say(string TextToSpeech)
        {
            speechSynther.SpeakAsync(TextToSpeech);
        }
        private void sayFreeze(string TextToSpeech)
        {
            speechSynther.Speak(TextToSpeech);
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

        // TRAYICON
        ContextMenu cMenu = new ContextMenu();

        private void tcm_ruhemodus(object sender, EventArgs e)
        {
            if (mi_Ruhemodus.Checked == true)
            {
                ruhemodus = true;
                say("Ruhemodus aktiviert");
            }
            else
            {
                ruhemodus = false;
                say("Ruhemodus deaktiviert");
            }
        }
        private void tcm_settings(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.Show();
        }
        private void tcm_infoProgramm(object sender, EventArgs e)
        {
            MessageBox.Show("Willkommen bei MICCS!\n\nMit MICCS kannst du deinen Alltag neu gestalten. Das lästige klicken hat nun ein Ende, denn MICCS funktioniert komplett mit deiner Stimme. Mit Sprachbefehlen kannst du MICCS sagen, was du tun willst!\n\n Viel SPASS und ERFOLG mit MICCS!", "Info über MICCS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tcm_infoEntwickler(object sender, EventArgs e)
        {
            MessageBox.Show("This Software is created by Mirza Polat.\n( C ) Copyright, 2018", "Info über Entwickler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tcm_hilfe(object sender, EventArgs e)
        {
            Funktionen frm = new Funktionen();
            frm.Show();
        }
        private void tcm_beenden(object sender, EventArgs e)
        {
            sayFreeze("Auf Wiedersehen!");
            Close();
        }
        
        private void trayIcon_Click(object sender, MouseEventArgs e)
        {
            // LEER
        }
        void trayBubble(string titleText, string mainText, ToolTipIcon tipIcon, int delayInMilliseconds)
        {
            NotifyIcon Message = new NotifyIcon();
            Message.ShowBalloonTip(delayInMilliseconds, titleText, mainText, tipIcon);
        }
        private void notifyIconFunction()
        {
            this.ShowInTaskbar = false;
            trayIconMain.Visible = true;

            trayIconMain.ShowBalloonTip(1000, "Willkommen zurück " + UserPrename + "!", "MICCS ist bereit ihre Befehle entgegenzunehmen...", ToolTipIcon.None);
            trayIconMain.MouseClick += new MouseEventHandler(trayIcon_Click);

            cMenu.MenuItems.Add("");
            cMenu.MenuItems.Add("-");
            cMenu.MenuItems.Add("Info");
            cMenu.MenuItems.Add("Hilfe und Befehle", new EventHandler(tcm_hilfe));
            cMenu.MenuItems.Add("Einstellungen", new EventHandler(tcm_settings));
            cMenu.MenuItems.Add("-");
            cMenu.MenuItems.Add("Beenden", new EventHandler(tcm_beenden));

            //trayIconMain.ContextMenu = cMenu;
        }
        
        // TIMER
        private void tmr_Aktualisierungen_Tick(object sender, EventArgs e)
        {
            SpeechVolume = Convert.ToInt32(ReadSetting("SOFTWARE\\mirzasoft\\MICCS\\ClientData", "SpeechVolume", "80"));
            speechSynther.Volume = SpeechVolume;
        }

        // ANTWORTEN
        string AntwortGeben(string EingabeText)
        {
            int zeit = DateTime.Now.Hour;
            string Rueckgabe = "";

            if (ruhemodus == false)
            {
                switch (EingabeText)
                {
                    case "ruhemodus aktivieren":
                        mi_Ruhemodus.Checked = true;
                        ruhemodus = true;
                        Rueckgabe = "Ruhemodus aktiviert du kannst";
                        break;
                    case "hallo":
                        Rueckgabe = "Hallo " + UserPrename + ". schön dich zu sehen!";
                        break;
                    case "tschüss":
                        say("willst du Mix wirklich beenden?");
                        DialogResult result = MessageBox.Show("Willst du MICCS wirklich beenden?", "Bis Bald!", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Close();
                        }
                        break;
                    case "was kannst du":
                        Rueckgabe = "Hier ist eine Liste von Befehlen, die du im aktuellen Modus verwenden kannst";
                        Funktionen frm_funkt = new Funktionen();
                        frm_funkt.Show();
                            break;
                    case "was bist du":
                    case "wer bist du":
                        Rueckgabe = "Ich bin Mix... Mix steht für Mirsa Intelligent Computer Control System";
                        break;
                    case "genaue uhrzeit":
                        Rueckgabe = "Es ist " + DateTime.Now.Hour.ToString() + " Uhr " + DateTime.Now.Minute.ToString() + " mit " + DateTime.Now.Second.ToString() + " Sekunden und " + DateTime.Now.Millisecond.ToString() + " Millisekunden.";
                        trayBubble("Uhrzeit", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString(), ToolTipIcon.None, 500);
                        break;
                    case "uhrzeit":
                        Rueckgabe = "Es ist " + DateTime.Now.Hour.ToString() + " Uhr " + DateTime.Now.Minute.ToString();
                        trayBubble("Uhrzeit", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Uhr", ToolTipIcon.None, 500);
                        break;
                    case "datum":
                        Rueckgabe = "Wir haben Heute den " + DateTime.Now.ToLongDateString();
                        break;
                    case "wochentag":
                        Rueckgabe = "Der aktuelle Wochentag ist " + DateTime.Now.DayOfWeek.ToString();
                        break;
                    case "wetter":
                        Rueckgabe = "Hier ist das Wetter";
                        System.Diagnostics.Process.Start("iexplore.exe", "https://www.google.de/#q=Wetter");
                        break;
                    case "beenden":
                        say("willst du Mix wirklich beenden?");
                        DialogResult resulte = MessageBox.Show("Willst du MICCS wirklich beenden?", "Bis Bald!", MessageBoxButtons.YesNo);
                        if (resulte == DialogResult.Yes)
                        {
                            Close();
                        }
                        break;
                    case "taschenrechner":
                        Rueckgabe = "Taschenrechner wird geöffnet";
                        System.Diagnostics.Process.Start("calc.exe");
                        break;
                    case "editor":
                        Rueckgabe = "Editor wird geöffnet";
                        System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\notepad.exe");
                        break;
                    case "paint":
                        Rueckgabe = "Paint wird geöffnet";
                        System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\mspaint.exe");
                        break;
                    case "media player":
                        Rueckgabe = "Windows Media Player wird geöffnet";
                        System.Diagnostics.Process.Start("C:\\Program Files\\Windows Media Player\\wmplayer.exe");
                        break;
                    case "herunterfahren":
                        say("Willst du den PC wirklich herunterfahren?");
                        DialogResult resultherunterfehren = MessageBox.Show("Willst du den PC wirklich herunterfehren lassen?\nACHTUNG! MICCS wird dabei auch beendet!", "Willst du das wirklich machen?", MessageBoxButtons.YesNo);
                        if (resultherunterfehren == DialogResult.Yes)
                        {
                            sayFreeze("Auf wiedersehen!");
                            System.Diagnostics.Process.Start("shutdown", "/s /t 5 /c \"MICSS fährt ihren Computer jetzt herunter...\"");
                        }
                        break;
                    case "neustarten":
                        say("Willst du den PC wirklich neustarten?");
                        DialogResult resultneustart = MessageBox.Show("Willst du den PC wirklich neu starten lassen?\nACHTUNG! MICCS wird dabei auch beendet!", "Willst du das wirklich machen?", MessageBoxButtons.YesNo);
                        if (resultneustart == DialogResult.Yes)
                        {
                            sayFreeze("Auf wiedersehen!");
                            System.Diagnostics.Process.Start("shutdown", "/r /t 5 /c \"MICSS startet ihren Computer jetzt neu...\"");
                        }
                        break;
                    case "systemsteuerung":
                        Rueckgabe = "Systemsteuerung wird geöffnet";
                        System.Diagnostics.Process.Start("control");
                        break;
                    case "":
                        break;
                }
            }
            

            return Rueckgabe;
        }
    }
}
