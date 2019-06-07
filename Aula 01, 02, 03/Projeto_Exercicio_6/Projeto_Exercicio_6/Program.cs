using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            Console.WriteLine("Insira o valor da base: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura: ");
            h = Convert.ToDouble(Console.ReadLine());
            a = (b * h) / 2;
            Console.WriteLine("A area do trinangtulo é igual a: "+a);
            Console.ReadKey();
        }
    }
}
