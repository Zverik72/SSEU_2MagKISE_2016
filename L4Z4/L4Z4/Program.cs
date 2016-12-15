using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово для проверки: ");
            string S = Console.ReadLine();
            int x = 0;
            char c = ' '; // предыдущий символ
               foreach (char s in S) //задаем опорный символ
                  {
                    // проверяем символы
                      foreach (char sa in S)
                    //если не равен предыдущему и равен опорному
                      if (sa != c && sa == s) 
                    // увеличить на 1
                      x++; 
                    // если не равно 0
                      if (x != 0) 
                    Console.Write("{0}{1}", s, x); 
                      x = 0;
                      c = s; 
                       }
            Console.ReadKey();
        }
    }
}
