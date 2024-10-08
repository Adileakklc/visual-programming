﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemelAracKullanimlari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(TxtSinav1.Text);
            s2 = Convert.ToInt16(TxtSinav2.Text);
            s3 = Convert.ToInt16(TxtSinav3.Text);
            ort=(s1 + s2 + s3)/3;
            TxtOrtalama.Text= ort.ToString();
            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "kaldı";
            }
            TxtDurum.Text = durum;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDurum.Text !=""&& TxtOrtalama.Text != "") { 
            string adsoyad, ders, numara;
            adsoyad=TxtAdSoyad.Text;
            ders=comboBox1.Text;
            numara=maskedTextBox1.Text;
            listBox1.Items.Add(adsoyad+ " "+ders+" Numara: "+numara+" Ortalama: "+TxtOrtalama.Text+" Durum: "+TxtDurum.Text);
                sayac++;
                label10.Text = "Kaydedilen öğrenci sayısı: " + sayac;
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durum hesabını yapınız!", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnCizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("--------------------------------------------------------------------------------");
        }
        int sayac=0;
        private void BtnSayac_Click(object sender, EventArgs e)
        {
            sayac++;
            label10.Text = sayac.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = "";
            TxtDurum.Clear();
            TxtOrtalama.Clear();
            TxtSinav1.Clear();
            TxtSinav2.Clear();
            TxtSinav3.Clear();
            maskedTextBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            TxtAdSoyad.Focus();
        }

        private void BtnMesajKutusu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İyi çalışmalar", "Mesaj Kutusu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void BtnForDongusu_Click(object sender, EventArgs e)
        {
            for(int i=1; i<=10; i++)
            {
                listBox2.Items.Add(i+"-Merhaba");
            }
        }

        private void BtnForDongusu2_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=20;i++)
            {
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);
                }
                
            }
        }

        private void BtnListboxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int x = 1;
            while (x<=10)
            {
                listBox2.Items.Add(x+"-While Döngüsü");
                x++;
            }
        }

        private void BtnDizi1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "adana", "bursa", "elazığ" };
            TxtAdSoyad.Text = sehirler[0];
        }

        private void BtnDizi2_Click(object sender, EventArgs e)
        {
            int [] sayilar = { 23, 01, 34, 16, 35 };
            for(int i=0;i< sayilar.Length; i++) {
                listBox2.Items.Add(sayilar[i]);
            }
            foreach(int k in sayilar)
            {
                if (k%4==0)
                {
                    listBox2.Items.Add(k);
                }
            }
        }
    }
}
