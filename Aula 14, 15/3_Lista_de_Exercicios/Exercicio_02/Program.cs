using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y,res;
            Console.Write("Insira o 1º Valor: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o 2º Valor: ");
            y = Convert.ToDouble(Console.ReadLine());
            res = diferença(x, y);
            if (x > y)
            {
                Console.Write("\nA diferença entre {0} e {1} é igual a {2}", x, y, res);
            }
            else
            {
                Console.Write("\nA diferença entre {0} e {1} é igual a {2}", y, x, res);
            }
            Console.ReadKey();
        }
        static double diferença(double vlr1,double vlr2)
        {
            if (vlr1 > vlr2)
            {
                return vlr1 - vlr2;
            }
            else
            {
                return vlr2 - vlr1;
            }
        }
    }
}
