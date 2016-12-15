using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string imya = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string otchestvo = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string familiya = Console.ReadLine();
            //И.О.Фамилия
            if (!string.IsNullOrEmpty(otchestvo))  //если отчество ввели
            {
           //   Console.WriteLine(imya[0] + ". " + otchestvo[0] + ". " + familiya);
                Console.WriteLine(imya[0].ToString().ToUpper() + ". " //И.
                                  + otchestvo[0].ToString().ToUpper() + ". " //О.
                                  + familiya[0].ToString().ToUpper()   //Ф
                                  + familiya.Substring(1).ToLower()); //амилия
            }
            else // иначе- отчество не ввели
            {
                // выводим без отчества
                Console.WriteLine(imya[0].ToString().ToUpper() + ". " //И.
                                  + familiya[0].ToString().ToUpper() //Ф
                                  + familiya.Substring(1).ToLower()); //амилия
            };

            //Фамилия И.О.
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
            { 
                Console.WriteLine(familiya[0].ToString().ToUpper()  // Ф
                              + familiya.Substring(1).ToLower() + " "  // амилия
                              + imya[0].ToString().ToUpper() + ". " //И.
                              + otchestvo[0].ToString().ToUpper());// О.
             }
            else
            {
                // Выводим без отчества
                Console.WriteLine(familiya[0].ToString().ToUpper()
                                  + familiya.Substring(1).ToLower() + " "
                                  + imya[0].ToString().ToUpper() + ".");
            };
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
                //Имя Отчество ФАМИЛИЯ
            { 
                Console.WriteLine(imya[0].ToString().ToUpper() //И 
                              + imya.Substring(1).ToLower() + " " //мя
                              + otchestvo[0].ToString().ToUpper() // О 
                              + otchestvo.Substring(1).ToLower() + " " //тчество
                              + familiya.ToUpper()); // ФАМИЛИЯ
             }
            else
            {
                // Выводим без отчества
                Console.WriteLine(imya[0].ToString().ToUpper()
                                  + imya.Substring(1).ToLower() + " "
                                  + familiya.ToUpper());
             };
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
                //фам_и_о
            { 
                Console.WriteLine((familiya.Substring(0, 3) + "_" //фам_
                              + imya.Substring(0, 1) + "_" //и
                              + otchestvo.Substring(0, 1)).ToLower());//о
             }
            else
            {
                Console.WriteLine((familiya.Substring(0, 3) + "_" + imya.Substring(0, 1)));
            };
            Console.ReadKey();
        }
    }
}
