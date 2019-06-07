using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, v1, v2, res;

            Console.Write("Digite o 1º Valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º Valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1-Soma 2-Sub 3-Div 0-Sair");
            opção = int.Parse(Console.ReadLine());
            switch (opção)
            {
                case 1:
                    res = v1 + v2;
                    Console.WriteLine(res);
                    Console.ReadKey();
                    break;
                case 2:
                    res = v1 - v2;
                    Console.WriteLine(res);
                    Console.ReadKey();
                    break;
                case 3:
                    res = v1 / v2;
                    Console.WriteLine(res);
                    Console.ReadKey();
                    break;
                case 0:
                    break;
            }
        }
    }
}
