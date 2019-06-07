using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, i;

            Console.Write("Digite a tabuada: ");
            t = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(t + "x" + i + "=" + (t * i));
            }
            Console.ReadKey();
        }
    }
}
