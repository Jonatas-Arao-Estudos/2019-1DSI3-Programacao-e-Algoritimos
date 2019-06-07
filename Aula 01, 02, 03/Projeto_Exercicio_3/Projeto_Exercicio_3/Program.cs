using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, w, y, j, a, b;
            Console.WriteLine("Insira 2 valores para a resolução de 4 operações basicas da matemática entre A e B");
            Console.Write("Insira o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            x = a + b;
            w = a - b;
            y = a * b;
            j = a / b;
            Console.WriteLine(" ");
            Console.WriteLine("A soma de A + B é " + x);
            Console.WriteLine(" ");
            Console.WriteLine("A subtração de A - B é " + w);
            Console.WriteLine(" ");
            Console.WriteLine("A multiplicação entre A * B é " + y);
            Console.WriteLine(" ");
            Console.WriteLine("A divisão entre A / B é " + j);
            Console.WriteLine(" ");
            Console.WriteLine("Obrigado pela utilização");
            Console.ReadKey();

        }
    }
}
