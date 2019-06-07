using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, repeat=50;
            int[] numeros = new int[repeat];

            for (i = 0; i < repeat; i++)
            {
                Console.Write("Digite o {0}º número: ", i+1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i < repeat; i++)
            {
                if (numeros[i] % 2 == 1)
                {
                    Console.WriteLine("{0}º Número  -  {1}", i , numeros[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
