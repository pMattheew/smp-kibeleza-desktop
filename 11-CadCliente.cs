﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaPMS
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            if (Variaveis.funcao == "ALTERAR")
            {
                lblCadCliente.Text = "ALTERAR CLIENTE";
                pnlTelefone.Enabled = true;
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmFoneCliente().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmFoneCliente().Show();
            Hide();
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                btnFoto.Focus();
            }
        }

        private void btnSalvar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            Variaveis.atFotoCliente = "S";
            btnSalvar.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            mkdDataCad.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto.BackColor = Color.FromArgb(70, 10, 45);


            if (txtNomeCliente.Text == String.Empty)
            {          
                lblNomeCliente.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o nome do cliente.");
                txtNomeCliente.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o email.");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o email.");
                txtSenha.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o status.");
                cmbStatus.Focus();
            }
            else if (mkdDataCad.Text == String.Empty)
            {
                lblDataCad.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha a data de cadastro.");
                mkdDataCad.Focus();
            }
            else if (Variaveis.atFotoCliente != "S")
            {
                lblFoto.ForeColor = Color.Red;
                MessageBox.Show("Por favor, insira uma imagem.");
                btnFoto.Focus();
            }
            else
            {
                Variaveis.nomeCliente = txtNomeCliente.Text;
                Variaveis.emailCliente = txtEmail.Text;
                Variaveis.senhaCliente = txtSenha.Text;
                Variaveis.statusCliente = cmbStatus.Text;
                mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCadCliente = DateTime.Parse(mkdDataCad.Text);
                // Variaveis.fotoCliente = "cliente/" + nomeFoto;

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            mkdDataCad.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto.BackColor = Color.FromArgb(70, 10, 45);

            txtNomeCliente.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            picFoto.Image = Properties.Resources.semimagem;

            txtNomeCliente.Focus();
        }
    }
}
