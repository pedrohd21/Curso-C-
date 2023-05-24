using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // int
            // float
            // bool true false
            // String = "Aspas duplas" 
            // char = 'a'; so assim usar aspas simples
            // var = define sozinho o tipo
            // dynamic tem como mudar o tipo da variavel
            // const float = nao muda nunca a variavel

            int numero = 2015;
            string cor = "azul";
            float numeroReal = 20.90f;
            bool verdadeiro = true; // false
            var corFav = "Vermelho";
            var numeroReal2 = 2060.60f;


            Console.WriteLine("Rterfdf" + numero);
            Console.WriteLine(cor);
            Console.WriteLine(numeroReal);
            Console.WriteLine(verdadeiro);
            Console.WriteLine(corFav);
            Console.WriteLine(numeroReal2);

            var meuTexto = "OI";
            Console.ReadLine();

        }
    }
}
