namespace MICCS_2
{
    partial class Funktionen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Diener = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_Diener
            // 
            this.listBox_Diener.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_Diener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Diener.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Diener.FormattingEnabled = true;
            this.listBox_Diener.HorizontalScrollbar = true;
            this.listBox_Diener.ItemHeight = 31;
            this.listBox_Diener.Items.AddRange(new object[] {
            "\"Uhrzeit\"",
            "--> Sagt die Uhrzeit mit Stunden und Minuten",
            "",
            "\"Genaue Uhrzeit\"",
            "--> Sagt die Uhrzeit mir Sekunden und Millisekunden",
            "",
            "\"Datum\"",
            "--> Zeigt das Datum an",
            "",
            "\"Wetter\"",
            "--> Zeig die Wettervorhersage",
            "",
            "\"Beenden\"",
            "--> Beendet das Programm",
            "",
            "\"Taschenrechner\"",
            "--> Öffnet den Taschenrechner",
            "",
            "\"Editor\"",
            "--> Öffnet den Editor ( Notepad )",
            "",
            "\"Paint\"",
            "--> Öffnet Paint",
            "",
            "\"Media Player\"",
            "--> Öffnet den Windows Media Player",
            "",
            "\"Herunterfahren\"",
            "--> Fährt den PC herunter",
            "",
            "\"Neustarten\"",
            "--> Startet den PC neu",
            "",
            "\"Systemsteuerung\"",
            "--> Öffnet die Systemsteuerung"});
            this.listBox_Diener.Location = new System.Drawing.Point(0, 0);
            this.listBox_Diener.Name = "listBox_Diener";
            this.listBox_Diener.Size = new System.Drawing.Size(1221, 741);
            this.listBox_Diener.TabIndex = 6;
            this.listBox_Diener.Visible = false;
            // 
            // Funktionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 741);
            this.Controls.Add(this.listBox_Diener);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Funktionen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Befehle";
            this.Load += new System.EventHandler(this.Funktionen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Diener;
    }
}