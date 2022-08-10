using System;
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
            btnSalvar.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pnlTelefone.Enabled = true;
        }
    }
}
