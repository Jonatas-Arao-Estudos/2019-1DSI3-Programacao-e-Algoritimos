using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, y;
            Console.Write("Escreva seu nome: ");
            x = Console.ReadLine();
            Console.Write("Escreva o nome do seu amor: ");
            y = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Seu Nome = {0}",x.ToUpper());
            Console.WriteLine("Seu Amor = {0}",y.ToUpper());
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Seu Nome = {0}", x.Length);
            Console.WriteLine("Seu Amor = {0}", y.Length);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Seu Nome = {0}", x.Substring(0,3));
            Console.WriteLine("Seu Amor = {0}", y.Substring(0,3));
            Console.ReadKey();
        }
    }
}
