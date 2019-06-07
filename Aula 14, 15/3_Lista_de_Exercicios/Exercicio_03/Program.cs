using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Insira o valor dos lados do Triângulo\npara saber o seu tipo");

            do
            {
                Console.Write("\n\nLado A: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nLado B: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nLado C: ");
                c = Convert.ToDouble(Console.ReadLine());
                if (((a < b + c & b < a + c & c < a + b) == false)|| ((a <= 0) || (b <= 0) || (c <= 0)))
                    
                {
                    Console.Clear();
                    Console.Write("Valor dos Lados não formam um triângulo!\nInsira os valores novamente");
                }
            } while (((a < b + c & b < a + c & c < a + b) == false) || ((a <= 0) || (b <= 0) || (c <= 0)));

            if (eEquilatero(a, b, c) == true)
            {
                Console.Write("\nO triângulo é equilátero");
            }

            if (eIsosceles(a, b, c) == true)
            {
                Console.Write("\nO triângulo é isósceles");
            }

            if (eEscaleno(a, b, c) == true)
            {
                Console.Write("\nO triângulo é escaleno");
            }

            Console.ReadKey();
        }

        static bool eEquilatero(double ld1, double ld2, double ld3)
        {
            if (ld1 == ld2 && ld2 == ld3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool eIsosceles(double ld1,double ld2, double ld3)
        {
            if ((ld1 == ld2 || ld1 == ld3 || ld2 == ld3)&(!(ld1 == ld2 && ld2 == ld3))) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool eEscaleno(double ld1, double ld2, double ld3)
        {
            if (ld1 != ld2 && ld1 != ld3 && ld2 != ld3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
