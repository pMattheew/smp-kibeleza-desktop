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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void CarregarReserva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `reservacompleta` WHERE 'CLIENTE' LIKE '%" + Variaveis.nomeCliente + "%' AND 'FUNCIONARIO' LIKE '%" + Variaveis.nomeFuncionario + "%' ";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao); // gera o comando

                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // adapta para a linguagem C#

                DataTable dt = new DataTable(); // coloca os dados adaptados em um vetor

                da.Fill(dt); // enche a DataTable com os dados adaptados do db


                dgvMenu.DataSource = dt;

                dgvMenu.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa. \n\n" + ex.Message);
            }
        }
        private void CarregarReservaStatus()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `reservacompleta` WHERE 'STATUS' = @status AND 'CLIENTE' LIKE '%" + Variaveis.nomeCliente + "%' AND 'FUNCIONARIO' LIKE '%" + Variaveis.nomeFuncionario + "%' ";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao); // gera o comando

                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // adapta para a linguagem C#

                DataTable dt = new DataTable(); // coloca os dados adaptados em um vetor

                da.Fill(dt); // enche a DataTable com os dados adaptados do db


                dgvMenu.DataSource = dt;

                dgvMenu.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa. \n\n" + ex.Message);
            }
        }
        private void AlterarStatus()
        {
            try
            {
                banco.Conectar();
                string selecionar = "UPDATE reserva SET statusReserva=@status WHERE idReserva=@codigo;";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao); // gera o comando

                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // adapta para a linguagem C#

                DataTable dt = new DataTable(); // coloca os dados adaptados em um vetor

                da.Fill(dt); // enche a DataTable com os dados adaptados do db


                dgvMenu.DataSource = dt;

                dgvMenu.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa. \n\n" + ex.Message);
            }
        }

        private void Atribuir()
        {
            Variaveis.statusReserva = cmbStatus.Text;
            Variaveis.nomeCliente = txtCliente.Text;
            Variaveis.nomeFuncionario = txtFuncionario.Text;
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            // centralizar o painel
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);

            lblUsuario.Text = Variaveis.usuario + ", bem-vindo!";

            cmbStatus.SelectedIndex = -1;

            timer1.Start();

            Variaveis.linhaSelecionada = -1;

            CarregarReserva();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você deseja sair do painel de controle?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                new frmLogin().Show();
                Close();
            }
        }

        private void picEmpresa_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }

        private void picCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void picServico_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }

        private void picFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void picRelatorio_Click(object sender, EventArgs e)
        {
            new frmRelatorio().Show();
            Hide();
        }

        private void picContato_Click(object sender, EventArgs e)
        {
            new frmContato().Show();
            Hide();
        }

        private void picEmail_Click(object sender, EventArgs e)
        {
            new frmEmail().Show();
            Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadEmpresa().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para editar selecione uma linha.");
            }

            Variaveis.funcao = "EDITAR";
            new frmCadReserva().Show();
            Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "AGENDAR";
            new frmCadReserva().Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaFoneSelecionada = int.Parse(e.RowIndex.ToString());

            if (Variaveis.linhaFoneSelecionada >= 0)
            {
                Variaveis.codReserva = Convert.ToInt32(dgvMenu[0, Variaveis.linhaFoneSelecionada].Value);
            }
        }

        private void dgvMenu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvMenu.Sort(dgvMenu.Columns[1], ListSortDirection.Ascending); // ao clicar no cabeçalho da coluna, obrigar a ordenar pela coluna 1 (nomeEmpresa)
            dgvMenu.ClearSelection();
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                txtCliente.Enabled = true;
            }
            else
            {
                txtCliente.Clear();
                txtCliente.Enabled = false;
            }
        }

        private void chkFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFuncionario.Checked)
            {
                txtFuncionario.Enabled = true;
            }
            else
            {
                txtFuncionario.Clear();
                txtFuncionario.Enabled = false;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Atribuir();
            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            Atribuir();
            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atribuir();
            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            Variaveis.statusCliente = "APROVADA";
            AlterarStatus();
            Atribuir();

            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Variaveis.statusCliente = "CANCELADA";
            AlterarStatus();
            Atribuir();

            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Variaveis.statusCliente = "FINALIZADA";
            AlterarStatus();
            Atribuir();

            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnAguardar_Click(object sender, EventArgs e)
        {
            Variaveis.statusCliente = "AGUARDANDO";
            AlterarStatus();
            Atribuir();

            if (Variaveis.statusCliente == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }
    }
}
