using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Area, Base, Altura;
            Console.WriteLine("Geometria - Área do Quadrilátero");
            Console.WriteLine("Para o cálculo da área de qualquer quadrilátero deve-se multiplicar a base e a altura");
            Console.WriteLine("Para demonstração, insira o valor da base que desejar");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora insira o valor da altura");
            Altura = Convert.ToDouble(Console.ReadLine());
            Area = Base * Altura;
            Console.WriteLine("Sendo assim, um quadrilátero de base "+ Base + " e altura "+ Altura + " tem a área de "+Area);
            Console.ReadKey();
        }
    }
}
