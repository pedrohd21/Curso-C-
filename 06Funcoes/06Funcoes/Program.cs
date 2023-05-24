using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // exibirMsg();
            //gerarPreco(10, "Arroz");
            int somar1 = somar(10, 20);
            Console.WriteLine(somar1);


            Console.ReadLine();
        }
        static void exibirMsg() // void é o tipo de retorno
        {
            // Console.WriteLine("Retorna uma funcao vazia");
        }
        static void gerarPreco(int preco, string nome)
        {
            Console.WriteLine(preco + nome);
        }

        static int somar(int a, int b) //string, float, bool
        {
            return a + b;
        }
    }
}
