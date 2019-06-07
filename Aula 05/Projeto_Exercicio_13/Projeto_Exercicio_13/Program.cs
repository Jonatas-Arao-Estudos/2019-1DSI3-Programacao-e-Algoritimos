using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Escreva o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Escreva o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (a>b)
            {
                Console.WriteLine("O maior valor é {0}", a);
            }
            else
            {
                Console.WriteLine("O maior valor é {0}", b);
            }
            Console.ReadKey();
        }
    }
}
