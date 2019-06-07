using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mone;
            void mostrarNome(string nome)
            {
                Console.WriteLine("Nome: {0}", nome);
            }

                int calcularIdade(int anoNasci)
            {
                return 2019 - anoNasci;
            }

            Console.WriteLine("Digite seu mone: ");
            mone = Console.ReadLine();

            mostrarNome(mone);
            calcularIdade(2001);
            Console.ReadKey();
        }
    }
}
