using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_17
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
            if (x > y & y > z)
            {
                Console.WriteLine("Então {2}<{1}<{0}", x, y, z);
            }
            else if (x > z & z > y)
            {
                Console.WriteLine("Então {2}<{1}<{0}", x, z, y);
            }
            else if (y > x & x > z)
            {
                Console.WriteLine("Então {2}<{1}<{0}", y, x, z);
            }
            else if (y > z & z > x)
            {
                Console.WriteLine("Então {2}<{1}<{0}", y, z, x);
            }
            else if (z > x & x > y)
            {
                Console.WriteLine("Então {2}<{1}<{0}", z, x, y);
            }
            else if (z > y & y > x)
            {
                Console.WriteLine("Então {2}<{1}<{0}", z, y, x);
            }
            else
            {
                Console.WriteLine("Então {0}={1}={2}", x, y, z);
            }
            Console.ReadKey();
        }
    }
}
