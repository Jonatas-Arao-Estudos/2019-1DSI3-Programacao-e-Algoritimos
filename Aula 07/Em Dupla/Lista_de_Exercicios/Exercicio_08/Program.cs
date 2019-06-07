using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, doleta = 3.87,neymares=4.33;

            Console.Write("Insira uma quantia em reais: ");
            real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Essa quantia em dólares é igual a Us${0:N} e em euros é igual a E${1:N}.", real / doleta, real/neymares);
            Console.ReadKey();
        }
    }
}
