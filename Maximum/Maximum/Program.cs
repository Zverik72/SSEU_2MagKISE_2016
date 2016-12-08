using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c>= max)
            { max = c;
            }
            Console.WriteLine("Максимальное = " + max);
            Console.ReadKey();
        }
    }
}
