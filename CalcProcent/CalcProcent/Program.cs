using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProcent
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum, procent = 0,pay = 0; //сумма кредита, процент по выплатам, сумма выплат
            int srok, stavka, chastota; //Срок кредитования, годоавя процентная ставка и частота выплат в год
            int god = 12; //12 месяцев
            double result = 0, c = 0.01; //результат вычисления// для перевода процентов
            string operation; //метод начисления
                       //ввод данных
            Console.WriteLine("Введите сумму кредитования: ");
            double.TryParse(Console.ReadLine(), out sum);
            Console.WriteLine("Введите срок кредитования: ");
            int.TryParse(Console.ReadLine(), out srok);
            Console.WriteLine("Введите ставку кредитования: ");
            int.TryParse(Console.ReadLine(), out stavka);
            Console.WriteLine("Введите количество выплат в год: ");
            int.TryParse(Console.ReadLine(), out chastota);
                       //выбираем операцию
            Console.WriteLine("Выберите метод 1 - простой или 2 - сложный: ");
            operation = Console.ReadLine();
               switch (operation)
             {
               case "1": 
                result = sum * (1 + (srok / god) * (stavka * c)); //итоговая сумма выплат по кредиту
                procent = result - sum; //сумма начисленных процентов
                    pay = result / (srok / god) / chastota; //величина эквивалентных выплат
               break;
               case "2": 
               result = sum * Math.Pow(1 + stavka * c, srok / god); //итоговая сумма выплат по кредиту
                procent = result - sum; //сумма начисленных процентов
                    pay = result / (srok / god) / chastota; //величина эквивалентных выплат
               break;
               default: Console.WriteLine("Неверная операция"); break;
                };
               //выводим результат
             Console.WriteLine("Итоговая сумма выплат по кредиту: " + result);
             Console.WriteLine("Cумма начисленных процентов: " + procent);
             Console.WriteLine("Величина эквивалентных выплат: " + pay);
             Console.ReadLine();
        }
    }
}
