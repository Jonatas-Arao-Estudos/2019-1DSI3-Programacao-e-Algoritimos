using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double vlh;
            do
            {
                Console.Write("Peso Ideal\n\n1 - Para Homens\n2 - Para Mulheres\n0 - Sair");
                Console.Write("\nDigite sua escolha: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write("Digite sua altura: ");
                        vlh = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Seu peso ideal é {0}kg", calcularPesoIdeal(op, vlh));
                        Console.Write("\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Digite sua altura: ");
                        vlh = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Seu peso ideal é {0}kg", calcularPesoIdeal(op, vlh));
                        Console.Write("\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Número Inválido");
                        Console.Write("\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op != 0);
        }
        static double calcularPesoIdeal(int sexo,double h)
        {
            if (sexo == 1)
            {
                return (72.7 * h) - 58;
            }
            else
            {
                return (62.1 * h) - 44.7;
            }
        }
    }
}
