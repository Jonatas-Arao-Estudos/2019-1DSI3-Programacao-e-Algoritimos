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
            Console.Write("Insira um número qualquer: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O quadrado de {0} é igual a {1}", x, Math.Pow(x, 2));
            Console.ReadKey();
        }
    }
}
