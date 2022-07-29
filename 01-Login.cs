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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente sair?","Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Clear();
                txtSenha.Clear();
                txtSenha.Enabled = false;
                txtEmail.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // centralizar o painel

            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width / 2, this.Height / 2 - pnlLogin.Height / 2);

            txtSenha.Enabled = false;
            btnEntrar.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                txtSenha.Enabled = true;
            }
            else
            {
                txtSenha.Enabled = false;
                txtSenha.Clear();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Variaveis.usuario = txtEmail.Text;
            Variaveis.senha = txtSenha.Text;

            if (Variaveis.usuario == "Patrick" && Variaveis.senha == "1234")
            {
                Variaveis.nivel = "ADMINISTRADOR";

                new frmMenu().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado");
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }

        }
    }
}
