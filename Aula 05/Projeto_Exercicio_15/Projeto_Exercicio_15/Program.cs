using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double apple, money;
            Console.WriteLine("Quantas Maçãs você comprou?");
            apple = Convert.ToDouble(Console.ReadLine());
            if (apple<12)
            {
                money = apple * 0.3;
                Console.WriteLine("Você comprou {0} maçãs, que custaram R${1:f2}",apple,money);
            }
            else
            {
                money = apple * 0.25;
                Console.WriteLine("Você comprou {0} maçãs, que custaram R${1:f2}", apple, money);
            }
            Console.ReadKey();
        }
    }
}
