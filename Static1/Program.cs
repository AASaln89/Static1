using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER RADIUS");
            Console.WriteLine(Round.Okr(out double L));
            Console.WriteLine();
            Console.WriteLine("ENTER RADIUS");
            Console.WriteLine(Round.S(out double S));
            Console.ReadKey();
        }
    }
    public static class Round
    {
        public static double Okr(out double L)
        {
            double r;
            r = Convert.ToInt32(Console.ReadLine());
            L = 2 * r * Math.PI;
            return L;
        }

        public static double S(out double S)
        {
            double r;
            r = Convert.ToInt32(Console.ReadLine());
            S = Math.PI * r * r;
            return S;
        }
    }
}
