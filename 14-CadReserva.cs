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
    public partial class frmCadReserva : Form
    {
        string anoI, mesI, diaI, anoF, mesF, diaF;

        

        public frmCadReserva()
        {
            InitializeComponent();
        }
        public void InserirReserva()
        {
            try
            {
                banco.Conectar();

                string inserir = "INSERT INTO `reserva`(`idReserva`, `obsReserva`, `dataReserva`, `horaReserva`, `statusReserva`, `idFuncionario`, `idCliente`, `idServico`) VALUES (DEFAULT,@obs,@dataReserva,@horaReserva,@status,@codFuncionario,@codCliente,@codServico)";

                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", Variaveis.obs);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", Variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", Variaveis.codServico);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Reserva cadastrada com sucesso!", "CADASTRO DA RESERVA");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a reserva!\n\n" + ex.Message, "Erro.");
            }
        }
        public void AlterarReserva()
        {
            try
            {
                banco.Conectar();

                string alterar = "UPDATE `reserva` SET `obsReserva`=@obs,`dataReserva`=@dataReserva,`horaReserva`=@horaReserva,`statusReserva`=@status,`idFuncionario`=@codFuncionario,`idCliente`=@codCliente,`idServico`=@codServico WHERE idReserva=@codReserva";

                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", Variaveis.obs);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", Variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", Variaveis.codServico);
                cmd.Parameters.AddWithValue("@codReserva", Variaveis.codReserva);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Reserva alterada com sucesso!", "ALTERAÇÃO DA RESERVA");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a reserva!\n\n" + ex.Message, "Erro.");
            }
        }
        public void CarregarDadosReserva()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT `idReserva`, `obsReserva`, `dataReserva`, `horaReserva`, `statusReserva`, `nomeFuncionario`, `nomeCliente`, `nomeServico` FROM `reserva` INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON cliente.idCliente = reserva.idCliente INNER JOIN servico ON servico.idServico = reserva.idServico WHERE idReserva=@codigo";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codReserva", Variaveis.codReserva);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.obs = reader.GetString(1);
                    Variaveis.dataReserva = reader.GetDateTime(2);
                    Variaveis.horarioReserva = DateTime.Parse(reader.GetString(3));
                    Variaveis.statusReserva = reader.GetString(4);
                    Variaveis.nomeFuncionario = reader.GetString(5);
                    Variaveis.nomeCliente = reader.GetString(6);
                    Variaveis.nomeServico = reader.GetString(7);

                    txtCodigo.Text = Variaveis.codReserva.ToString();
                    txtObservacao.Text = Variaveis.obs;
                    mkdDataCad.Text = Variaveis.dataReserva.ToString();
                    cmbHorario.Text = Variaveis.horarioReserva.ToString("HH:mm");
                    cmbStatus.Text = Variaveis.statusReserva;
                    cmbFuncionario.Text = Variaveis.nomeFuncionario;
                    cmbCliente.Text = Variaveis.nomeCliente;
                    cmbServico.Text = Variaveis.nomeServico;
                }

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da reserva!\n\n" + ex.Message, "Erro.");
            }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idFuncionario,nomeFuncionario FROM funcionario ORDER BY nomeFuncionario";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeFuncionario";
                cmbFuncionario.ValueMember = "idFuncionario";
                cmbFuncionario.SelectedIndex = -1;

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de funcionários!\n\n" + ex.Message, "Erro.");
            }
        }
        private void CarregarClientes()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idCliente,nomeCliente FROM cliente ORDER BY nomeCliente";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeCliente";
                cmbFuncionario.ValueMember = "idCliente";
                cmbFuncionario.SelectedIndex = -1;

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de funcionários!\n\n" + ex.Message, "Erro.");
            }
        }
        private void CarregarServicos()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idServico,nomeServico FROM servico ORDER BY nomeServico";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeServico";
                cmbFuncionario.ValueMember = "idServico";
                cmbFuncionario.SelectedIndex = -1;

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de funcionários!\n\n" + ex.Message, "Erro.");
            }
        }
        private void picSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmCadReserva_Load(object sender, EventArgs e)
        {
            pnlCadReserva.Location = new Point(this.Width / 2 - pnlCadReserva.Width / 2, this.Height / 2 - pnlCadReserva.Height / 2);

            if (Variaveis.funcao == "CADASTRAR")
            {
                lblCadReserva.Text = "CADASTRAR RESERVA";
            }

            if (Variaveis.funcao == "ALTERAR")
            {
                lblCadReserva.Text = "ALTERAR RESERVA";
            }
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtObservacao.Focus();
            }
        }

        private void txtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calReserva.Focus();
            }
        }

        private void calReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbHorario.Focus();
            }
        }

        private void cmbHorario_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbFuncionario.Focus();
            }
        }

        private void cmbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCliente.Focus();
            }
        }


        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                cmbServico.Focus();
            }
        }
        private void cmbServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblObservacao.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataReserva.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblServico.ForeColor = Color.FromArgb(70, 10, 45);

            txtObservacao.Clear();
            cmbHorario.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;

            txtObservacao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblObservacao.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataReserva.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblServico.ForeColor = Color.FromArgb(70, 10, 45);

            if (txtObservacao.Text == String.Empty)
            {
                lblObservacao.ForeColor = Color.Red;
                MessageBox.Show("Por favor, dê uma observação à reserva.");
                txtObservacao.Focus();
            }
            else if (cmbHorario.Text == String.Empty)
            {
                lblHorario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o horário de atendimento.");
                cmbHorario.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o status.");
                cmbStatus.Focus();
            }
            else if (cmbFuncionario.Text == String.Empty)
            {
                lblFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha qual será o funcionário.");
                cmbFuncionario.Focus();
            }
            else if (cmbCliente.Text == String.Empty)
            {
                lblCliente.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha qual será o cliente.");
                cmbCliente.Focus();
            }
            else if (cmbServico.Text == String.Empty)
            {
                lblServico.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha qual será o serviço.");
                cmbServico.Focus();
            }
            else
            {
                Variaveis.obs = txtObservacao.Text;
                Variaveis.horarioReserva = DateTime.Parse(cmbHorario.Text);
                Variaveis.statusReserva = cmbStatus.Text;

                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
    }
}
