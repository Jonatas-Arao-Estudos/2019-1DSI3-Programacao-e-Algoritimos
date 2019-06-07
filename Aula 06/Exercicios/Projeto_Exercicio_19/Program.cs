using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Insira a medida do lado A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a medida do lado B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a medida do lado C: ");
            c = double.Parse(Console.ReadLine());
            if (a == b & b == c)
            {
                Console.WriteLine("O triângulo é equilátero");
            }
            else if (a == b |b == c | c == a)
            {
                Console.WriteLine("O triângulo é isóceles");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno");
            }
            Console.ReadKey();
        }
    }
}
