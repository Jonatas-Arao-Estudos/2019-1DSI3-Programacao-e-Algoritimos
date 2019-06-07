using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string mone;
            int ano;
            void mostrarNome(string nome)
            {
                Console.WriteLine("Nome: {0}",nome);
            }

            int calcularIdade(int anoNasci)
            {
                return 2019 - anoNasci;
            }

            Console.WriteLine("Digite seu mone: ");
            mone = Console.ReadLine();
            Console.WriteLine("Digite sua data de nascimento: ");
            ano = int.Parse (Console.ReadLine());

            mostrarNome(mone);
            Console.WriteLine("Idade: {0}", calcularIdade(ano));
            Console.ReadKey();
        }
    }
}
