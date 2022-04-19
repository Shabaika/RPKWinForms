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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //add log/password
        {
            if (!CheckingLogAndPassword())
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
        }     

        private void button2_Click(object sender, EventArgs e) //change log/password
        {
            if (!CheckingLogAndPassword())
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
        }

        bool CheckingLogAndPassword()
        {
            if (textBox1.Text == "") textBox1.BackColor = Color.Red;
            if (textBox2.Text == "") textBox2.BackColor = Color.Red;
            if (textBox1.Text == "" || textBox2.Text == "") return false;
            return true;
        }
    }
}
