using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3];
            int jogada = 1,linha, coluna;
            do
            {
                exibeJogo(tabuleiro);

                if (jogada == 1)
                {

                    Console.WriteLine("Jogador X - Escreva coordenadas da jogada ");
                    Console.Write("\nLinha: ");
                    linha = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Coluna: ");
                    coluna = int.Parse(Console.ReadLine()) - 1;
                    if (tabuleiro[linha, coluna] == null)
                    {
                        tabuleiro[linha, coluna] = "X";
                        jogada = 2;
                    }
                }
                else
                {
                    Console.WriteLine("Jogador O - Escreva coordenadas da jogada ");
                    Console.Write("\nLinha: ");
                    linha = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Coluna: ");
                    coluna = int.Parse(Console.ReadLine()) - 1;
                    
                    if (tabuleiro[linha, coluna] == null)
                    {
                        tabuleiro[linha, coluna] = "O";
                        jogada = 1;
                    }
                    
                }
                Console.Clear();
            } while (verificaFimJogo(tabuleiro) == false);

            exibeJogo(tabuleiro);
            if (verificaVencedor(tabuleiro) == "X")
            {
                Console.WriteLine("Parabéns!!!!");
                Console.WriteLine("O Jogador X Ganhou");
            }
            else if (verificaVencedor(tabuleiro) == "O")
            {
                Console.WriteLine("Parabéns!!!!");
                Console.WriteLine("O Jogador O Ganhou");
            }
            else
            {
                Console.WriteLine("Deu Velha!");
            }

            Console.WriteLine("Clique para encerrar jogo");
            Console.ReadKey();
        }
        static void exibeJogo(string[,] jogo)
        {
            Console.WriteLine("--------- Jogo da Velha ---------\n");
            Console.WriteLine("\t 1\t 2\t 3\n");
            for (int i = 0; i < jogo.GetLength(0); i++) 
            {
                Console.Write(i+1);
                for(int j = 0; j < jogo.GetLength(1); j++)
                {
                    if (jogo[i, j] == null) {
                        Console.Write("\t - ");
                    }
                    else {
                        Console.Write("\t {0} ",jogo[i, j]);
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static bool verificaFimJogo(string[,]jogo)
        {
            if (
                (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2] && jogo[0, 0] != null) || // Principal
                (jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0] && jogo[0, 2] != null) || // Secundária
                (jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2] && jogo[0, 0] != null) || // Linha 1
                (jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2] && jogo[1, 0] != null) || // Linha 2
                (jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2] && jogo[2, 0] != null) || // Linha 3
                (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0] && jogo[0, 0] != null) || // Coluna 1
                (jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1] && jogo[0, 1] != null) || // Coluna 2
                (jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2] && jogo[0, 2] != null) || // Coluna 3
                (jogo[0, 0] != null) &&
                (jogo[0, 1] != null) &&
                (jogo[0, 2] != null) &&
                (jogo[1, 0] != null) &&
                (jogo[1, 1] != null) &&
                (jogo[1, 2] != null) &&
                (jogo[2, 0] != null) &&
                (jogo[2, 1] != null) &&
                (jogo[2, 2] != null)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string verificaVencedor(string[,] jogo)
        {
            if (
                (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2] && jogo[0, 0] == "X") || // Principal
                (jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0] && jogo[0, 2] == "X") || // Secundária
                (jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2] && jogo[0, 0] == "X") || // Linha 1
                (jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2] && jogo[1, 0] == "X") || // Linha 2
                (jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2] && jogo[2, 0] == "X") || // Linha 3
                (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0] && jogo[0, 0] == "X") || // Coluna 1
                (jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1] && jogo[0, 1] == "X") || // Coluna 2
                (jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2] && jogo[0, 2] == "X") // Coluna 3
            )
            {
                return "X";
            }
            else if(
                (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2] && jogo[0, 0] == "O") || // Principal
                (jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0] && jogo[0, 2] == "O") || // Secundária
                (jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2] && jogo[0, 0] == "O") || // Linha 1
                (jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2] && jogo[1, 0] == "O") || // Linha 2
                (jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2] && jogo[2, 0] == "O") || // Linha 3
                (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0] && jogo[0, 0] == "O") || // Coluna 1
                (jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1] && jogo[0, 1] == "O") || // Coluna 2
                (jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2] && jogo[0, 2] == "O") // Coluna 3
            )
            {
                return "O";
            }
            else
            {
                return "#";
            }
        }
    }
}
