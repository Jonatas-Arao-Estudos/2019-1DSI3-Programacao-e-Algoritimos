using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;
            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            x = a - b;
            Console.WriteLine("A subtreação de " + a + " - " + b + " é igual a: " + x);
            Console.ReadKey();
        }
    }
}
