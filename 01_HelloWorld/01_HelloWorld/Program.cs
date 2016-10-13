using System;
using System.Collections.Generic;
using System.Text;

namespace _1_HelloWorld
{
    class Program
    {
 //       public static void Main()
        public static void Main(string[] args) 
        {
            Console.WriteLine("HelloWorld");
 //           Console.Write("What's your name? ");  
 //           string userName = Console.ReadLine();  
            string userName;  
            if (args.Length > 0)  
            {  
          		userName = args[0];  
		     }  
		    else  
	     	{  
			Console.Write("What's your name? ");  
			userName = Console.ReadLine();  
		     };  
            Console.WriteLine("Hello, " + userName);  
            Console.Write("\nPrint any key to exit");
            Console.ReadKey(); 

        }
    }
}
