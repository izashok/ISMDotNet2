using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s;
            
            Console.WriteLine("Введите а=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b=");
            b = int.Parse(Console.ReadLine());
            s = 1;
            while (a <= b)
            {
                s = s * a;
                a++;
            }
            Console.WriteLine("Результат {0}", s);
        }
    }
}
