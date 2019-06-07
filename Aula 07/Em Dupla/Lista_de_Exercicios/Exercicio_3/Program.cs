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
            int x;

            Console.Write("Digite um número inteiro: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("O quadrado de {0} é {1}", x, Math.Pow(x, 2));

            Console.ReadKey();
        }
    }
}
