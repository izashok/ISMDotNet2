using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            double x1, x2,x0;

            Console.WriteLine("Введите а=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c=");
            c = int.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
            x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
            x0 = (-1 * b) / (2 * a);
            if (d > 0)
                Console.WriteLine("2 решения : x1={0}, x2={1}", x1 , x2);
            else
                if (d == 0)
                  
                       Console.WriteLine("1 решение : x0={0}", x0);

                else
                    Console.WriteLine("Решений нет");

        }
    }
}
