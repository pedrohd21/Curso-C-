using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Pedro", "Henrique", "Pc", "memoria" };
            for(int cont = 0; cont < palavras.Length; cont++)
            {
                Console.WriteLine(palavras[cont]);
            }
            Console.WriteLine("===================");
            for (int cont1 = palavras.Length - 1; cont1 > 0; cont1--) 
            {
                Console.WriteLine(palavras[cont1]);
            }
            Console.ReadLine();
        }
    }
}
