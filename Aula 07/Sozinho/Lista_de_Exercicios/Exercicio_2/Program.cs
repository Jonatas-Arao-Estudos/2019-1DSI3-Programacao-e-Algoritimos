﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Insira um número qualquer: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O dobro de {0} é {1}", x, 2 * x);
            Console.ReadKey();
        }
    }
}
