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
            int x, y, z, w;
            Console.Write("Insira o valor de X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de W: ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("({0} >= {1}) AND ({2} <= {0})) OR (({0} == {1}) AND ({1} == {2})) OR (NOT({0} != {3})) = {4}",x,y,z,w, ((x >= y) && (z <= x)) || ((x == y) && (y == z)) || (!(x != w)));
            Console.ReadKey();

            

        }
    }
}
