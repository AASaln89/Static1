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
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Round.Okr(r));
            Console.WriteLine(Round.S(r));
            Console.WriteLine("Проверка принадлежности точки к площади круга");
            Console.WriteLine("Ввод координаты по Х");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввод координаты по У");
            double y = Convert.ToDouble(Console.ReadLine());
            Round.BelongToS(r,x,y);
            Console.ReadKey();
        }
    }
}
