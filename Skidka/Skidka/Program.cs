using System;
using System.Collections.Generic;
using System.Text;

namespace Skidka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ����� �������:");
            int sum;
            int.TryParse(Console.ReadLine(), out sum);
            double buy;
            if (sum > 1000)
            {
                buy = sum - (sum * 15 / 100);
                Console.WriteLine("����� � ������ ������ ���������� " + buy);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("C����� �� ������ ����� �� ���������������");
            };
            Console.ReadKey();
        }
    }
}
