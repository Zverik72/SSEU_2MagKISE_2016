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
            Console.WriteLine("������� 3 �����:");
             if (int.TryParse(Console.ReadLine(), out a) 
                 && int.TryParse(Console.ReadLine(), out b) 
                 && int.TryParse(Console.ReadLine(), out c))
             {
                 // ����  � ������ 
                 if (a >= b)
                 {
                     max = a;
                 }
                 // ����� B ������
                 else
                 {
                     max = b;
                 };
                 // ���� � ������ ������������� �� �, �, �� �- ������������
                if (C >= max)
                 {
                     max = c;
 
                 };
 
                 // ����� ���������� 
                        Console.WriteLine("������������ = " + max);
                    }
                    else
                    {
                        Console.WriteLine("�������� ��������! ����� ������ ����� �����.");
                    };
                    // ���������� ���������
                    Console.ReadKey();
                }
            }
        }

    }
}