using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18)
            {
                Console.WriteLine("Você é de menor.");
            }
            else if(idade < 60)
            {
                Console.WriteLine("Você é adulto.");
            }
            else
            {
                Console.WriteLine("Você é idoso.");
            }
            Console.ReadLine();
        }
    }
}
