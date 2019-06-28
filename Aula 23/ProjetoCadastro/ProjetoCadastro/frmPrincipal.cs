using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class frmPrincipal : Form
    {
        public static int contusu = 0, contcli = 0, contforn = 0;
        public struct Usuario
        {
            public int cd_usuario;
            public string nm_usuario, sg_nivel, nm_login, ds_senha;
        }
        public struct Cliente
        {
            public int cd_cliente;
            public string nm_cliente, sg_nivel, nm_login, ds_senha;
        }
        public struct Fornecedor
        {
            public int cd_fornecedor;
            public string nm_fornecedor, sg_nivel, nm_login, ds_senha;
        }

        public static Usuario[] usuario = new Usuario[10];
        public static Cliente[] cliente = new Cliente[10];
        public static Fornecedor[] fornecedor = new Fornecedor[10];

        private void pdcUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados = "";
            int pag = 0, i = 0, lin = 0;
            bool cab = true, det = true;
            while (cab)
            {
                pag++;
                strDados += "Listagem de Usuários\n";
                strDados += "Página: " + pag.ToString() + "                                                                 ARSOFT\n";
                strDados += "--------------------------------------------------------------------------------\n";
                strDados += "Código Nome                                     Nível Login               \n";
                strDados += "--------------------------------------------------------------------------------\n";
                lin = 5;
                det = true;
                while (det)
                {
                    strDados += usuario[i].cd_usuario.ToString("000000") + " " + (usuario[i].nm_usuario + "                                        ").Substring(0, 40) + "   " + usuario[i].sg_nivel + "   " + usuario[i].nm_login + "\n";
                    i++;
                    lin++;
                    if(lin >= 66)
                    {
                        det = false;
                    }
                    if(i>= contusu)
                    {
                        det = false;
                        cab = false;
                    }
                    strDados += (char)12;
                }
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdUsuario.ShowDialog();
        }

        private void pdcCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados = "";
            int pag = 0, i = 0, lin = 0;
            bool cab = true, det = true;
            while (cab)
            {
                pag++;
                strDados += "Listagem de Clientes\n";
                strDados += "Página: " + pag.ToString() + "                                                                 ARSOFT\n";
                strDados += "--------------------------------------------------------------------------------\n";
                strDados += "Código Nome                                     Nível Login               \n";
                strDados += "--------------------------------------------------------------------------------\n";
                lin = 5;
                det = true;
                while (det)
                {
                    strDados += cliente[i].cd_cliente.ToString("000000") + " " + (cliente[i].nm_cliente + "                                        ").Substring(0, 40) + "   " + cliente[i].sg_nivel + "   " + cliente[i].nm_login + "\n";
                    i++;
                    lin++;
                    if (lin >= 66)
                    {
                        det = false;
                    }
                    if (i >= contcli)
                    {
                        det = false;
                        cab = false;
                    }
                    strDados += (char)12;
                }
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdCliente.ShowDialog();
        }

        private void pdcFornecedor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados = "";
            int pag = 0, i = 0, lin = 0;
            bool cab = true, det = true;
            while (cab)
            {
                pag++;
                strDados += "Listagem de Fornecedores\n";
                strDados += "Página: " + pag.ToString() + "                                                                 ARSOFT\n";
                strDados += "--------------------------------------------------------------------------------\n";
                strDados += "Código Nome                                     Nível Login               \n";
                strDados += "--------------------------------------------------------------------------------\n";
                lin = 5;
                det = true;
                while (det)
                {
                    strDados += fornecedor[i].cd_fornecedor.ToString("000000") + " " + (fornecedor[i].nm_fornecedor + "                                        ").Substring(0, 40) + "   " + fornecedor[i].sg_nivel + "   " + fornecedor[i].nm_login + "\n";
                    i++;
                    lin++;
                    if (lin >= 66)
                    {
                        det = false;
                    }
                    if (i >= contforn)
                    {
                        det = false;
                        cab = false;
                    }
                    strDados += (char)12;
                }
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdFornecedor.ShowDialog();
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fu = new frmCliente();
            fu.ShowDialog();
        }
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor fu = new frmFornecedor();
            fu.ShowDialog();
        }
    }
}
