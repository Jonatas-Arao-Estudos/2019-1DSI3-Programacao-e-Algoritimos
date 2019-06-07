using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        public struct Carro
        {
            public string modelo, cor;
            public int fab_ano;
        }
        static void Main(string[] args)
        {
            const int qtd_carro = 500;
            int opcao;
            Carro[] carro = new Carro[qtd_carro];

            do
            {
                Console.WriteLine("Sistema de Cadastro de Carros\n\n1 – Cadastrar carro\n2 – Consultar carro por ano de fabricação\n3 – Consultar carro por modelo\n4 – Consultar carro por cor\n5 – Exibir todos os carros cadastrados\n6 – Alterar algum dado de um carro\n7 – Excluir um carro\n0 – Sair");
                Console.Write("\nDigite sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        carro = cadastraCarro(qtd_carro);
                        finalizar();
                        break;

                    case 2:
                        pesquisaFabAno(carro);
                        finalizar();
                        break;

                    case 3:
                        pesquisaModelo(carro);
                        finalizar();
                        break;

                    case 4:
                        pesquisaCor(carro);
                        finalizar();
                        break;

                    case 5:
                        mostraCarros(carro);
                        finalizar();
                        break;

                    case 6:
                        carro = alteraCadastro(carro);
                        finalizar();
                        break;

                    case 7:
                        carro = excluiCadastro(carro);
                        finalizar();
                        break;
                }
            } while (opcao != 0);
        }
        static Carro[] cadastraCarro(int qtd)
        {
            Carro[] cadastro = new Carro[qtd];

            Console.WriteLine("Cadastro de Carro");

            for (int i = 0; i < cadastro.Length; i++)
            {
                Console.WriteLine("\n{0}º Carro:", i + 1);
                Console.Write("Modelo: ");
                cadastro[i].modelo = Console.ReadLine();
                Console.Write("Ano de Fabricação: ");
                cadastro[i].fab_ano = int.Parse(Console.ReadLine());
                Console.Write("Cor: ");
                cadastro[i].cor = Console.ReadLine();
            }

            return cadastro;
        }
        static void pesquisaFabAno(Carro[] dados)
        {
            int pesquisa;

            Console.WriteLine("Consulta de Carro - Ano de Fabricação");
            Console.Write("\nDigite o ano de fabricação: ");
            pesquisa = int.Parse(Console.ReadLine());

            if (existePesquisa(dados, pesquisa.ToString()))
            {
                int cont = 0;
                for (int i = 0; i < dados.Length; i++)
                {
                    if (pesquisa == dados[i].fab_ano)
                    {
                        cont++;

                        Console.WriteLine("\n{0:D2} - Carro\nModelo: {1}\nAno de Fabricação: {2}\nCor: {3}", cont, dados[i].modelo, dados[i].fab_ano, dados[i].cor);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNão existe carro fabricado no ano de {0}", pesquisa);
            }
        }
        static void pesquisaModelo(Carro[] dados)
        {
            string pesquisa;

            Console.WriteLine("Consulta de Carro - Modelo");
            Console.Write("\nDigite o modelo: ");
            pesquisa = Console.ReadLine();

            if (existePesquisa(dados, pesquisa))
            {
                int cont = 0;

                for (int i = 0; i < dados.Length; i++)
                {
                    if (pesquisa == dados[i].modelo)
                    {
                        cont++;
                        Console.WriteLine("\n{0:D2} - Carro\nModelo: {1}\nAno de Fabricação: {2}\nCor: {3}", cont, dados[i].modelo, dados[i].fab_ano, dados[i].cor);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNão existe carro com modelo - {0}", pesquisa);
            }
        }
        static void pesquisaCor(Carro[] dados)
        {
            string pesquisa;

            Console.WriteLine("Consulta de Carro - Cor");
            Console.Write("\nDigite a cor: ");
            pesquisa = Console.ReadLine();

            if (existePesquisa(dados, pesquisa))
            {
                int cont = 0;

                for (int i = 0; i < dados.Length; i++)
                {
                    if (pesquisa == dados[i].cor)
                    {
                        cont++;
                        Console.WriteLine("\n{0:D2} - Carro\nModelo: {1}\nAno de Fabricação: {2}\nCor: {3}", cont, dados[i].modelo, dados[i].fab_ano, dados[i].cor);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNão existe carro com cor - {0}", pesquisa);
            }
        }
        static bool existePesquisa(Carro[] dados,string pesquisa)
        {
            bool existe = false;
            int pesquisaInt;

            try
            {
                pesquisaInt = int.Parse(pesquisa);
            }
            catch
            {
                pesquisaInt = 0;
            }

            for(int i = 0; i < dados.Length; i++)
            {
                if ((dados[i].modelo == pesquisa || dados[i].fab_ano == pesquisaInt || dados[i].cor == pesquisa)&&
                    (dados[i].modelo != null && dados[i].fab_ano != 0 && dados[i].cor != null)
                    )
                {
                    existe = true;
                }
            }

            return existe;
        }
        static void mostraCarros(Carro[] dados)
        {
            Console.WriteLine("Todos os carros cadastrados");

            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i].modelo == null && dados[i].fab_ano == 0 && dados[i].cor == null)
                {
                    Console.WriteLine("\n{0:D2} - Carro\nCampo Sem Cadastro", i + 1);
                }
                else
                {
                    Console.WriteLine("\n{0:D2} - Carro\nModelo: {1}\nAno de Fabricação: {2}\nCor: {3}", i + 1, dados[i].modelo, dados[i].fab_ano, dados[i].cor);
                }
            }
        }
        static Carro[] alteraCadastro(Carro[] dados)
        {
            int idCarro;

            Console.WriteLine("Alteração de Cadastro\n");

            mostraCarros(dados);

            Console.Write("\nDigite o número do Carro que deseja alterar a informação: ");
            idCarro = int.Parse(Console.ReadLine())-1;

            Console.WriteLine("\n{0:D2} - Carro:", idCarro+1);
            Console.Write("Modelo: ");
            dados[idCarro].modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            dados[idCarro].fab_ano = int.Parse(Console.ReadLine());
            Console.Write("Cor: ");
            dados[idCarro].cor = Console.ReadLine();

            return dados;
        }
        static Carro[] excluiCadastro(Carro[] dados)
        {
            int idCarro;
            string opcao;

            Console.WriteLine("Exclusão de Cadastro\n");

            mostraCarros(dados);

            Console.Write("\nDigite o número do Carro que deseja alterar a informação: ");
            idCarro = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();

            Console.WriteLine("Deseja excluir esse cadastro?\n");
            Console.Write("Modelo: {0}\nAno de Fabricação: {1}\nCor: {2}\n", dados[idCarro].modelo, dados[idCarro].fab_ano, dados[idCarro].cor);
            Console.Write("\nDigite S para confirmar: ");
            opcao = Console.ReadLine();

            if(opcao.ToUpper() == "S")
            {
                dados[idCarro].modelo = null;
                dados[idCarro].fab_ano = 0;
                dados[idCarro].cor = null;
            }

            return dados;
        }
        static void finalizar()
        {
            Console.Write("\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
