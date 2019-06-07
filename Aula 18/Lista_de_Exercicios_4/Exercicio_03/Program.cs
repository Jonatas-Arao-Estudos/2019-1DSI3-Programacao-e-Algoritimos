using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;

            matriz = escolheMatriz();

            matriz = valorMatriz(matriz);
            
            Console.Write("\nClique para encerrar.");
            Console.ReadKey();
            Console.Clear();

            exibaSomaMatriz(matriz);

            Console.Write("\nClique para encerrar.");
            Console.ReadKey();
        }
        static int[,] escolheMatriz()
        {
            int[,] mtr = new int[0,0];
            int opcao;
            do
            {
                Console.Write("Escolha sua Matriz \n\n 1 - Matriz (3,5) \n 2 - Matriz (5,3)\n\n");
                Console.Write("Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        mtr = new int[3, 5];
                        break;
                    case 2:
                        mtr = new int[5, 3];
                        break;
                }
            } while (opcao != 1 && opcao != 2);
            return mtr;
        }
        static int[,] valorMatriz(int[,] mtr)
        {
            for (int lin = 0; lin < mtr.GetLength(0); lin++)
            {
                for (int col = 0; col < mtr.GetLength(1); col++)
                {
                    Console.Write("Insira o {0}º valor da linha {1}\n", col + 1, lin + 1);
                    mtr[lin, col] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            return mtr;
        }
        static void exibaSomaMatriz(int[,] mtr)
        {
            int somaLinha = 0;
            Console.Write("Soma das Linhas da Matriz:\n\n");
            for (int linha = 0; linha < mtr.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mtr.GetLength(1); coluna++)
                {
                    somaLinha += mtr[linha, coluna];
                    Console.Write("{0}\t", mtr[linha, coluna]);

                    if (coluna == mtr.GetLength(1) - 1)
                    {
                        Console.Write("= {1}\n", linha + 1, somaLinha);
                        somaLinha = 0;
                    }
                }
            }
        }
    }
}