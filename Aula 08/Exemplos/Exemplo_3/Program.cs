using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, i;

            Console.Write("Digite a tabuada: ");
            t = int.Parse(Console.ReadLine());
            i = 1;
            do
            {
                Console.WriteLine(t + "x" + i + "=" + (t * i));
                i++;
            } while (i<=10);
            Console.ReadKey();
        }
    }
}
