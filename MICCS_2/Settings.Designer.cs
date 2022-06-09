namespace MICCS_2
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabp_Audio = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_Stimmenalter = new System.Windows.Forms.ComboBox();
            this.comb_geschlecht = new System.Windows.Forms.ComboBox();
            this.grb_Volume = new System.Windows.Forms.GroupBox();
            this.lb_volume = new System.Windows.Forms.Label();
            this.trab_Volume = new System.Windows.Forms.TrackBar();
            this.tabp_Daten = new System.Windows.Forms.TabPage();
            this.nud_alter = new System.Windows.Forms.NumericUpDown();
            this.nud_gmonat = new System.Windows.Forms.NumericUpDown();
            this.nud_gtag = new System.Windows.Forms.NumericUpDown();
            this.textb_EMail = new System.Windows.Forms.TextBox();
            this.textb_Name = new System.Windows.Forms.TextBox();
            this.textb_Prename = new System.Windows.Forms.TextBox();
            this.lb_alter = new System.Windows.Forms.Label();
            this.lb_gmonat = new System.Windows.Forms.Label();
            this.lb_gtag = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_Prename = new System.Windows.Forms.Label();
            this.btn_ubernehmen = new System.Windows.Forms.Button();
            this.btn_abbrechen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabp_Audio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_Volume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trab_Volume)).BeginInit();
            this.tabp_Daten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gmonat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gtag)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabp_Audio);
            this.tabControl1.Controls.Add(this.tabp_Daten);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabp_Audio
            // 
            this.tabp_Audio.Controls.Add(this.groupBox1);
            this.tabp_Audio.Controls.Add(this.grb_Volume);
            this.tabp_Audio.Location = new System.Drawing.Point(8, 39);
            this.tabp_Audio.Name = "tabp_Audio";
            this.tabp_Audio.Size = new System.Drawing.Size(625, 326);
            this.tabp_Audio.TabIndex = 1;
            this.tabp_Audio.Text = "Sprache & Audio";
            this.tabp_Audio.ToolTipText = "Einstellungen zur Sprachausgabe und Ton";
            this.tabp_Audio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comb_Stimmenalter);
            this.groupBox1.Controls.Add(this.comb_geschlecht);
            this.groupBox1.Location = new System.Drawing.Point(4, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stimme";
            // 
            // comb_Stimmenalter
            // 
            this.comb_Stimmenalter.Enabled = false;
            this.comb_Stimmenalter.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Stimmenalter.FormattingEnabled = true;
            this.comb_Stimmenalter.Location = new System.Drawing.Point(20, 90);
            this.comb_Stimmenalter.Name = "comb_Stimmenalter";
            this.comb_Stimmenalter.Size = new System.Drawing.Size(565, 42);
            this.comb_Stimmenalter.TabIndex = 3;
            this.comb_Stimmenalter.Text = " Erwachsener";
            // 
            // comb_geschlecht
            // 
            this.comb_geschlecht.Enabled = false;
            this.comb_geschlecht.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_geschlecht.FormattingEnabled = true;
            this.comb_geschlecht.Location = new System.Drawing.Point(20, 42);
            this.comb_geschlecht.Name = "comb_geschlecht";
            this.comb_geschlecht.Size = new System.Drawing.Size(565, 42);
            this.comb_geschlecht.TabIndex = 2;
            this.comb_geschlecht.Text = " Weibliche Stimme";
            // 
            // grb_Volume
            // 
            this.grb_Volume.Controls.Add(this.lb_volume);
            this.grb_Volume.Controls.Add(this.trab_Volume);
            this.grb_Volume.Location = new System.Drawing.Point(4, 3);
            this.grb_Volume.Name = "grb_Volume";
            this.grb_Volume.Size = new System.Drawing.Size(607, 126);
            this.grb_Volume.TabIndex = 1;
            this.grb_Volume.TabStop = false;
            this.grb_Volume.Text = "Lautstärke";
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.Font = new System.Drawing.Font("OCR A Extended", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_volume.Location = new System.Drawing.Point(513, 43);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(72, 45);
            this.lb_volume.TabIndex = 1;
            this.lb_volume.Text = "80";
            this.lb_volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trab_Volume
            // 
            this.trab_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trab_Volume.BackColor = System.Drawing.Color.White;
            this.trab_Volume.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trab_Volume.Location = new System.Drawing.Point(6, 30);
            this.trab_Volume.Maximum = 100;
            this.trab_Volume.Name = "trab_Volume";
            this.trab_Volume.Size = new System.Drawing.Size(513, 90);
            this.trab_Volume.TabIndex = 0;
            this.trab_Volume.Value = 80;
            this.trab_Volume.Scroll += new System.EventHandler(this.trab_Volume_Scroll);
            // 
            // tabp_Daten
            // 
            this.tabp_Daten.Controls.Add(this.nud_alter);
            this.tabp_Daten.Controls.Add(this.nud_gmonat);
            this.tabp_Daten.Controls.Add(this.nud_gtag);
            this.tabp_Daten.Controls.Add(this.textb_EMail);
            this.tabp_Daten.Controls.Add(this.textb_Name);
            this.tabp_Daten.Controls.Add(this.textb_Prename);
            this.tabp_Daten.Controls.Add(this.lb_alter);
            this.tabp_Daten.Controls.Add(this.lb_gmonat);
            this.tabp_Daten.Controls.Add(this.lb_gtag);
            this.tabp_Daten.Controls.Add(this.lb_email);
            this.tabp_Daten.Controls.Add(this.lb_name);
            this.tabp_Daten.Controls.Add(this.lb_Prename);
            this.tabp_Daten.Location = new System.Drawing.Point(8, 39);
            this.tabp_Daten.Name = "tabp_Daten";
            this.tabp_Daten.Size = new System.Drawing.Size(625, 326);
            this.tabp_Daten.TabIndex = 2;
            this.tabp_Daten.Text = "Deine Daten";
            this.tabp_Daten.ToolTipText = "Was MICCS über dich weiß";
            this.tabp_Daten.UseVisualStyleBackColor = true;
            // 
            // nud_alter
            // 
            this.nud_alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_alter.Location = new System.Drawing.Point(246, 273);
            this.nud_alter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_alter.Name = "nud_alter";
            this.nud_alter.Size = new System.Drawing.Size(362, 38);
            this.nud_alter.TabIndex = 18;
            this.nud_alter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_alter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_gmonat
            // 
            this.nud_gmonat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_gmonat.Location = new System.Drawing.Point(246, 224);
            this.nud_gmonat.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_gmonat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_gmonat.Name = "nud_gmonat";
            this.nud_gmonat.Size = new System.Drawing.Size(362, 38);
            this.nud_gmonat.TabIndex = 16;
            this.nud_gmonat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_gmonat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_gtag
            // 
            this.nud_gtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_gtag.Location = new System.Drawing.Point(246, 175);
            this.nud_gtag.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_gtag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_gtag.Name = "nud_gtag";
            this.nud_gtag.Size = new System.Drawing.Size(362, 38);
            this.nud_gtag.TabIndex = 15;
            this.nud_gtag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_gtag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textb_EMail
            // 
            this.textb_EMail.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_EMail.Location = new System.Drawing.Point(246, 122);
            this.textb_EMail.Name = "textb_EMail";
            this.textb_EMail.Size = new System.Drawing.Size(362, 40);
            this.textb_EMail.TabIndex = 14;
            this.textb_EMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textb_Name
            // 
            this.textb_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_Name.Location = new System.Drawing.Point(246, 72);
            this.textb_Name.Name = "textb_Name";
            this.textb_Name.Size = new System.Drawing.Size(362, 40);
            this.textb_Name.TabIndex = 13;
            this.textb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textb_Prename
            // 
            this.textb_Prename.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_Prename.Location = new System.Drawing.Point(246, 15);
            this.textb_Prename.Name = "textb_Prename";
            this.textb_Prename.Size = new System.Drawing.Size(362, 40);
            this.textb_Prename.TabIndex = 12;
            this.textb_Prename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_alter
            // 
            this.lb_alter.AutoSize = true;
            this.lb_alter.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alter.Location = new System.Drawing.Point(134, 273);
            this.lb_alter.Name = "lb_alter";
            this.lb_alter.Size = new System.Drawing.Size(91, 34);
            this.lb_alter.TabIndex = 11;
            this.lb_alter.Text = "Alter:";
            // 
            // lb_gmonat
            // 
            this.lb_gmonat.AutoSize = true;
            this.lb_gmonat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gmonat.Location = new System.Drawing.Point(4, 224);
            this.lb_gmonat.Name = "lb_gmonat";
            this.lb_gmonat.Size = new System.Drawing.Size(221, 34);
            this.lb_gmonat.TabIndex = 9;
            this.lb_gmonat.Text = "Geburtsmonat:";
            // 
            // lb_gtag
            // 
            this.lb_gtag.AutoSize = true;
            this.lb_gtag.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gtag.Location = new System.Drawing.Point(46, 175);
            this.lb_gtag.Name = "lb_gtag";
            this.lb_gtag.Size = new System.Drawing.Size(179, 34);
            this.lb_gtag.TabIndex = 8;
            this.lb_gtag.Text = "Geburtstag:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(120, 125);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(109, 34);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "E-Mail:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(60, 75);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(169, 34);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Nachname:";
            // 
            // lb_Prename
            // 
            this.lb_Prename.AutoSize = true;
            this.lb_Prename.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Prename.Location = new System.Drawing.Point(80, 18);
            this.lb_Prename.Name = "lb_Prename";
            this.lb_Prename.Size = new System.Drawing.Size(148, 34);
            this.lb_Prename.TabIndex = 0;
            this.lb_Prename.Text = "Vorname:";
            // 
            // btn_ubernehmen
            // 
            this.btn_ubernehmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ubernehmen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ubernehmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubernehmen.ForeColor = System.Drawing.Color.White;
            this.btn_ubernehmen.Location = new System.Drawing.Point(14, 379);
            this.btn_ubernehmen.Name = "btn_ubernehmen";
            this.btn_ubernehmen.Size = new System.Drawing.Size(293, 43);
            this.btn_ubernehmen.TabIndex = 1;
            this.btn_ubernehmen.Text = "ÜBERNEHMEN";
            this.btn_ubernehmen.UseVisualStyleBackColor = false;
            this.btn_ubernehmen.Click += new System.EventHandler(this.btn_ubernehmen_Click);
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.BackColor = System.Drawing.Color.Red;
            this.btn_abbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_abbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abbrechen.ForeColor = System.Drawing.Color.White;
            this.btn_abbrechen.Location = new System.Drawing.Point(333, 379);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(285, 43);
            this.btn_abbrechen.TabIndex = 2;
            this.btn_abbrechen.Text = "ABBRECHEN";
            this.btn_abbrechen.UseVisualStyleBackColor = false;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 434);
            this.Controls.Add(this.btn_abbrechen);
            this.Controls.Add(this.btn_ubernehmen);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICCS Einstelleungen";
            this.tabControl1.ResumeLayout(false);
            this.tabp_Audio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grb_Volume.ResumeLayout(false);
            this.grb_Volume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trab_Volume)).EndInit();
            this.tabp_Daten.ResumeLayout(false);
            this.tabp_Daten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gmonat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gtag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabp_Audio;
        private System.Windows.Forms.TrackBar trab_Volume;
        private System.Windows.Forms.TabPage tabp_Daten;
        private System.Windows.Forms.GroupBox grb_Volume;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_Prename;
        private System.Windows.Forms.Label lb_alter;
        private System.Windows.Forms.Label lb_gmonat;
        private System.Windows.Forms.Label lb_gtag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_Stimmenalter;
        private System.Windows.Forms.ComboBox comb_geschlecht;
        private System.Windows.Forms.TextBox textb_EMail;
        private System.Windows.Forms.TextBox textb_Name;
        private System.Windows.Forms.TextBox textb_Prename;
        private System.Windows.Forms.NumericUpDown nud_gtag;
        private System.Windows.Forms.NumericUpDown nud_alter;
        private System.Windows.Forms.NumericUpDown nud_gmonat;
        private System.Windows.Forms.Button btn_ubernehmen;
        private System.Windows.Forms.Button btn_abbrechen;
    }
}