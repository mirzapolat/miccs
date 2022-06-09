namespace MICCS_2
{
    partial class Installation
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_Monat = new System.Windows.Forms.NumericUpDown();
            this.nud_Tag = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Erlaube = new System.Windows.Forms.CheckBox();
            this.tb_EMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Alter = new System.Windows.Forms.NumericUpDown();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Monat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alter)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(365, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Monat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tag";
            // 
            // nud_Monat
            // 
            this.nud_Monat.Location = new System.Drawing.Point(352, 187);
            this.nud_Monat.Margin = new System.Windows.Forms.Padding(6);
            this.nud_Monat.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_Monat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Monat.Name = "nud_Monat";
            this.nud_Monat.Size = new System.Drawing.Size(98, 31);
            this.nud_Monat.TabIndex = 13;
            this.nud_Monat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Monat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_Tag
            // 
            this.nud_Tag.Location = new System.Drawing.Point(144, 187);
            this.nud_Tag.Margin = new System.Windows.Forms.Padding(6);
            this.nud_Tag.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_Tag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Tag.Name = "nud_Tag";
            this.nud_Tag.Size = new System.Drawing.Size(110, 31);
            this.nud_Tag.TabIndex = 12;
            this.nud_Tag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Tag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Geburtstag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-Mail:";
            // 
            // cb_Erlaube
            // 
            this.cb_Erlaube.AutoSize = true;
            this.cb_Erlaube.Location = new System.Drawing.Point(379, 326);
            this.cb_Erlaube.Margin = new System.Windows.Forms.Padding(6);
            this.cb_Erlaube.Name = "cb_Erlaube";
            this.cb_Erlaube.Size = new System.Drawing.Size(534, 79);
            this.cb_Erlaube.TabIndex = 9;
            this.cb_Erlaube.Text = "Ich erlaube MICSS jede Art von Zugriff auf meinen \r\nComuter und die Verwaltung me" +
    "iner gespeicherten \r\nDateien.";
            this.cb_Erlaube.UseVisualStyleBackColor = true;
            this.cb_Erlaube.CheckedChanged += new System.EventHandler(this.cb_Erlaube_CheckedChanged);
            // 
            // tb_EMail
            // 
            this.tb_EMail.Location = new System.Drawing.Point(144, 137);
            this.tb_EMail.Margin = new System.Windows.Forms.Padding(6);
            this.tb_EMail.MaxLength = 24;
            this.tb_EMail.Name = "tb_EMail";
            this.tb_EMail.Size = new System.Drawing.Size(398, 31);
            this.tb_EMail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vorname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // nud_Alter
            // 
            this.nud_Alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Alter.Location = new System.Drawing.Point(144, 237);
            this.nud_Alter.Margin = new System.Windows.Forms.Padding(6);
            this.nud_Alter.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nud_Alter.Name = "nud_Alter";
            this.nud_Alter.Size = new System.Drawing.Size(402, 37);
            this.nud_Alter.TabIndex = 3;
            this.nud_Alter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Alter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(144, 85);
            this.tb_Vorname.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Vorname.MaxLength = 15;
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(398, 31);
            this.tb_Vorname.TabIndex = 1;
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(665, 420);
            this.btn_Abbrechen.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(272, 44);
            this.btn_Abbrechen.TabIndex = 11;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nud_Monat);
            this.groupBox1.Controls.Add(this.nud_Tag);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_EMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_Alter);
            this.groupBox1.Controls.Add(this.tb_Vorname);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Location = new System.Drawing.Point(365, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(572, 292);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alter:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(144, 35);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Name.MaxLength = 15;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(398, 31);
            this.tb_Name.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MICCS_2.Properties.Resources.MICCS;
            this.pictureBox1.Location = new System.Drawing.Point(33, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Installation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Erlaube);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Installation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICCS Installation";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Monat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_Monat;
        private System.Windows.Forms.NumericUpDown nud_Tag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_Erlaube;
        private System.Windows.Forms.TextBox tb_EMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Alter;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}