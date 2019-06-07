using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        public struct Data
        {
            public int dia, mes, ano;
        }
        static void Main(string[] args)
        {
            Data digita;

            Console.WriteLine("Digite uma data para saber se é válida");
            Console.Write("Dia: ");
            digita.dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            digita.mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            digita.ano = int.Parse(Console.ReadLine());

            if (
                (digita.dia > 31) ||
                (((digita.mes == 4) || (digita.mes == 6) || (digita.mes == 9) || (digita.mes == 11)) && digita.dia > 30) ||
                (digita.ano % 4 != 0 && digita.mes == 2 && digita.dia > 28)||
                (digita.ano % 4 == 0 && digita.mes == 2 && digita.dia > 29)
                )
            {
                Console.WriteLine("\nData Inválida");
            }
            else
            {
                Console.WriteLine("\nData Válida");
            }

            Console.Write("\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
