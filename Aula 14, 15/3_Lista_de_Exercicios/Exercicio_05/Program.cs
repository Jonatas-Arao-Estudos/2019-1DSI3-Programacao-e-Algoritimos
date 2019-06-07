using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double x, y;
            do
            {
                Console.Write("Calculadora C# 1.0\n\n1 - Soma - (x+y)\n2 - Subtração - (x-y)\n3 - Divisão - (x/y)\n4 - Multiplicação - (x*y)\n5 - Resto de Divisão - (x%y)\n6 - Dobro - (2x) - (2y)\n7 - Quadrado - (x²) - (y²)\n8 - Cubo - (x³) - (y³)\n9 - Raiz Quadrada - (√x) - (√y)\n0 - Sair\n");
                Console.Write("\nDigite sua escolha: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Soma\n\n");
                        Console.Write("A soma de {0} + {1} = {2}", x, y, some(x, y));
                        Console.Write("\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nSubtração\n\n");
                        Console.Write("A subtração de {0} por {1} = {2}", x, y, subtraia(x, y));
                        Console.Write("\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nDivisão\n\n");
                        Console.Write("A divisão de {0} por {1} = {2}", x, y, divida(x, y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nMultiplicação\n\n");
                        Console.Write("A multiplicação de {0} por {1} = {2}", x, y, multiplique(x, y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nResto de Divisão\n\n");
                        Console.Write("O resto de {0} / {1} = {2}", x, y, tirarResto(x, y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nDobro\n\n");
                        Console.Write("O dobro de {0} é igual a {2}\nO dobro de {1} é igual a {3}", x, y, dobro(x), dobro(y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nQuadrado\n\n");
                        Console.Write("O quadrado de {0} é igual a {2}\nO quadrado de {1} é igual a {3}", x, y, aoQuadrado(x), aoQuadrado(y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nCubo\n\n");
                        Console.Write("O cubo de {0} é igual a {2}\nO cubo de {1} é igual a {3}", x, y, aoCubo(x), aoCubo(y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Write("Valores de X e Y\n");
                        Console.Write("Digite valor X: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite valor Y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\nQuadrado\n\n");
                        Console.Write("A raiz quadrada de {0} é igual a {2}\nA raiz quadrada de {1} é igual a {3}", x, y, raizQuadrada(x), raizQuadrada(y));
                        Console.Write("\n\nClique para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op != 0);
        }
        static double some(double num1,double num2)
        {
            return num1 + num2;
        }
        static double subtraia(double num1, double num2)
        {
            return num1 - num2;
        }
        static double divida(double num1, double num2)
        {
            return num1 / num2;
        }
        static double multiplique(double num1, double num2)
        {
            return num1 * num2;
        }
        static double tirarResto(double num1, double num2)
        {
            return num1 % num2;
        }
        static double dobro(double num1)
        {
            return num1 * 2;
        }
        static double aoQuadrado(double num1)
        {
            return Math.Pow(num1, 2);
        }
        static double aoCubo(double num1)
        {
            return Math.Pow(num1, 3);
        }
        static double raizQuadrada(double num1)
        {
            return Math.Sqrt(num1);
        }
    }
}
