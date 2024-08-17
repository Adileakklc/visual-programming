using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            this.Text = "Vize Sınavı";

            // Sürükle Butonu Oluştur
            Button btnSurukle = new Button();
            btnSurukle.Text = "Sürükle";
            btnSurukle.Bounds = new Rectangle(50, 50, 100, 100);
            btnSurukle.MouseDown += BtnSurukle_MouseDown;
            btnSurukle.MouseMove += BtnSurukle_MouseMove;
            btnSurukle.MouseUp += BtnSurukle_MouseUp;
            this.Controls.Add(btnSurukle);

            // Başla Butonu Oluştur
            Button btnBasla = new Button();
            btnBasla.Text = "Başla";
            btnBasla.Size = new Size(150, 100);
            btnBasla.Location = new Point(50, 200);
            btnBasla.BackColor = Color.Red;
            btnBasla.Click += BtnBasla_Click;
            this.Controls.Add(btnBasla);

            // Bitir Butonu Oluştur
            Button btnBitir = new Button();
            btnBitir.Text = "Bitir";
            btnBitir.Size = new Size(150, 100);
            btnBitir.Location = new Point(210, 200); // Arada boşluk bırakmak için x koordinatını artırdım
            btnBitir.BackColor = Color.Blue;
            btnBitir.Click += BtnBitir_Click;
            this.Controls.Add(btnBitir);
        }

        private void BtnSurukle_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = e.Location;
        }

        private void BtnSurukle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    btn.Left += e.X - startPoint.X;
                    btn.Top += e.Y - startPoint.Y;
                }
            }
        }

        private void BtnSurukle_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başla mesajı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bitti mesajı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
