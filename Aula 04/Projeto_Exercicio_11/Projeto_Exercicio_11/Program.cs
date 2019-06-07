using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, ano, now;
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Insira o ano de seu nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine();
            idade = 2019 - ano;

            if (idade < 18)
            {
                Console.WriteLine("Então você é Muleke Loko e Jovem Dinamico, ");
            }
            else
            {
                Console.WriteLine("Legal você já pode ser preso!");
            }

            Console.WriteLine();
            Console.WriteLine("Seu nome é " + nome + " e você tem " + idade + " anos de idade");
            Console.ReadKey();
        }
    }
}
