using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Results
    {
        internal List<double> LOfCanal { get; set; }
        internal List<double> TInCanal { get; set; }
        internal List<double> NInCanal { get; set; }
        internal double Q { get; set; }
        internal double TOut { get; set; }
        internal double NOut { get; set; }

        internal Results()
        {
            LOfCanal = new List<double>();
            TInCanal = new List<double>();
            NInCanal = new List<double>();
        }
    }
}
