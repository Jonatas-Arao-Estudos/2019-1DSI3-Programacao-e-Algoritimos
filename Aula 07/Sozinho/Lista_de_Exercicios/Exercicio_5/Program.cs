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
            Console.Write("Insira quantos anos você tem para saber se ja é maior de idade: ");
            idade = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(idade >= 18 ? "Você é maior de idade" : "Você não é maior de idade, ou seja é menor de idade");
            Console.ReadKey();
        }
    }
}
