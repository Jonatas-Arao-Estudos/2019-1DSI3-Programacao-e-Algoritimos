using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar=3.78,euro=4.28;
            Console.WriteLine("Conversor de Câmbio");
            Console.WriteLine();
            Console.Write("Insira um valor em Reais: R$");
            real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Reais R${0:N}",real);
            Console.WriteLine("Dólar(es) US${0:N}", real / dolar);
            Console.WriteLine("Euro(s) E${0:N}", real / euro);
            Console.ReadKey();
        }
    }
}
