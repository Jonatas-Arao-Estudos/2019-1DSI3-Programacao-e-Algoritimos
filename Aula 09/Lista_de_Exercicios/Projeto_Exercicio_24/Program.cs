using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, res;
            res = 0;
            for (x = 1; x <=80; x++)
            {
                res = res + 1 / Math.Pow(x,2);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
