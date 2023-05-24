using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // &&(E ou And) 
            // || (OU/OR)
            int a = 10;
            int b = 20;
            int c = 2;
            if(a < b)
            {
                Console.WriteLine("if");
            }
            else if(a > c)
            {
                Console.WriteLine("Executol ifelse");
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.ReadLine();
        }
    }
}
