using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double s,a;

            Console.WriteLine("Введите n=");
            n = int.Parse(Console.ReadLine());
            a = 1.0;
            s = 0;
            while (a <= n)
            {
                s = s + (1/a);
                a++;

            }
            Console.WriteLine("Результат {0}", s);
        }
    }
}
