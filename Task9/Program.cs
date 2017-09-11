using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n,s,i,g;

           

            Console.WriteLine("Введите n=");
            n = uint.Parse(Console.ReadLine());
            s = 1;
            g = 0;
            for (i = 1; i <= n; i++)
            {
                s = i * s;
                g = g + s;
            }
            Console.WriteLine("Результат {0}", g);
        }
    }
}
