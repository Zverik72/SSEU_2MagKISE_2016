using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsAndFar
{
    class Program
    {
        static void Main(string[] args)
        {
            double tc, tf; // объявление переменных
            Console.Write("Введите температуру в градусах Цельсия: "); // вывод текста 
            double.TryParse(Console.ReadLine(), out tc); // считывает данные и переводит в число 
            tf = (9 / 5) * tc + 32;  // формула перевода из цнльсия в фаренгейт
            Console.WriteLine("Температура по Фаренгейту равна: {0}", tf); // выводит аргумент tf полученный в результате подсчета формулы 
            Console.ReadKey(); // предотвращает автоматическое закрытие окна 
        }
    }
}
