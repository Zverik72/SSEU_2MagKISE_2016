using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
              if (int.TryParse(Console.ReadLine(), out m))
              {
                 switch (m)
                  {
                      case 1: Console.WriteLine("������"); break;
                      case 2: Console.WriteLine("�������"); break;
                      case 3: Console.WriteLine("����"); break;
                      case 4: Console.WriteLine("������"); break;
                      case 5: Console.WriteLine("���"); break;
                      case 6: Console.WriteLine("����"); break;
                      case 7: Console.WriteLine("����"); break;
                      case 8: Console.WriteLine("������"); break;
                      case 9: Console.WriteLine("��������"); break;
                      case 10: Console.WriteLine("�������"); break;
                      case 11: Console.WriteLine("������"); break;
                      case 12: Console.WriteLine("�������"); break;
                      default: Console.WriteLine("������ ������ �� ����������!"); break;
                  }
              }
              else
              {
                 Console.WriteLine("�������� ��������! ������� ����� �����.");
              };
              Console.ReadKey();
        }
    }
}
