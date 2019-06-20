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
    public partial class frmUsuario : Form
    {
        int atual = 0;
        char flagCad;
        private void Habilita()
        {
            txtNome.Enabled = true;
            txtNivel.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void Desabilita()
        {
            txtNome.Enabled = false;
            txtNivel.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.contusu < 10)
            {
                Habilita();
                txtCodigo.Text = (frmPrincipal.contusu + 1).ToString();
                txtNome.Text = "";
                txtNivel.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
                flagCad = 'N';
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.contusu > 0)
            {
                Habilita();
                txtNome.Focus();
                flagCad = 'A';
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Desabilita();
            Mostra();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            if (flagCad == 'N')
            {
                frmPrincipal.usuario[frmPrincipal.contusu].cd_usuario = int.Parse(txtCodigo.Text);
                frmPrincipal.usuario[frmPrincipal.contusu].nm_usuario = txtNome.Text;
                frmPrincipal.usuario[frmPrincipal.contusu].sg_nivel = txtNivel.Text;
                frmPrincipal.usuario[frmPrincipal.contusu].nm_login = txtLogin.Text;
                frmPrincipal.usuario[frmPrincipal.contusu].ds_senha = txtSenha.Text;
                atual = frmPrincipal.contusu++;
            }
            else
            {
                frmPrincipal.usuario[atual].cd_usuario = int.Parse(txtCodigo.Text);
                frmPrincipal.usuario[atual].nm_usuario = txtNome.Text;
                frmPrincipal.usuario[atual].sg_nivel = txtNivel.Text;
                frmPrincipal.usuario[atual].nm_login = txtLogin.Text;
                frmPrincipal.usuario[atual].ds_senha = txtSenha.Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Mostra();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                Mostra();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < frmPrincipal.contusu - 1)
            {
                atual++;
                Mostra();
            }
        }
        private void Mostra()
        {
            txtCodigo.Text = frmPrincipal.usuario[atual].cd_usuario.ToString();
            txtNome.Text = frmPrincipal.usuario[atual].nm_usuario;
            txtNivel.Text = frmPrincipal.usuario[atual].sg_nivel;
            txtLogin.Text = frmPrincipal.usuario[atual].nm_login;
            txtSenha.Text = frmPrincipal.usuario[atual].ds_senha;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmPrincipal.usuario[atual].nm_usuario = "";
            frmPrincipal.usuario[atual].sg_nivel = "";
            frmPrincipal.usuario[atual].nm_login = "";
            frmPrincipal.usuario[atual].ds_senha = "";
            Mostra();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
        }

        private void btnSairPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i;
            if (txtPesquisa.Text != "")
            {
                for(i=0; i < frmPrincipal.contusu; i++)
                {
                    if (frmPrincipal.usuario[i].nm_usuario == txtPesquisa.Text)
                    {
                        atual = i;
                        Mostra();
                        break;
                    }
                }
                if (i >= frmPrincipal.contusu)
                {
                    MessageBox.Show("Não Encontrado");
                }
            }
            pnlPesquisa.Visible = false;
        }
    }
}
