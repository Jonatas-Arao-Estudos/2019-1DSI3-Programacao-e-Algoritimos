using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            sbyte idade;

            Console.Write("Digite o seu nome: ");
            nome=Console.ReadLine();
            Console.Write("Digite o sua idade: ");
            idade = sbyte.Parse(Console.ReadLine());
            Console.Write("Digite a cidade onde você mora: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Seu nome é {0}", nome);
            Console.WriteLine("Sua idade é {0}", idade);
            Console.WriteLine("Você mora na cidade de {0}", cidade);

            Console.ReadKey();


        }
    }
}
