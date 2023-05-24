using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Pedro", "Lima", "guia do prog", "formação" };

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }
            Console.ReadLine();
        }
    }
}
