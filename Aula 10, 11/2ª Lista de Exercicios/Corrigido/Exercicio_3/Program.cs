using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,n;

            Console.Write("Insira um número para ver sua Tabuada: ");
            x = Convert.ToDouble(Console.ReadLine());

            for(n=0;n<=10;n++)
            {
                Console.WriteLine("{0} x {1} = {2}", x, n, x * n);
            }

            Console.ReadKey();
        }
    }
}
