using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            double z1, z2;
            Console.WriteLine("Введите m=");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n=");
            n = int.Parse(Console.ReadLine());
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / ((Math.Sqrt(Math.Pow(m, 3) * n)) + n * m + m * m -m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("Z1={0},  Z2={1}", z1, z2);


        }
    }
}
