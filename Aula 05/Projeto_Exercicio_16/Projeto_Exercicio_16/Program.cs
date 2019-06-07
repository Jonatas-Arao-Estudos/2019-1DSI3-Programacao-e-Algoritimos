using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, ideal;
            int sexo;
            Console.WriteLine("Qual a sua altura?");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual seu sexo (sendo 1 para Feminino e 2 para Masculino): ");
            sexo=Convert.ToInt32(Console.ReadLine());
            if (sexo==1)
            {
                ideal = (62.1 * altura) - 44.7;
                Console.WriteLine("{0} kg é seu peso ideal", ideal);
            }
            else
            {
                ideal = (72.7 * altura) - 58;
                Console.WriteLine("{0} kg é seu peso ideal", ideal);
            }
            Console.ReadKey();
        }
    }
}
