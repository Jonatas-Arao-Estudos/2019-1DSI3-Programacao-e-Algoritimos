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
            double x, vlt = 0, media, i;

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite a {0}ª nota: ",i);
                x = Convert.ToDouble(Console.ReadLine());

                for (; x < 0 || x > 10;)
                {
                    Console.WriteLine();
                    Console.WriteLine("Valor inválido - Nota deve estar entre 0 e 10");
                    Console.WriteLine();
                    Console.WriteLine("Digite a {0}ª nota novamente: ", i);
                    x = Convert.ToDouble(Console.ReadLine());
                }

                vlt = vlt + x;

                Console.WriteLine();

            }

            i = i - 1;
            media = vlt / i;

            Console.WriteLine("Sua média é: {0}", media);
            
            Console.ReadKey();
        }
    }
}
