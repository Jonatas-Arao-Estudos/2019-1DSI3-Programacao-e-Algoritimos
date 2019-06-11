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
    public partial class frmFornecedor : Form
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
        public frmFornecedor()
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
        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            Desabilita();
            Mostra();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            if (flagCad == 'N')
            {
                frmPrincipal.fornecedor[frmPrincipal.contusu].cd_fornecedor = int.Parse(txtCodigo.Text);
                frmPrincipal.fornecedor[frmPrincipal.contusu].nm_fornecedor = txtNome.Text;
                frmPrincipal.fornecedor[frmPrincipal.contusu].sg_nivel = txtNivel.Text;
                frmPrincipal.fornecedor[frmPrincipal.contusu].nm_login = txtLogin.Text;
                frmPrincipal.fornecedor[frmPrincipal.contusu].ds_senha = txtSenha.Text;
                atual = frmPrincipal.contusu++;
            }
            else
            {
                frmPrincipal.fornecedor[atual].cd_fornecedor = int.Parse(txtCodigo.Text);
                frmPrincipal.fornecedor[atual].nm_fornecedor = txtNome.Text;
                frmPrincipal.fornecedor[atual].sg_nivel = txtNivel.Text;
                frmPrincipal.fornecedor[atual].nm_login = txtLogin.Text;
                frmPrincipal.fornecedor[atual].ds_senha = txtSenha.Text;
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
            txtCodigo.Text = frmPrincipal.fornecedor[atual].cd_fornecedor.ToString();
            txtNome.Text = frmPrincipal.fornecedor[atual].nm_fornecedor;
            txtNivel.Text = frmPrincipal.fornecedor[atual].sg_nivel;
            txtLogin.Text = frmPrincipal.fornecedor[atual].nm_login;
            txtSenha.Text = frmPrincipal.fornecedor[atual].ds_senha;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmPrincipal.fornecedor[atual].nm_fornecedor = "";
            frmPrincipal.fornecedor[atual].sg_nivel = "";
            frmPrincipal.fornecedor[atual].nm_login = "";
            frmPrincipal.fornecedor[atual].ds_senha = "";
            Mostra();
        }
    }
}
