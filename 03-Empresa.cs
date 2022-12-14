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

        private void ExcluirEmpresa()
        {
            try
            {
                banco.Conectar();

                string excluir = "DELETE FROM `empresa` WHERE `idEmpresa`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;
                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir empresa!\n\n" + ex, "ERRO");
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
            Variaveis.linhaSelecionada = -1;
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
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadEmpresa().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha.");
            }
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

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());

            if(Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codEmpresa = Convert.ToInt32(dgvEmpresa[0, Variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvEmpresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEmpresa.Sort(dgvEmpresa.Columns[1], ListSortDirection.Ascending); // ao clicar no cabeçalho da coluna, obrigar a ordenar pela coluna 1 (nomeEmpresa)
            dgvEmpresa.ClearSelection(); // limpar coluna&linha selecionada
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirEmpresa();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha.");
            }
        }
    }
}
