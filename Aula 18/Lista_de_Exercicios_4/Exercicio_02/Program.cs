using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)

        {
            int opcao;
            double pesquisa;
            const int NumProdutos = 3;
            string[] nome = new string[NumProdutos];
            double[] preco = new double[NumProdutos];

            do
            {
                Console.Write("Central de Produtos \n\n 1 - Cadastro \n 2 - Pesquisa\n 0 - Sair\n\n");
                Console.Write("Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        Console.Write("Cadastro de Produto");
                        for (int i = 0; (i < nome.Length) && (i < preco.Length); i++)
                        {
                            nome[i] = cadastraNome(i);
                            preco[i] = cadastraPreco(i);
                        }
                        Console.Write("\nClique para encerrar cadastro.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Pesquisa de Produtos");

                        pesquisa = valorPesquisa();

                        realizaPesquisa(pesquisa, preco, nome);

                        Console.Write("\n\nClique para encerrar pesquisa.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcao != 0);
        }
        static string cadastraNome(int cont)
        {
            string nomeProduto;
            Console.Write("\nNome do Produto #{0}: ", cont + 1);
            nomeProduto = Console.ReadLine();
            return nomeProduto;
        }
        static double cadastraPreco(int cont)
        {
            double precoProduto;
            Console.Write("Preço do Produto #{0}: ", cont + 1);
            precoProduto = double.Parse(Console.ReadLine());
            return precoProduto;
        }
        static double valorPesquisa()
        {
            double valPesquisa;

            Console.Write("\n\nProdutos com valor de até: R$");
            valPesquisa = double.Parse(Console.ReadLine());

            return valPesquisa;
        }
        static void realizaPesquisa(double valPesquisa, double[] valPreco, string[] valNome)
        {
            if (existePreco(valPesquisa, valPreco))
            {
                mostraPesquisa(valPesquisa, valPreco, valNome);
            }
            else
            {
                Console.Write("\nNão existe produtos com valor de até R${0}", valPesquisa);
            }
        }
        static bool existePreco(double valPesquisa,double[]valPreco)
        {
            bool existeValor = false;

            for (int i = 0; i < valPreco.Length; i++)
            {
                if ((valPreco[i] <= valPesquisa) && valPreco[i] > 0 && valPesquisa > 0)
                {
                    existeValor = true;
                }
            }

            return existeValor;
        }
        static void mostraPesquisa(double valPesquisa, double[] valPreco, string[] valNome)
        {
            Console.Write("\n\tNome\tPreço\n");
            for (int i = 0; i < valPreco.Length; i++)
            {
                if ((valPreco[i] <= valPesquisa))
                {
                    Console.Write("\t{0}\tR${1:N}\n", valNome[i], valPreco[i]);
                }
            }
        }
    }
}
