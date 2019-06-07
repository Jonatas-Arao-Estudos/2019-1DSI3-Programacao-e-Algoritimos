using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Diga o valor de X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diga o valor de Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diga o valor de Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y & x > z)
            {
                Console.WriteLine("O Maior é {0}",x);
            }
            else if (y > x & y > z)
            {
                Console.WriteLine("O Maior é {0}", y);
            }
            else if (z > x & z > y)
            {
                Console.WriteLine("O Maior é {0}", z);
            }
            else
            {
                Console.WriteLine("Nenhum é Maior");
            }
            Console.ReadKey();
        }
    }
}
