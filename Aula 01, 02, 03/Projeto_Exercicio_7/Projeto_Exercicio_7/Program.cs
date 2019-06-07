using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r;
            Console.WriteLine("Escreva o valor do raio para calcular a área de um circulo, sendo 3,14 como aproximação para pi: ");
            r = Convert.ToDouble(Console.ReadLine());
            a = 3.14 * (r * r);
            Console.WriteLine("Seu circulo tem " + a + " de área");
            Console.ReadKey();
        }
    }
}
