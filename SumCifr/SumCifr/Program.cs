using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCifr
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, col = 0, sum = 0; // число, количество и сумма 
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out x))
              {
                do
                    {
                    sum += x % 10; 
                    col++;
                    x = x / 10;
                      }
                while (x / 10 != 0) ;
                sum += x;
                col++;
                       }
                else
             {
            Console.WriteLine("Введите целое число!");
               };
            Console.WriteLine("Cумма: " + sum);
            Console.WriteLine("Количество: " + col);
            Console.ReadKey();
        }
    }
}
