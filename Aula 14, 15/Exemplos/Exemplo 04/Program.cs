using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Entre com número: ");
            num = int.Parse(Console.ReadLine());

            if (restoPorDois(num) == 0)
                Console.WriteLine("\n\nO número é par.\n");
            else
                Console.WriteLine("\n\nO número é impar.\n");

            Console.ReadKey();
        }
        static int restoPorDois(int a)
        {
            return a % 2;
        }
    }
}
