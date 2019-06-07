using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Insira o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O resultado da expressão {0}²*5-{2}/({1}-{0}%4)",a,b,c);
            Console.WriteLine("é igual a {0}", Math.Pow(a, 2) * 5 - c / (b - a % 4));
            Console.ReadKey();
        }
    }
}
