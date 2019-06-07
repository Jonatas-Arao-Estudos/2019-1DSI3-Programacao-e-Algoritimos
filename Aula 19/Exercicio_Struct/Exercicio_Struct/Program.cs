using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Struct
{
    class Program
    {
        public struct Notas
        {
            public string nome;
            public string situacao;
            public double nota1;
            public double nota2;
            public double media;
        }
        static void Main(string[] args)
        {
            int i,opcao;
            Notas[] nota = new Notas[3];

            do
            {
                Console.WriteLine("Sistema de Notas");
                Console.Write("\n1 - Cadastrar\n2 - Consultar\n0 - Sair\n");
                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastro de Notas e Alunos\n");
                        for (i = 0; i < nota.Length; i++)
                        {
                            Console.Write("Nome do Aluno : ");
                            nota[i].nome = Console.ReadLine();

                            do
                            {
                                Console.Write("1ª Nota do Aluno : ");
                                nota[i].nota1 = double.Parse(Console.ReadLine());
                                if (nota[i].nota1 > 10 || nota[i].nota1 < 0)
                                {
                                    Console.WriteLine("Nota Inválida - Insira Novamente\n");
                                }
                            } while (nota[i].nota1 > 10 || nota[i].nota1 < 0);

                            do
                            {
                                Console.Write("2ª Nota do Aluno : ");
                                nota[i].nota2 = double.Parse(Console.ReadLine());
                                if (nota[i].nota2 > 10 || nota[i].nota2 < 0)
                                {
                                    Console.WriteLine("Nota Inválida - Insira Novamente\n");
                                }
                            } while (nota[i].nota2 > 10 || nota[i].nota2 < 0);

                            nota[i].media = (nota[i].nota1 + nota[i].nota2) / 2;
                            if (nota[i].media >= 7)
                            {
                                nota[i].situacao = "Aprovado";
                            }
                            else
                            {
                                nota[i].situacao = "Reprovado";
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Clique para voltar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Relatório de Notas\n");
                        for (i = 0; i < nota.Length; i++)
                        {
                            Console.Write("Nome do Aluno: {0}\n Nota 1: {1}\n Nota 2: {2}\n Média: {3}\n Situação: {4}\n", nota[i].nome, nota[i].nota1, nota[i].nota2, nota[i].media, nota[i].situacao);
                            Console.WriteLine();
                        }
                        Console.Write("Clique para voltar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
