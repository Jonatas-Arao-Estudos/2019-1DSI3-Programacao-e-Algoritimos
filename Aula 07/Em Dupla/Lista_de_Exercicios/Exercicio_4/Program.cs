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
            a = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("O Resultado de {0}² * 5 –{2} / ({1} –{0} % 4) é {3}",a,b,c, Math.Pow(a,2)*5-c/(b-a%4));


            Console.ReadKey();
        }
    }
}
