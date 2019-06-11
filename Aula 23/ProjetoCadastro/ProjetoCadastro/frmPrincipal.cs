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
        public static int contusu = 0, contli = 0, contfor = 0;
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

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
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
