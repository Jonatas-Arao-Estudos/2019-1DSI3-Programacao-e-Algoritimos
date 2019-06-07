using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,alan;
            Console.Write("Digite o valor da variável A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variável B: ");
            b = int.Parse(Console.ReadLine());
            alan = a;
            a = b;
            b = alan;
            Console.WriteLine("Valor de A:{0}", a);
            Console.WriteLine("Valor de B:{0}", b);
            Console.ReadKey();

        }
    }
}
