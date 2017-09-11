using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            double y;
            Console.WriteLine("Введите а=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x=");
            x = int.Parse(Console.ReadLine());
            y=2.4*Math.Abs((x*x+b)/a)+(a-b)*Math.Pow(Math.Sin(a-b),2)+Math.Pow(10,-2)*(x - b);
            Console.WriteLine("Результат y={0}", y);


        }
    }
}
