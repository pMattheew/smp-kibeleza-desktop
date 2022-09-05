using MySql.Data.MySqlClient;
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

            if (Variaveis.usuario == "Patrick" && Variaveis.senha == "1234" || Variaveis.usuario == "1" && Variaveis.senha == "1")
            {
                Variaveis.nivel = "ADMINISTRADOR";

                new frmMenu().Show();
                Hide();
            }
            else
            {
                try
                {
                    banco.Conectar();

                    string selecionar = "SELECT nomeFuncionario,emailFuncionario,senhaFuncionario,nivelFuncionario FROM funcionario WHERE emailFuncionario=@email AND senhaFuncionario=@senha AND statusFuncionario=@status";

                    MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                    cmd.Parameters.AddWithValue("@email", Variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Variaveis.usuario = reader.GetString(0);
                        Variaveis.nivel = reader.GetString(1);
                        new frmMenu().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acesso negado.");
                        txtEmail.Clear();
                        txtEmail.Focus();
                        txtSenha.Clear();
                    }

                    banco.Desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados! \n\n" + ex.Message);
                }
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
                btnEntrar.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }
    }
}
