using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int vl_usuario;
            double res_fat;

            Console.WriteLine("Digite um número para saber seu fatorial: ");
            vl_usuario = int.Parse(Console.ReadLine());
            while(vl_usuario<0)
            {
                Console.WriteLine("\nNúmero Inválido - Não existe fatorial de número negativo");
                Console.WriteLine("Digite outro número: ");
                vl_usuario = int.Parse(Console.ReadLine());
            }

            res_fat = calcularFatorial(vl_usuario);
            Console.Write("\nO fatorial de {0} é igual a {1}", vl_usuario, res_fat);

            Console.ReadKey();
        }
        static double calcularFatorial(int n)
        {
            double ft;
            for (ft = 1; n >= 1; n--) 
            {
                ft = ft * n;
            }
            return ft;
        }
    }
}
