using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar=3.78;
            Console.Write("Insira um valor em Reais: ");
            real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("R${0:N} em dólar(es) é US${1:N}",real,real/dolar);
            Console.ReadKey();
        }
    }
}
