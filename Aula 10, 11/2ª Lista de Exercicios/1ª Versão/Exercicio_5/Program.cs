using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, i, m = 0;

            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Digite {0}º valor: ",i);
                x = Convert.ToDouble(Console.ReadLine());

                if (x > m || i == 1)
                {
                    m = x;
                }
            }

            Console.WriteLine("O maior é: " + m);

            Console.ReadKey();
        }
    }
}

