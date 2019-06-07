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
            const int qtdNotas = 15;
            Notas[] nota = new Notas[qtdNotas];

            nota = cadastraNotas(qtdNotas);
            Console.Write("Pressione qualquer tecla para ver relatório.");
            Console.ReadKey();
            Console.Clear();

            mostraRelatorio(nota);
            Console.Write("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
        static Notas[] cadastraNotas(int qtd)
        {
            Notas[] cadastro = new Notas[qtd];

            Console.WriteLine("Cadastro de Notas e Alunos\n");
            for (int i = 0; i < cadastro.Length; i++)
            {
                Console.Write("Nome do Aluno : ");
                cadastro[i].nome = Console.ReadLine();

                do
                {
                    Console.Write("1ª Nota do Aluno : ");
                    cadastro[i].nota1 = double.Parse(Console.ReadLine());
                    if (cadastro[i].nota1 > 10 || cadastro[i].nota1 < 0)
                    {
                        Console.WriteLine("Nota Inválida - Insira Novamente\n");
                    }
                } while (cadastro[i].nota1 > 10 || cadastro[i].nota1 < 0);

                do
                {
                    Console.Write("2ª Nota do Aluno : ");
                    cadastro[i].nota2 = double.Parse(Console.ReadLine());
                    if (cadastro[i].nota2 > 10 || cadastro[i].nota2 < 0)
                    {
                        Console.WriteLine("Nota Inválida - Insira Novamente\n");
                    }
                } while (cadastro[i].nota2 > 10 || cadastro[i].nota2 < 0);

                cadastro[i].media = (cadastro[i].nota1 + cadastro[i].nota2) / 2;
                if (cadastro[i].media >= 7)
                {
                    cadastro[i].situacao = "Aprovado";
                }
                else
                {
                    cadastro[i].situacao = "Reprovado";
                }
                Console.WriteLine();
            }

            return cadastro;
        }
        static void mostraRelatorio(Notas[] dados)
        {
            Console.WriteLine("Relatório de Notas\n");
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i].situacao == "Aprovado")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("Nome do Aluno: {0}\n Nota 1: {1}\n Nota 2: {2}\n Média: {3}\n Situação: {4}\n", dados[i].nome, dados[i].nota1, dados[i].nota2, dados[i].media, dados[i].situacao);
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
