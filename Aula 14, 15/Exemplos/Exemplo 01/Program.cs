using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            digite();
            a = int.Parse(Console.ReadLine());
            dobro(a);
            Console.WriteLine("\n\nPressione alguma tecla. ");
            Console.ReadKey();
        }
        static void digite()
        {
            Console.Write("Digite um número: ");
        }
        static void dobro(int n)
        {
            int d = n * 2;
            Console.WriteLine("Dobro de {0} = {1}", n, d);
        }
    }
}
