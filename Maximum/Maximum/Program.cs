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
            int a, b, max;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            Console.WriteLine("Максимальное = " + max);
            Console.ReadKey();
        }
    }
}
