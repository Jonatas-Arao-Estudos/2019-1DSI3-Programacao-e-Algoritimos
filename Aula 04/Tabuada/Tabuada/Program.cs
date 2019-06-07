using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("Digite um número para ver sua tabuada: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine(x + " * 1 = " + x * 1);
            Console.WriteLine(x + " * 2 = " + x * 2);
            Console.WriteLine(x + " * 3 = " + x * 3);
            Console.WriteLine(x + " * 4 = " + x * 4);
            Console.WriteLine(x + " * 5 = " + x * 5);
            Console.WriteLine(x + " * 6 = " + x * 6);
            Console.WriteLine(x + " * 7 = " + x * 7);
            Console.WriteLine(x + " * 8 = " + x * 8);
            Console.WriteLine(x + " * 9 = " + x * 9);
            Console.WriteLine(x + " * 10 = " + x * 10);
            Console.WriteLine();
            Console.WriteLine("Obrigado pela Utilização");
            Console.ReadKey();
        }
    }
}
