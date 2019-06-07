using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeum, nomedois;

            Console.Write("Digite o primeiro nome: ");
            nomeum = Console.ReadLine();
            Console.Write("Digite o segundo nome: ");
            nomedois = Console.ReadLine();
            Console.WriteLine("o nome {0} tem {1} letras. as 3 primeiras letras são {2}.", nomeum.ToUpper(), nomeum.Length, nomeum.Substring(0,3));
            Console.WriteLine("o nome {0} tem {1} letras. as 3 primeiras letras são {2}.", nomedois.ToUpper(), nomedois.Length, nomedois.Substring(0, 3));
            Console.ReadKey();

        }
    }
}
