using System;
using System.Collections.Generic;
using System.Text;

namespace Far
{
    class Program
    {
        static void Main(string[] args)
        {
            double tc, tf;
            Console.Write("Введите температуру в градусах Цельсия: "); // выводит текст 
            double.TryParse(Console.ReadLine(), out tc);             // считывает значение цельсия и переводит в число 
            tf = (9/5)*tc + 32;                                      //формула перехода из цельсия в фаренгейт 
            Console.WriteLine("Температура по Фаренгейту равна: {0}", tf);
            Console.ReadKey();
        }
    }
}
