﻿using System;
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
    public partial class frmCliente : Form
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
        public frmCliente()
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Desabilita();
            Mostra();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            if (flagCad == 'N')
            {
                frmPrincipal.cliente[frmPrincipal.contusu].cd_cliente = int.Parse(txtCodigo.Text);
                frmPrincipal.cliente[frmPrincipal.contusu].nm_cliente = txtNome.Text;
                frmPrincipal.cliente[frmPrincipal.contusu].sg_nivel = txtNivel.Text;
                frmPrincipal.cliente[frmPrincipal.contusu].nm_login = txtLogin.Text;
                frmPrincipal.cliente[frmPrincipal.contusu].ds_senha = txtSenha.Text;
                atual = frmPrincipal.contusu++;
            }
            else
            {
                frmPrincipal.cliente[atual].cd_cliente = int.Parse(txtCodigo.Text);
                frmPrincipal.cliente[atual].nm_cliente = txtNome.Text;
                frmPrincipal.cliente[atual].sg_nivel = txtNivel.Text;
                frmPrincipal.cliente[atual].nm_login = txtLogin.Text;
                frmPrincipal.cliente[atual].ds_senha = txtSenha.Text;
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
            txtCodigo.Text = frmPrincipal.cliente[atual].cd_cliente.ToString();
            txtNome.Text = frmPrincipal.cliente[atual].nm_cliente;
            txtNivel.Text = frmPrincipal.cliente[atual].sg_nivel;
            txtLogin.Text = frmPrincipal.cliente[atual].nm_login;
            txtSenha.Text = frmPrincipal.cliente[atual].ds_senha;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmPrincipal.cliente[atual].nm_cliente = "";
            frmPrincipal.cliente[atual].sg_nivel = "";
            frmPrincipal.cliente[atual].nm_login = "";
            frmPrincipal.cliente[atual].ds_senha = "";
            Mostra();
        }
    }
}
