using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, media;
            string nome;
            Console.WriteLine("Olá aluninho, coloque seu nome para depois inserir suas notas: ");
            nome=Console.ReadLine();
            Console.WriteLine("Coloque sua nota de Matemática: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque sua nota de Língua Portuguesa: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque sua nota de História: ");
            z = Convert.ToDouble(Console.ReadLine());
            media = (x + y + z) / 3;
            Console.WriteLine("Então aluninho, para você ser aprovado você deve ter nota maior do que 7, ");
            Console.WriteLine("aperte a qualquer tecla e descubra seu destino ");
            Console.ReadKey();
            if (media>=7)
                {
                Console.WriteLine("Parabéns "+nome+" , seu destino é a glória de deixar mais um ano para trás, ");
                Console.WriteLine("Alegre-se e conte a todos sua conquista pois você passou!");
            }
            else
            {
                Console.WriteLine("Parabéns "+nome+" , você falhou assim como Peter Quill era só acertar cabeça, ");
                Console.WriteLine("mas você deve ter acertado sua propria para falhar assim");
            }
            Console.ReadKey();
        }
    }
}
