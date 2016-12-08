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
            int a, b, max=0;
            if (int.TryParse(Console.ReadLine(), out a))
            { 
                if(int.TryParse(Console.ReadLine(), out b))
            {
               
                if (a >= b)
                {
                    max = a;
                }
                else
                {
                    max = b;
                };
            };
                Console.WriteLine(" Максимальное = " + max);
            }
            else
            {
                Console.WriteLine("Неверное значение! Нужно ввести целое число.");
            }
            Console.ReadKey();
        }
    }
}

