using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Escreva valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Lista de números impares entre {0} e {1}:", x, y);
            if (x > y)
            {
                for (; x >= y; x--)
                {
                    if (x % 2 == 1)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            else if (y > x)
            {
                for (; y >= x; y--)
                {
                    if (y % 2 == 1)
                    {
                        Console.WriteLine(y);
                    }
                }
            }
            else if (x == y && x % 2 == 1) 
                {
                    Console.WriteLine(x);
                }
            else
                {
                    Console.WriteLine("Nenhum número é impar");
                }

            Console.ReadKey();
        }
    }
}
