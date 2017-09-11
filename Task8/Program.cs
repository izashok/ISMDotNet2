using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            double a,p;

            Console.WriteLine("Введите n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a=");
            a = double.Parse(Console.ReadLine());
            p = a;
            for (i = 1; i <= n; i++)
            {
                p = p* a;
            }
            Console.WriteLine("Результат {0}", p);        }
    }
}
