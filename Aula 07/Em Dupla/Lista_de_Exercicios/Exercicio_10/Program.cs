using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;

            Console.Write("digite o valor de w: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de z: ");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", ((x >= y) && (z <= x)) || ((x == w) && (y == z)) || (!(x != w)));
            Console.ReadKey();

        }
    }
}
