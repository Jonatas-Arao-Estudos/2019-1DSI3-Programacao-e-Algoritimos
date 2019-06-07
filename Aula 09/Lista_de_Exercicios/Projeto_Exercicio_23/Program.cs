using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, res;
            res = 0;
            for (x = 1; x <= 123; x++)
            {
                res = res + x / (x + 5);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
