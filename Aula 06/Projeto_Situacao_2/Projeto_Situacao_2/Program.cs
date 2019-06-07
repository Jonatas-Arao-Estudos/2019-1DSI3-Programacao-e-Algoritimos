using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Situacao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pova, trabezon;
            Console.WriteLine("Digite o valor da nota da prova: ");
            pova = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da nota do trabalho");
            trabezon = Convert.ToDouble(Console.ReadLine());

            if (pova>=6|trabezon>=8)
            {
                Console.WriteLine("Você passou OTARIO");
            }
            else
            {
                Console.WriteLine("Parabéns seu INUTIL, achou que ia passar, achou ERRADO OTARIO");
            }
            Console.ReadKey();
        }
    }
}
