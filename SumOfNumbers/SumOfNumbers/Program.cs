﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x; // количество чисел N и одно число х
            Console.WriteLine("Введите количество числео для суммирования:");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int sum = 0; // сумма чисел 
                int i = 0; // счетчик количетсва введенных чисел 
                // N раз 
                do
                {
                    Console.WriteLine("Введите число:");
                    // если введено корректное число
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        sum += x; // добавить к сумме
                                  //*DEBUG INFO
                        Console.WriteLine("{" + sum + "}");
                        //*/
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Введите целое число!");
                    };
                }
                while (i < N);
                
                // вывод результата
                Console.WriteLine("Сумма: " + sum);
            };
            // завершение программы
            Console.ReadKey();

        }
    }
}
