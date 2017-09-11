using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,s,p;
            Console.WriteLine("Введите сторону а=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b=");
            b = int.Parse(Console.ReadLine());
            s = a * b;
            p = 2*(a + b);
            Console.WriteLine("Площадь s={0}, Периметр p={1}", s, p);



        }
    }
}
