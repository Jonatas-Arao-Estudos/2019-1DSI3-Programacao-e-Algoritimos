using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
            static void Main(string[] args)
            {
                double e, c, n, salario;
                string opcao = "";

                for (; opcao != "S";)
                {
                e = 0;
                salario = 0;

                Console.WriteLine("Insira código de funcionário:");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Insira quantidade de horas trabalhadas");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (n <= 50)
                {
                    salario = n * 10;
                }
                if (n>50)
                {
                    salario = (n - (n - 50)) * 10;
                    e = (n-50) * 20;
                }

                Console.WriteLine("Funcionário - Código: {0}", c);
                Console.WriteLine("Salário total do funcionário: R${0:N}",salario+e);
                Console.WriteLine("Salário excedente do funcionário: R${0:N}",e);

                Console.WriteLine();

                Console.WriteLine("Deseja encerrar o programa ?");
                Console.WriteLine("se Sim digite S - se não aperte Enter");
                opcao = Console.ReadLine();
                Console.Clear();
            }

            }
        
    }
}
