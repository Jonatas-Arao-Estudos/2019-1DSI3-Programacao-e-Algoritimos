using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, i;

            Console.Write("Digite a tabuada: ");
            t = int.Parse(Console.ReadLine());
            i = 100;
            while (i<=10)
            {
                Console.WriteLine(t + "x" + i + "=" + (t * i));
                i++;
            }
            Console.ReadKey();
        }
    }
}
