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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresacompleta`";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao); // gera o comando

                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // adapta para a linguagem C#

                DataTable dt = new DataTable(); // coloca os dados adaptados em um vetor

                da.Fill(dt); // enche a DataTable com os dados adaptados do db


                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa. \n\n" + ex.Message);
            }
        }
        private void CarregarEmpresaAtiva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaativa`";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao); // gera o comando

                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // adapta para a linguagem C#

                DataTable dt = new DataTable(); // coloca os dados adaptados em um vetor

                da.Fill(dt); // enche a DataTable com os dados adaptados do db


                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa. \n\n" + ex.Message);
            }
        }

        private void CarregarEmpresaNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresacompleta` WHERE `NOME DA EMPRESA` LIKE '" + Variaveis.nomeEmpresa + "%' ";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao); // gera o comando

                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // adapta para a linguagem C#

                DataTable dt = new DataTable(); // coloca os dados adaptados em um vetor

                da.Fill(dt); // enche a DataTable com os dados adaptados do db


                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa. \n\n" + ex.Message);
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(this.Width / 2 - pnlEmpresa.Width / 2, this.Height / 2 - pnlEmpresa.Height / 2);
            CarregarEmpresa();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadEmpresa().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadEmpresa().Show();
            Hide();
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                CarregarEmpresaAtiva();
            }
            else
            {
                CarregarEmpresa();
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                chkAtivo.Enabled = true;
                CarregarEmpresa();
            }
            else
            {
                chkAtivo.Checked = false;
                chkAtivo.Enabled = false;
                Variaveis.nomeEmpresa = txtNome.Text;
                CarregarEmpresaNome();
            }
        }
    }
}
