using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DosyaIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKonumSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text=openFileDialog1.FileName;
        }

        private void BtnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }
        string belgeyolu, belgeadi;

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            belgeadi = TxtAd.Text;
            StreamWriter sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            MessageBox.Show("Belgeniz başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader oku= new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while(satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyası |*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin Belgesine kayıt yapıldı", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void kodolustur()
        {
            Random rst = new Random();
            int sayi = rst.Next(10000, 100000);
            TxtKod2.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAd.Text == "admin" && TxtSifre.Text == "1234" && TxtKod1.Text == TxtKod2.Text)
            {
                Form frm = new Form2
                {
                    kullanici = TxtKullaniciAd.Text
                };
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi:Kullanıcı adı, şifre veya kod yanlış girildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac %2 ==0)
            {
                label6.BackColor = Color.Pink;
            }
            else
            {
                label6.BackColor = Color.Gold;
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }

        private void BtnKonum_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                TxtYol.Text = belgeyolu;
            }
        }
    }
}
