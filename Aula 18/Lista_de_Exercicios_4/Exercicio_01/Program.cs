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
            int[] numeros = new int[15];

            numeros = valorVetor(numeros);

            Console.WriteLine();

            exibeVetor(numeros);

            Console.ReadKey();

        }
        static int[] valorVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++) 
            {
                Console.Write("Escreva o valor no vetor {0}:\n", i);
                vet[i] = int.Parse(Console.ReadLine());
            }
            return vet;
        }
        static void exibeVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Número ({0}) registrado no vetor {1}", vet[i], i);
                }
            }
        }
    }
}
