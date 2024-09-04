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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chart1.Series["Bolge"].Points.AddXY("Akdeniz", 33);
            chart1.Series["Bolge"].Points.AddXY("Karadeniz", 53);
            chart1.Series["Bolge"].Points.AddXY("İç Anadolu", 42);
            chart1.Series["Bolge"].Points.AddXY("Doğu Anadolu", 23);
            chart1.Series["Bolge"].Points.AddXY("Marmara", 16);
            chart1.Series["Bolge"].Points.AddXY("Güneydoğu Anadolu", 17);
            chart1.Series["Bolge"].Points.AddXY("Ege", 45);

        }

        private void BtnArttir_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void BtnAzalt_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrgBarislem1.Value += 1;
            if(PrgBarislem1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void PrgBarislem2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PrgBarislem2.Value += 2;
            if (PrgBarislem2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PrgBarislem3.Value += 4;
            if (PrgBarislem3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("Tüm işlemler tamamlandı");
            }
        }
    }
}
