using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,ft=1;
            
            Console.WriteLine("Digite um número para saber seu fatorial: ");
            x = double.Parse(Console.ReadLine());
            for (; x < 0;)
            {
                Console.WriteLine();
                Console.WriteLine("Número Inválido - Não existe fatorial de número negativo");
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine(); 
            }
            Console.WriteLine();

            
            for (; x >= 1;x--)
            {
                ft = ft * x;
            }

            Console.WriteLine(ft);
            Console.ReadKey();
        }
    }
}
