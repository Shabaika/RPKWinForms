using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Calculate
    {
        internal static void Calculation(double W, double H, double L, double ro, double c, double T0, double Vu, double Tu, double M0, double b, double Tr, double n, double Au, double step, out Results r)
        {
            Results r1 = new Results();
            double F = 0.125 * Math.Pow(H / W, 2) - 0.625 * H / W + 1;
            double Qc = H * W * Vu * F / 2;
            double Ydot = Vu / H;
            double qa = W * Au * (Math.Pow(b, -1) - Tu + Tr);
            double qy = H * W * M0 * Math.Pow(Ydot, n + 1);
            double T, nu;

            for (double i = 0; i < L; i += step)
            {
                r1.LOfCanal.Add(i);
                T = Tr + (1 / b) * Math.Log((b * qy + W * Au) / (b * qa) * (1 - Math.Exp(-b * qa * i / (ro * c * Qc))) + Math.Exp(b * (T0 - Tr - qa / (ro * c * Qc))));
                r1.TInCanal.Add(T);
                nu = M0 * Math.Exp(-b * (T - Tr)) * Math.Pow(Ydot, n - 1);
                r1.NInCanal.Add(nu);
            }

            r1.LOfCanal.Add(L);
            T = Tr + (1 / b) * Math.Log((b * qy + W * Au) / (b * qa) * (1 - Math.Exp(-b * qa * L / (ro * c * Qc))) + Math.Exp(b * (T0 - Tr - qa / (ro * c * Qc))));
            r1.TInCanal.Add(T);
            nu = M0 * Math.Exp(-b * (T - Tr)) * Math.Pow(Ydot, n - 1);
            r1.NInCanal.Add(nu);

            r1.Q = ro * Qc;
            r1.NOut = r1.NInCanal[r1.NInCanal.Count - 1];
            r1.TOut = r1.TInCanal[r1.TInCanal.Count - 1];
            r = r1;
        }
    }
}
