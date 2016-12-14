using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            Console.WriteLine("Введите 3 числа:");
             if (int.TryParse(Console.ReadLine(), out a) 
                 && int.TryParse(Console.ReadLine(), out b) 
                 && int.TryParse(Console.ReadLine(), out c))
             {
                 // если  А больше 
                 if (a >= b)
                 {
                     max = a;
                 }
                 // иначе B больше
                 else
                 {
                     max = b;
                 };
                 // если С больше максимального из А, В, то С- максимальное
                if (C >= max)
                 {
                     max = c;
 
                 };
 
                 // Вывод результата 
                        Console.WriteLine("Максимальное = " + max);
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                    };
                    // завершение программы
                    Console.ReadKey();
                }
            }
        }

    }
}