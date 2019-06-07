using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b, c;
            Console.WriteLine("Para o cálculo de uma formula oculta de 3 variáveis");
            Console.Write("insira o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("insira o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("insira o valor de C: ");
            c= Convert.ToDouble(Console.ReadLine());
            x = (2 * a + b) / c;
            Console.WriteLine("O Resultado é "+x);
            Console.ReadLine();
        }
    }
}
