using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void yazdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Yazdırma Komutları menü alanına tıklandı";
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Red;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba hakkımızda kısmına hoşgeldin","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        
        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        int sure;
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;
            if(sure >=0 && sure <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
                
            }
            if(sure >30 && sure <=40)
            {
                panel2.BackColor = Color.Yellow;
            }
            if(sure >40 && sure <=70)
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;

            }
            if (sure ==71)
            {
                sure= 0;
            }
        }
    }
}
