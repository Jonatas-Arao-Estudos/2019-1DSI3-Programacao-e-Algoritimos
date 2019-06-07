using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Insira o valor do Par Ordenado:\n");
            Console.Write("Valor X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            if (verificaQuadrante(x, y) != 0)
            {
                Console.Write("\nO par ordenado pertence ao {0}º quadrante no plano cartesiano", verificaQuadrante(x, y));
            }
            else
            {
                Console.Write("\nO número não pertence a nenhum quadrante e sim aos eixos x ou y");
            }
            Console.ReadKey();
        }
        static int verificaQuadrante(double numx,double numy)
        {
            if (numx > 0 && numy > 0)
            {
                return 1;
            }
            else if (numx < 0 && numy > 0)
            {
                return 2;
            }
            else if (numx < 0 && numy < 0)
            {
                return 3;
            }
            else if (numx > 0 && numy < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
