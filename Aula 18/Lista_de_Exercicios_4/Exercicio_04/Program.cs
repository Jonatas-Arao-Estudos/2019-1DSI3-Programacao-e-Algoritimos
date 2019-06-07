using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];

            matriz = valorMatriz(matriz);

            mostraDiagonal(matriz);

            Console.Write("\nClique para encerrar.");
            Console.ReadKey();
        }
        static int[,] valorMatriz(int[,] mtr)
        {
            int cont = 0;
            for (int lin = 0; lin < mtr.GetLength(0); lin++)
            {
                for (int col = 0; col < mtr.GetLength(1); col++)
                {
                    cont += 1;
                    mtr[lin, col] = cont;
                }
            }
            return mtr;
        }
        static void mostraDiagonal(int[,] mtr)
        {
            Console.Write("Diagonais da Matriz\n\n");
            for (int lin = 0; lin < mtr.GetLength(0); lin++)
            {
                for (int col = 0; col < mtr.GetLength(1); col++)
                {
                    if ((col == lin) || (lin + col == mtr.GetLength(1) - 1)) 
                    {
                        Console.Write("{0:D2}\t",mtr[lin, col]);
                    }
                    else
                    {
                        Console.Write("--\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
