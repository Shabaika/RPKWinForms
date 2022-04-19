using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Parameters p;
        public Form2()
        {
            InitializeComponent();
            p = new Parameters();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if (textBox1.Text == "" || !Double.TryParse(textBox1.Text, out double w) || w < 0) textBox1.BackColor = Color.Red;
            else
            {
                textBox1.BackColor = Color.White;
                p.W = w;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || !Double.TryParse(textBox2.Text, out double h) || h < 0) textBox2.BackColor = Color.Red;
            else
            {
                textBox2.BackColor = Color.White;
                p.H = h;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || !Double.TryParse(textBox3.Text, out double l) || l < 0) textBox3.BackColor = Color.Red;
            else
            {
                textBox3.BackColor = Color.White;
                p.L = l;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
