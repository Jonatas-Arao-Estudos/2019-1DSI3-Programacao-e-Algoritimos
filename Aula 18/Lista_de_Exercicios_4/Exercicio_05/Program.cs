using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            const int qtdAlunos = 10, qtdNotas = 3;
            string[] alunos = new string[qtdAlunos];
            double[] mediaNota = new double[qtdAlunos];
            double[,] notas = new double[qtdAlunos,qtdNotas];

            do { 
                Console.Write("Notas e Alunos \n\n 1 - Cadastro \n 2 - Relatório\n 0 - Sair\n\n");
                Console.Write("Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Cadastro de Alunos e Notas\n\n");

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            alunos[i] = cadastraAluno();

                            for (int j = 0; j < qtdNotas; j++)
                            {
                                notas[i, j] = cadastraNota(alunos[i], j + 1);
                            }

                            mediaNota[i] = calculaMedia(i, notas);
                            Console.WriteLine();
                        }

                        Console.Write("\nClique para encerrar cadastro de notas.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        exibaRelatorio(alunos, mediaNota, notas);
                        Console.Write("\nClique para sair do Relatório.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcao != 0);
        }
        static string cadastraAluno()
        {
            string valNome;

            Console.Write("Nome do Aluno: ");
            valNome = Console.ReadLine();

            return valNome;
        }
        static double cadastraNota(string valNome, int idNota)
        {
            double valNota;

            do
            {
                Console.Write("{0}ª Nota do Aluno {1}: ", idNota, valNome);
                valNota = Convert.ToDouble(Console.ReadLine());
                if (valNota > 10 || valNota < 0)
                {
                    Console.Write("\nValor Inválido - Insira Novamente\n\n");
                }
            } while (valNota > 10 || valNota < 0);

            return valNota;
        }
        static double calculaMedia(int idNota,double[,] mtrNotas)
        {
            double somanotas = 0, mediaNotas;
            for(int i = 0; i < mtrNotas.GetLength(1); i++)
            {
                somanotas += mtrNotas[idNota, i];
            }
            mediaNotas = somanotas / mtrNotas.GetLength(1);
            return mediaNotas;
        }
        static void exibaRelatorio(string[] valAlunos, double[] valMedia, double[,] valNotas)
        {
            Console.WriteLine("Relatório das Notas");
            for (int i = 0; i < valAlunos.Length; i++)
            {
                if (valMedia[i] >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("\nNome do Aluno: {0}",valAlunos[i]);

                for (int j = 0; j < valNotas.GetLength(1); j++)
                {
                    Console.WriteLine("{0}ª Nota -> {1:N}", j+1, valNotas[i, j]);
                }

                Console.WriteLine("Média do aluno -> {0:N}",valMedia[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}