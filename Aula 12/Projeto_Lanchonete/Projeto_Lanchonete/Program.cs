using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            int opprim, oplanc, opbeb, qt_hamb = 0, qt_xbur = 0, qt_xegg = 0, qt_baur = 0, qt_coca = 0, qt_guar = 0, qt_itub = 0, qt_soda = 0, qt_fanta = 0;
            double vl_hamb = 5, vl_xbur = 7, vl_xegg = 10, vl_baur = 3, vl_coca = 5, vl_guar = 4, vl_itub = 3, vl_soda = 4, vl_fanta = 5;
            do
            {
                Console.Write("Lanchonete \n\n 1 - Lanches \n 2 - Bebidas \n 3 - Conta\n 0 - Sair\n\n");
                Console.Write("Digite sua Escolha: ");
                opprim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opprim)
                {
                    case 1:
                        do
                        {
                            Console.Write("Lanches \n\n 1 - Hamburguer - R${0:N} - Qtd:{1}\n 2 - X-Burguer - R${2:N} - Qtd:{3}\n 3 - X-Egg - R${4:N} - Qtd:{5}\n 4 - Bauru - R${6:N} - Qtd:{7}\n 0 - Sair\n\n", vl_hamb, qt_hamb, vl_xbur, qt_xbur, vl_xegg, qt_xegg, vl_baur, qt_baur);
                            Console.Write("Digite sua Escolha: ");
                            oplanc = Convert.ToInt32(Console.ReadLine());
                            switch (oplanc)
                            {
                                case 1:
                                    qt_hamb++;
                                    break;
                                case 2:
                                    qt_xbur++;
                                    break;
                                case 3:
                                    qt_xegg++;
                                    break;
                                case 4:
                                    qt_baur++;
                                    break;
                            }
                            Console.Clear();
                        } while (oplanc != 0);
                        break;

                    case 2:
                        do
                        {
                            Console.Write("Bebidas \n\n 1 - Coca-Cola - R${0:N} - Qtd:{1}\n 2 - Guaraná - R${2:N} - Qtd:{3}\n 3 - Itubaína - R${4:N} - Qtd:{5}\n 4 - Soda Limonada - R${6:N} - Qtd:{7}\n 5 - Fanta - R${8:N} - Qtd:{9}\n 0 - Sair\n\n", vl_coca, qt_coca, vl_guar, qt_guar, vl_itub, qt_itub, vl_soda, qt_soda, vl_fanta, qt_fanta);
                            Console.Write("Digite sua Escolha: ");
                            opbeb = Convert.ToInt32(Console.ReadLine());
                            switch (opbeb)
                            {
                                case 1:
                                    qt_coca++;
                                    break;
                                case 2:
                                    qt_guar++;
                                    break;
                                case 3:
                                    qt_itub++;
                                    break;
                                case 4:
                                    qt_soda++;
                                    break;
                                case 5:
                                    qt_fanta++;
                                    break;
                            }
                            Console.Clear();
                        } while (opbeb != 0);
                        break;

                    case 3:
                        Console.Write("Contas \n\n");
                        if (qt_hamb > 0)
                        {
                            Console.Write("Qtd:{0} - Hamburguer - R${1:N}\n", qt_hamb, qt_hamb * vl_hamb);
                        }
                        if (qt_xbur > 0)
                        {
                            Console.Write("Qtd:{0} - X-Burguer - R${1:N}\n", qt_xbur, qt_xbur * vl_xbur);
                        }
                        if (qt_xegg > 0)
                        {
                            Console.Write("Qtd:{0} - X-Egg - R${1:N}\n", qt_xegg, qt_xegg * vl_xegg);
                        }
                        if (qt_baur > 0)
                        {
                            Console.Write("Qtd:{0} - Bauru - R${1:N}\n", qt_baur, qt_baur * vl_baur);
                        }
                        if (qt_coca > 0)
                        {
                            Console.Write("Qtd:{0} - Coca-Cola - R${1:N}\n", qt_coca, qt_coca * vl_coca);
                        }
                        if (qt_guar > 0)
                        {
                            Console.Write("Qtd:{0} - Guaraná - R${1:N}\n", qt_guar, qt_guar * vl_guar);
                        }
                        if (qt_itub > 0)
                        {
                            Console.Write("Qtd:{0} - Itubaína - R${1:N}\n", qt_itub, qt_itub * vl_itub);
                        }
                        if (qt_soda > 0)
                        {
                            Console.Write("Qtd:{0} - Soda Limonada - R${1:N}\n", qt_soda, qt_soda * vl_soda);
                        }
                        if (qt_fanta > 0)
                        {
                            Console.WriteLine("Qtd:{0} - Fanta - R${1:N}\n", qt_fanta, qt_fanta * vl_fanta);
                        }
                        Console.WriteLine("Total - R${0:N}", (qt_hamb * vl_hamb) + (qt_xbur * vl_xbur) + (qt_xegg * vl_xegg) + (qt_baur * vl_baur) + (qt_coca * vl_coca) + (qt_guar * vl_guar) + (qt_itub * vl_itub) + (qt_soda * vl_soda) + (qt_fanta * vl_fanta));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opprim != 0);
        }
    }
}
