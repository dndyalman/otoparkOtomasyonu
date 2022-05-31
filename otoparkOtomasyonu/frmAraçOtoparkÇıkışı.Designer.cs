namespace otoparkOtomasyonu
{
    partial class frmAraçOtoparkÇıkışı
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPlaka = new System.Windows.Forms.ComboBox();
            this.txtParkYeri = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.comboParkYeri = new System.Windows.Forms.ComboBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtParkYeri2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblSüre = new System.Windows.Forms.Label();
            this.lblÇıkışTarihi = new System.Windows.Forms.Label();
            this.lblGelişTarihi = new System.Windows.Forms.Label();
            this.labeltplm = new System.Windows.Forms.Label();
            this.labelsüre = new System.Windows.Forms.Label();
            this.labelçıkış = new System.Windows.Forms.Label();
            this.labelgelş = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboPlaka);
            this.groupBox1.Controls.Add(this.txtParkYeri);
            this.groupBox1.Location = new System.Drawing.Point(45, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Park Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Park Yeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaka Ara";
            // 
            // comboPlaka
            // 
            this.comboPlaka.FormattingEnabled = true;
            this.comboPlaka.Location = new System.Drawing.Point(89, 35);
            this.comboPlaka.Name = "comboPlaka";
            this.comboPlaka.Size = new System.Drawing.Size(121, 21);
            this.comboPlaka.TabIndex = 0;
            this.comboPlaka.SelectedIndexChanged += new System.EventHandler(this.comboPlaka_SelectedIndexChanged);
            // 
            // txtParkYeri
            // 
            this.txtParkYeri.Location = new System.Drawing.Point(89, 64);
            this.txtParkYeri.Name = "txtParkYeri";
            this.txtParkYeri.Size = new System.Drawing.Size(121, 20);
            this.txtParkYeri.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPlaka);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.comboParkYeri);
            this.groupBox2.Controls.Add(this.txtTC);
            this.groupBox2.Controls.Add(this.txtParkYeri2);
            this.groupBox2.Location = new System.Drawing.Point(45, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(288, 108);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(122, 20);
            this.txtPlaka.TabIndex = 12;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(288, 82);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(122, 20);
            this.txtSeri.TabIndex = 11;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(288, 55);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(122, 20);
            this.txtMarka.TabIndex = 10;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(288, 29);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(122, 20);
            this.txtSoyad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Seri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 111);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Plaka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Park Yeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Park Yeri";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(75, 107);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 20);
            this.txtAd.TabIndex = 5;
            // 
            // comboParkYeri
            // 
            this.comboParkYeri.FormattingEnabled = true;
            this.comboParkYeri.Location = new System.Drawing.Point(75, 28);
            this.comboParkYeri.Name = "comboParkYeri";
            this.comboParkYeri.Size = new System.Drawing.Size(121, 21);
            this.comboParkYeri.TabIndex = 1;
            this.comboParkYeri.SelectedIndexChanged += new System.EventHandler(this.comboParkYeri_SelectedIndexChanged);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(75, 81);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(121, 20);
            this.txtTC.TabIndex = 4;
            // 
            // txtParkYeri2
            // 
            this.txtParkYeri2.Location = new System.Drawing.Point(75, 55);
            this.txtParkYeri2.Name = "txtParkYeri2";
            this.txtParkYeri2.Size = new System.Drawing.Size(121, 20);
            this.txtParkYeri2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblSüre);
            this.groupBox3.Controls.Add(this.lblÇıkışTarihi);
            this.groupBox3.Controls.Add(this.lblGelişTarihi);
            this.groupBox3.Controls.Add(this.labeltplm);
            this.groupBox3.Controls.Add(this.labelsüre);
            this.groupBox3.Controls.Add(this.labelçıkış);
            this.groupBox3.Controls.Add(this.labelgelş);
            this.groupBox3.Location = new System.Drawing.Point(330, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 106);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ücretlendirme";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Aqua;
            this.lblToplamTutar.Location = new System.Drawing.Point(146, 76);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(41, 13);
            this.lblToplamTutar.TabIndex = 7;
            this.lblToplamTutar.Text = "label18";
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.ForeColor = System.Drawing.Color.Aqua;
            this.lblSüre.Location = new System.Drawing.Point(146, 59);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(41, 13);
            this.lblSüre.TabIndex = 6;
            this.lblSüre.Text = "label17";
            // 
            // lblÇıkışTarihi
            // 
            this.lblÇıkışTarihi.AutoSize = true;
            this.lblÇıkışTarihi.ForeColor = System.Drawing.Color.Aqua;
            this.lblÇıkışTarihi.Location = new System.Drawing.Point(146, 43);
            this.lblÇıkışTarihi.Name = "lblÇıkışTarihi";
            this.lblÇıkışTarihi.Size = new System.Drawing.Size(41, 13);
            this.lblÇıkışTarihi.TabIndex = 5;
            this.lblÇıkışTarihi.Text = "label16";
            // 
            // lblGelişTarihi
            // 
            this.lblGelişTarihi.AutoSize = true;
            this.lblGelişTarihi.ForeColor = System.Drawing.Color.Aqua;
            this.lblGelişTarihi.Location = new System.Drawing.Point(146, 25);
            this.lblGelişTarihi.Name = "lblGelişTarihi";
            this.lblGelişTarihi.Size = new System.Drawing.Size(41, 13);
            this.lblGelişTarihi.TabIndex = 4;
            this.lblGelişTarihi.Text = "label15";
            // 
            // labeltplm
            // 
            this.labeltplm.AutoSize = true;
            this.labeltplm.Location = new System.Drawing.Point(16, 76);
            this.labeltplm.Name = "labeltplm";
            this.labeltplm.Size = new System.Drawing.Size(70, 13);
            this.labeltplm.TabIndex = 3;
            this.labeltplm.Text = "Toplam Tutar";
            // 
            // labelsüre
            // 
            this.labelsüre.AutoSize = true;
            this.labelsüre.Location = new System.Drawing.Point(16, 59);
            this.labelsüre.Name = "labelsüre";
            this.labelsüre.Size = new System.Drawing.Size(29, 13);
            this.labelsüre.TabIndex = 2;
            this.labelsüre.Text = "Süre";
            // 
            // labelçıkış
            // 
            this.labelçıkış.AutoSize = true;
            this.labelçıkış.Location = new System.Drawing.Point(16, 42);
            this.labelçıkış.Name = "labelçıkış";
            this.labelçıkış.Size = new System.Drawing.Size(58, 13);
            this.labelçıkış.TabIndex = 1;
            this.labelçıkış.Text = "Çıkış Tarihi";
            // 
            // labelgelş
            // 
            this.labelgelş.AutoSize = true;
            this.labelgelş.Location = new System.Drawing.Point(16, 25);
            this.labelgelş.Name = "labelgelş";
            this.labelgelş.Size = new System.Drawing.Size(59, 13);
            this.labelgelş.TabIndex = 0;
            this.labelgelş.Text = "Geliş Tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Araç Çıkışı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(204, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Aqua;
            this.label12.Location = new System.Drawing.Point(204, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(204, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "TL";
            // 
            // frmAraçOtoparkÇıkışı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAraçOtoparkÇıkışı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Çıkışı";
            this.Load += new System.EventHandler(this.frmAraçOtoparkÇıkışı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPlaka;
        private System.Windows.Forms.TextBox txtParkYeri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtParkYeri2;
        private System.Windows.Forms.ComboBox comboParkYeri;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Label lblÇıkışTarihi;
        private System.Windows.Forms.Label lblGelişTarihi;
        private System.Windows.Forms.Label labeltplm;
        private System.Windows.Forms.Label labelsüre;
        private System.Windows.Forms.Label labelçıkış;
        private System.Windows.Forms.Label labelgelş;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}