using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, qtpar = 0, qtimpar = 0, qtpos = 0, qtneg = 0;
            string opcao="";

            for (i = 1; opcao!="S" ; i++)
            {
                Console.Write("Escreva o {0}º número inteiro: ", i);
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (x % 2 == 0)
                {
                    qtpar++;
                }
                if (x % 2 == 1 || x % 2 == -1) 
                {
                    qtimpar++;
                }
                if (x >= 0)
                {
                    qtpos++;
                }
                if (x < 0)
                {
                    qtneg++;
                }

                Console.WriteLine("Você escreveu:");
                Console.WriteLine("{0} número(s) par(es).", qtpar);
                Console.WriteLine("{0} número(s) impar(es).", qtimpar);
                Console.WriteLine();
                Console.WriteLine("{0} número(s) positivo(s).", qtpos);
                Console.WriteLine("{0} número(s) negativo(es).", qtneg);
                Console.WriteLine();

                Console.WriteLine("Deseja encerrar o programa ?");
                Console.WriteLine("se Sim digite S - se não aperte Enter");
                opcao = Console.ReadLine();
                Console.Clear();

            }
        }  
    }
}
