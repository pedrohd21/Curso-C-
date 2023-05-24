using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09While
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            while(cont <= 10) // mesmo de sempre
            {
                Console.WriteLine(cont);
                cont++;
                if (cont == 5)
                {
                    Console.WriteLine("PArei");
                    break;
                }
            }

            do
            {
                Console.WriteLine("Executa se a condição do while for falsa");
            } while(1000 < 10);

            Console.ReadLine();
        }
    }
}
