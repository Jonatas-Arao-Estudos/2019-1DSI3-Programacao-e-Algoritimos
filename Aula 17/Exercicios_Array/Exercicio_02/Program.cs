using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, repeat = 20;
            string[] nome = new string[repeat];

            for (i = 0; i < repeat; i++)
            {
                Console.Write("Digite nome do Índice {0}: ", i);
                nome[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (i = 0; i < repeat; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Nome ({0}) no Índice {1}", nome[i], i);
                }
            }

            Console.ReadKey();
        }
    }
}
