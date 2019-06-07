using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=1, res;
            res = 0;
            for (x = 1; x <= 100; x++)
            {
                res = res + x /( x + 1);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
