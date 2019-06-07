using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            for (x = 1; x >= 1 && x <= 100; x++)
            {
                if (x % 10 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} é MULTIPLO DE 10",x);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(x);
                }

            }

            Console.ReadKey();
        }
    }
}
