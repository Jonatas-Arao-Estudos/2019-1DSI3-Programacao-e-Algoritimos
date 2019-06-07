using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Insira o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0} b={1}", a, b);
            Console.ReadKey();
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a={0} b={1}", a, b);
            Console.ReadKey();
        }
    }
}
