using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, periodo;
            x = 0;
            y = 1;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (periodo=1; periodo<=18;periodo++) {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
            Console.ReadKey();
        }
    }
}
