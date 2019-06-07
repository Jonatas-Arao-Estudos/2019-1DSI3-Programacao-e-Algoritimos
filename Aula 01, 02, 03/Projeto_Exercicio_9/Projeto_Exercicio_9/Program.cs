using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Insira sua cidade: ");
            cidade = Console.ReadLine();
            Console.Write("Insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nome+" você mora em "+cidade+" e você tem "+idade+" anos de idade");
            Console.ReadLine();


        }
    }
}
