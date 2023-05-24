using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Enum
{
    class Program
    {
        enum Cor { azul, verde, amarelo, vermelho}
        static void Main(string[] args)
        {
            Cor corFavorita = Cor.amarelo;

            Console.WriteLine(corFavorita);
        }
    }
}
