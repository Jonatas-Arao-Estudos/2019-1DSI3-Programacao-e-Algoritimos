using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, ano;
            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o ano de seu nascimento: ");
            ano = Convert.ToInt32(Console.ReadLine());
            idade = 2019 - ano;
            Console.WriteLine("Seu nome é " + nome + " e você tem " + idade + " anos de idade");
            Console.ReadKey();
        }
    }
}
