using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte idade;

            Console.WriteLine("Digite sua idade para saber se você é maior de idade:");
            idade = sbyte.Parse(Console.ReadLine());
            Console.WriteLine(idade > 18 ? "Você é maior de idade":"Você é menor de idade");

            Console.ReadKey();
        }
    }
}
