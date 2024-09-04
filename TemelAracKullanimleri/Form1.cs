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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label6.Text = "İstanbul";
            label6.Text = comboBox1.Text;
            //label8.Text = textBox1.Text;
            textBox1.Text = "Python";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("R");
            listBox1.Items.Add("Flutter");
            comboBox1.Items.Add("Trabzon");
            listBox1.Items.Add(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
