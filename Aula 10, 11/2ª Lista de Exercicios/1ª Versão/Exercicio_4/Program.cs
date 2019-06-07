using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, qtd=0;

            Console.WriteLine("Escreva valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (x > y)
            {
                for (; x >= y; x--)
                {
                    if (x % 2 == 1 || x % 2 == -1)
                    {
                        qtd++;
                    }
                }
            }
            else if (y > x)
            {
                for (; y >= x; y--)
                {
                    if (y % 2 == 1 || y % 2 == -1)
                    {
                        qtd++;
                    }
                }
            }
            else if (x % 2 == 1 || x % 2 == -1)
            {
                qtd++;
            }
            Console.WriteLine("Existem {0} números impar(es)",qtd);
            Console.ReadKey();
        }
    }
}
