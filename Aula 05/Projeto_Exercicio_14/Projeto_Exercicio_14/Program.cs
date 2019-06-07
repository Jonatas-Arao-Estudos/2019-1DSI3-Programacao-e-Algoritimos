using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.Write("Digite seu ano de nascimento para saber se você pode votar: ");
            ano = Convert.ToInt32(Console.ReadLine());
            if (2019-ano>=16)
            {
                Console.WriteLine("Você já pode votar.");
            }
            else
            {
                Console.WriteLine("Você ainda não pode votar.");
            }
            Console.ReadKey();
        }
    }
}
