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
            // Butonlar i�in Click olaylar�n� ekle
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
            // Bas�lan tu�un ad�n� al�yoruz
            string keyPressed = e.KeyCode.ToString();

            // Panel i�indeki t�m butonlar� d�ng�yle geziyoruz
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    // E�er butonun ad� bas�lan tu�a e�itse, butona odaklan
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
            MessageBox.Show($"{clickedButton.Text} tu�una bast�n�z.");
        }
    }
}
