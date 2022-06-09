namespace MICCS_2
{
    partial class MICCS
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MICCS));
            this.trayIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_maincontex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_Ruhemodus = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_line1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_info = new System.Windows.Forms.ToolStripMenuItem();
            this.überEntwicklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zumProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_hilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_line2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_Aktualisierungen = new System.Windows.Forms.Timer(this.components);
            this.cms_maincontex.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIconMain
            // 
            this.trayIconMain.ContextMenuStrip = this.cms_maincontex;
            this.trayIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIconMain.Icon")));
            this.trayIconMain.Text = "MICCS";
            // 
            // cms_maincontex
            // 
            this.cms_maincontex.BackColor = System.Drawing.Color.White;
            this.cms_maincontex.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cms_maincontex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Ruhemodus,
            this.mi_line1,
            this.mi_info,
            this.mi_hilfe,
            this.mi_settings,
            this.mi_line2,
            this.mi_beenden});
            this.cms_maincontex.Name = "cms_maincontex";
            this.cms_maincontex.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cms_maincontex.Size = new System.Drawing.Size(301, 240);
            this.cms_maincontex.Text = "MICCS";
            // 
            // mi_Ruhemodus
            // 
            this.mi_Ruhemodus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mi_Ruhemodus.CheckOnClick = true;
            this.mi_Ruhemodus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mi_Ruhemodus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mi_Ruhemodus.Name = "mi_Ruhemodus";
            this.mi_Ruhemodus.Size = new System.Drawing.Size(300, 36);
            this.mi_Ruhemodus.Text = "Ruhemodus";
            this.mi_Ruhemodus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mi_Ruhemodus.ToolTipText = "Im Ruhemodus kann dich MICCS nicht hören";
            this.mi_Ruhemodus.CheckedChanged += new System.EventHandler(this.tcm_ruhemodus);
            // 
            // mi_line1
            // 
            this.mi_line1.Name = "mi_line1";
            this.mi_line1.Size = new System.Drawing.Size(297, 6);
            // 
            // mi_info
            // 
            this.mi_info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überEntwicklerToolStripMenuItem,
            this.zumProgrammToolStripMenuItem});
            this.mi_info.Name = "mi_info";
            this.mi_info.Size = new System.Drawing.Size(300, 36);
            this.mi_info.Text = "Info";
            // 
            // überEntwicklerToolStripMenuItem
            // 
            this.überEntwicklerToolStripMenuItem.Name = "überEntwicklerToolStripMenuItem";
            this.überEntwicklerToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.überEntwicklerToolStripMenuItem.Text = "Über Entwickler";
            this.überEntwicklerToolStripMenuItem.Click += new System.EventHandler(this.tcm_infoEntwickler);
            // 
            // zumProgrammToolStripMenuItem
            // 
            this.zumProgrammToolStripMenuItem.Name = "zumProgrammToolStripMenuItem";
            this.zumProgrammToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.zumProgrammToolStripMenuItem.Text = "Zum Programm";
            this.zumProgrammToolStripMenuItem.Click += new System.EventHandler(this.tcm_infoProgramm);
            // 
            // mi_hilfe
            // 
            this.mi_hilfe.Name = "mi_hilfe";
            this.mi_hilfe.Size = new System.Drawing.Size(300, 36);
            this.mi_hilfe.Text = "Hilfe und Befehle";
            this.mi_hilfe.Click += new System.EventHandler(this.tcm_hilfe);
            // 
            // mi_settings
            // 
            this.mi_settings.Name = "mi_settings";
            this.mi_settings.Size = new System.Drawing.Size(300, 36);
            this.mi_settings.Text = "Einstellungen";
            this.mi_settings.Click += new System.EventHandler(this.tcm_settings);
            // 
            // mi_line2
            // 
            this.mi_line2.Name = "mi_line2";
            this.mi_line2.Size = new System.Drawing.Size(297, 6);
            // 
            // mi_beenden
            // 
            this.mi_beenden.ForeColor = System.Drawing.Color.Red;
            this.mi_beenden.Name = "mi_beenden";
            this.mi_beenden.Size = new System.Drawing.Size(300, 36);
            this.mi_beenden.Text = "Beenden";
            this.mi_beenden.Click += new System.EventHandler(this.tcm_beenden);
            // 
            // tmr_Aktualisierungen
            // 
            this.tmr_Aktualisierungen.Interval = 1000;
            this.tmr_Aktualisierungen.Tick += new System.EventHandler(this.tmr_Aktualisierungen_Tick);
            // 
            // MICCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(237, 217);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MICCS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICCS";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.MICCS_Load);
            this.cms_maincontex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIconMain;
        private System.Windows.Forms.Timer tmr_Aktualisierungen;
        private System.Windows.Forms.ContextMenuStrip cms_maincontex;
        private System.Windows.Forms.ToolStripMenuItem mi_Ruhemodus;
        private System.Windows.Forms.ToolStripSeparator mi_line1;
        private System.Windows.Forms.ToolStripMenuItem mi_info;
        private System.Windows.Forms.ToolStripMenuItem mi_hilfe;
        private System.Windows.Forms.ToolStripMenuItem mi_settings;
        private System.Windows.Forms.ToolStripSeparator mi_line2;
        private System.Windows.Forms.ToolStripMenuItem mi_beenden;
        private System.Windows.Forms.ToolStripMenuItem überEntwicklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zumProgrammToolStripMenuItem;
    }
}

