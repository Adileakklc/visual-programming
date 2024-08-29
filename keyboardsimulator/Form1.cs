using System;
using System.Windows.Forms;

namespace odev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Butonlar için Click olaylarýný ekle
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Basýlan tuþun adýný alýyoruz
            string keyPressed = e.KeyCode.ToString();

            // Panel içindeki tüm butonlarý döngüyle geziyoruz
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    // Eðer butonun adý basýlan tuþa eþitse, butona odaklan
                    if (button.Name == keyPressed)
                    {
                        button.Focus();
                        button.PerformClick();
                        break;
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"{clickedButton.Text} tuþuna bastýnýz.");
        }
    }
}
