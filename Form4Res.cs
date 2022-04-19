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
    public partial class Form4Res : Form
    {
        internal Form4Res(Results r)
        {
            InitializeComponent();
            label1.Text = "Производительность = " + Math.Round(r.Q, 2).ToString() + " кг/ч";
            label2.Text = "Температура = " + Math.Round(r.TOut,2).ToString() + " С";
            label3.Text = "Вязкость = " + Math.Round(r.NOut,2).ToString() + " Па*с";

            for(int i=0; i<r.LOfCanal.Count; i++)
            {
                string[] row = { Math.Round(r.LOfCanal[i],2).ToString(), Math.Round(r.TInCanal[i], 2).ToString(), Math.Round(r.NInCanal[i], 2).ToString() };
                dataGridView1.Rows.Add(row);
                
            }
        }
    }
}
