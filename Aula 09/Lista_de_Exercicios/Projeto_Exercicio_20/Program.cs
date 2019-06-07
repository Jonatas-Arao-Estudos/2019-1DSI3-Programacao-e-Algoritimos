using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, m = 0;

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Digite um valor: ");
                x = int.Parse(Console.ReadLine());
                if (x < m || i == 1) { 
                    m = x;
                }
            }
            Console.WriteLine("O menor é: " + m);
            Console.ReadKey();
        }
    }
}
