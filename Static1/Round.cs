using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Round
    {
        public static double Okr(double r)
        {
            return 2* r * Math.PI;
        }
        public static double S(double r)
        {
            return Math.PI * r * r;
        }
        public static void BelongToS(double r, double x, double y)
        {
            double Gip = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (Gip <= r) 
                Console.WriteLine("Точка ({0},{1}) принадлежит кругу с радиусом {2}", x, y, r);
            else 
                Console.WriteLine("Точка ({0},{1}) не принадлежит кругу с радиусом {2}", x, y, r);
        }
    }
}
