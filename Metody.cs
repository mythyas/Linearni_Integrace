using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerickaIntegrace
{
    class Metody
    {
        public static double SimpsonovaMetoda(double a, double b, int m, Form1.FunkceDelegate F)
        {
            double S = 0;
            double h = (b - a) / (2 * m);
            S += F(a);
            for (int i = 1; i <= m; i++)
            {
                S += 4 * F(a + h * (2 * i - 1));
                S += 2 * F(a + h * (2 * i));
            }
            S -= F(b);
            return S * (h / 3);
        }
        public static double LichobeznikovaMetoda(double a, double b, int n, Form1.FunkceDelegate F)
        {
            double S = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                S += ((a + (i + 1) * h) /*Xk+1*/ - (a + i * h) /*Xk*/) * (F(a + i * h) /*Xk*/ + F(a + (i + 1) * h) /*Xk+1*/) / 2;
            }
            return S;
        }
    }
}
