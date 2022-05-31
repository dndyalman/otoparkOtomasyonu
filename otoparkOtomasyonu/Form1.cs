﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoparkOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkKaydı kayit = new frmAraçOtoparkKaydı();
            kayit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkYerleri yer = new frmAraçOtoparkYerleri();
            yer.ShowDialog();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            frmAraçOtoparkÇıkışı çıkış = new frmAraçOtoparkÇıkışı();
            çıkış.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmSatış satis = new frmSatış();
            satis.ShowDialog();
        }
    }
}
