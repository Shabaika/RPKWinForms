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
            Calculate.Calculation(p.W, p.H, p.L, p.Ro, p.C, p.T0, p.Su, p.Tu, p.M0, p.B, p.Tr, p.N, p.Au, p.Step, out Results res);
            Form4Res form4 = new Form4Res(res);
            form4.Show();
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
            if (textBox4.Text == "" || !Double.TryParse(textBox4.Text, out double ro) || ro < 0) textBox4.BackColor = Color.Red;
            else
            {
                textBox4.BackColor = Color.White;
                p.Ro = ro;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || !Double.TryParse(textBox5.Text, out double c) || c < 0) textBox5.BackColor = Color.Red;
            else
            {
                textBox5.BackColor = Color.White;
                p.C = c;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || !Double.TryParse(textBox6.Text, out double t0) || t0 < 0) textBox6.BackColor = Color.Red;
            else
            {
                textBox6.BackColor = Color.White;
                p.T0 = t0;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || !Double.TryParse(textBox7.Text, out double s) || s < 0) textBox7.BackColor = Color.Red;
            else
            {
                textBox7.BackColor = Color.White;
                p.Su = s;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || !Double.TryParse(textBox8.Text, out double tu) || tu < 0) textBox8.BackColor = Color.Red;
            else
            {
                textBox8.BackColor = Color.White;
                p.Tu = tu;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || !Double.TryParse(textBox9.Text, out double m0) || m0 < 0) textBox9.BackColor = Color.Red;
            else
            {
                textBox9.BackColor = Color.White;
                p.M0 = m0;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || !Double.TryParse(textBox10.Text, out double b) || b < 0) textBox10.BackColor = Color.Red;
            else
            {
                textBox10.BackColor = Color.White;
                p.B = b;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || !Double.TryParse(textBox11.Text, out double tr) || tr < 0) textBox11.BackColor = Color.Red;
            else
            {
                textBox11.BackColor = Color.White;
                p.Tr = tr;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "" || !Double.TryParse(textBox12.Text, out double n) || n < 0) textBox12.BackColor = Color.Red;
            else
            {
                textBox12.BackColor = Color.White;
                p.N = n;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "" || !Double.TryParse(textBox13.Text, out double au) || au < 0) textBox13.BackColor = Color.Red;
            else
            {
                textBox13.BackColor = Color.White;
                p.Au = au;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "" || !Double.TryParse(textBox14.Text, out double s) || s < 0) textBox14.BackColor = Color.Red;
            else
            {
                textBox14.BackColor = Color.White;
                p.Step = s;
            }
        }
    }
}
