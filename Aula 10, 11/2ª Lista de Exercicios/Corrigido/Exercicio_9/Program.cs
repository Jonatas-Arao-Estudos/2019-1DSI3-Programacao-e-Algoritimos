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

            do
            {
                for (i = 1; ; i++)
                {
                    Console.Write("Escreva o {0}º número inteiro: ", i);
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (x % 2 == 0)
                    {
                        qtpar++;
                    }
                    else
                    {
                        qtimpar++;
                    }
                    if (x >= 0)
                    {
                        qtpos++;
                    }
                    else
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
                    opcao = Console.ReadLine().ToUpper();
                    Console.Clear();

                }
            } while (opcao != "S");
        }  
    }
}
