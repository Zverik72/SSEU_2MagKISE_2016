using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            sum = a + b;
            Console.WriteLine(a + " + " + b + " = " + sum);
            Console.ReadKey();
        }
    }
}
