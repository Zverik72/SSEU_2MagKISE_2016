using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод длины массива
            int n;
            do
            {
                Console.Write("Введите длину массива: ");
            }
            while
            (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            // инициализация массива 
            int[] a = new int[n];
            // ввод значений массива 
            int i = 0;
            while (i < n)
            {
                Console.Write("Введите a[" + i + "]:");
                if (int.TryParse(Console.ReadLine(), out a[i] ))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                };
                int max = a[0];
                for (i=1;i<a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    };
                };
                //
                Console.WriteLine("Максимальное значение: " + max);
            };
            // выход 
            Console.ReadKey();
        }
    }
}
