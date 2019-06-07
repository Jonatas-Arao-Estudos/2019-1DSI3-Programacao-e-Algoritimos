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
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = Convert.ToSByte(Console.ReadLine());
            Console.Write("Digite o nome da cidade onde mora: ");
            cidade = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Seu nome é {0}",nome);
            Console.WriteLine("Você tem {0} anos de idade",idade);
            Console.WriteLine("Você mora em {0}",cidade);
            Console.ReadKey();
        }
    }
}
