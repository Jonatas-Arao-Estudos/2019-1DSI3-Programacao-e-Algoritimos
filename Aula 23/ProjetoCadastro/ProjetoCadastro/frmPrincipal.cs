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
        public static Usuario[] usuario = new Usuario[10];
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }
    }
}
