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
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }
        private void InserirEmpresa()
        {
            try
            {
                banco.Conectar();

                string inserir = "INSERT INTO empresa(idEmpresa,nomeEmpresa,cnpjCpfEmpresa,razaoSocialEmpresa,emailEmpresa,statusEmpresa,dataCadEmpresa,horarioAtendEmpresa)VALUES(DEFAULT,@nome,@cnpjCpf,@razaoSocial,@email,@status,@dataCad,@horario)";

                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", Variaveis.cnpjCpf);
                cmd.Parameters.AddWithValue("@razaoSocial", Variaveis.razaoSocial);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@dataCad", Variaveis.dataCadEmpresa.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horario", Variaveis.horarioAtendEmpresa.ToString("HH:mm"));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Empresa cadastrada com sucesso!", "CADASTRO DA EMPRESA");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a empresa!\n\n" + ex.Message, "Erro.");
            }
        }

        private void AlterarEmpresa()
        {
            try
            {
                banco.Conectar();

                string inserir = "UPDATE `empresa` SET `nomeEmpresa`=@nome,`cnpjCpfEmpresa`=@cnpjCpf,`razaoSocialEmpresa`=@razaoSocial,`emailEmpresa`=@email,`statusEmpresa`=@status,`horarioAtendEmpresa`=@horario WHERE idEmpresa = @codigo";

                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", Variaveis.cnpjCpf);
                cmd.Parameters.AddWithValue("@razaoSocial", Variaveis.razaoSocial);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@horario", Variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Empresa atualizada com sucesso!", "CADASTRO DA EMPRESA");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a empresa!\n\n" + ex.Message, "Erro.");
            }
        }

        private void CarregarDadosEmpresa()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT * FROM empresa WHERE idEmpresa=@codigo";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);

                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.nomeEmpresa = reader.GetString(1);
                    Variaveis.cnpjCpf = reader.GetString(2);
                    Variaveis.razaoSocial = reader.GetString(3);
                    Variaveis.emailEmpresa = reader.GetString(4);
                    Variaveis.statusEmpresa = reader.GetString(5);
                    Variaveis.dataCadEmpresa = reader.GetDateTime(6);
                    Variaveis.horarioAtendEmpresa = DateTime.Parse(reader.GetString(7));

                    txtCodigo.Text = Variaveis.codEmpresa.ToString();
                    txtNomeEmpresa.Text = Variaveis.nomeEmpresa;

                    if (mkdCnpjCpf.Text.Length > 15)
                    {
                        radCnpj.Checked = true;
                    }
                    else
                    {
                        radCpf.Checked = true;
                    }

                    mkdCnpjCpf.Text = Variaveis.cnpjCpf;
                    txtRazao.Text = Variaveis.razaoSocial;
                    txtEmail.Text = Variaveis.emailEmpresa;
                    cmbStatus.Text = Variaveis.statusEmpresa;
                    mkdDataCad.Text = Variaveis.dataCadEmpresa.ToString("dd/MM/yyyy");
                    cmbHorario.Text = Variaveis.horarioAtendEmpresa.ToString("HH:mm");

                }

                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da empresa!\n\n" + ex.Message, "Erro.");
            }
        }

        private void CarregarEmpresaCadastrada()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idEmpresa FROM empresa WHERE nomeEmpresa=@nome AND cnpjCpfEmpresa=@cnpjCpf";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@nome",Variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", Variaveis.cnpjCpf);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.codEmpresa = reader.GetInt32(0);
                    txtCodigo.Text = Variaveis.codEmpresa.ToString();
                }

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empresa cadastrada!\n\n" + ex.Message, "ERRO");
            }
        }

        private void CarregarFoneEmpresa()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT * FROM foneempresa WHERE idEmpresa=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneEmpresa.DataSource = dt;
                dgvFoneEmpresa.Columns[0].HeaderText = "CÓDIGO";
                dgvFoneEmpresa.Columns[0].Visible = false;
                dgvFoneEmpresa.Columns[1].HeaderText = "NÚMERO TELEFONE";
                dgvFoneEmpresa.Columns[2].HeaderText = "OPERADORA";
                dgvFoneEmpresa.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneEmpresa.Columns[4].HeaderText = "EMPRESA";
                dgvFoneEmpresa.Columns[4].Visible = false;
                dgvFoneEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefone da empresa!\n\n" + ex.Message, "ERRO");
            }
        }

        private void ExcluirFoneEmpresa()
        {
            try
            {
                banco.Conectar();

                string excluir = "DELETE FROM foneempresa WHERE idFoneEmpresa=@codFone";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneEmpresa.DataSource = dt;

                dgvFoneEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir telefone da empresa!\n\n" + ex.Message, "ERRO");
            }
        }

        private void picSair_Click_1(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            pnlCadEmpresa.Location = new Point(this.Width / 2 - pnlCadEmpresa.Width / 2, this.Height / 2 - pnlCadEmpresa.Height / 2);

            Variaveis.linhaFoneSelecionada = -1;

            if (Variaveis.funcao == "ALTERAR")
            {
                pnlTelefone.Enabled = true;
                lblCadEmpresa.Text = "ALTERAR EMPRESA";
                CarregarDadosEmpresa();
                CarregarFoneEmpresa();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR FONE";
            new frmFoneEmpresa().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaFoneSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR FONE";
                new frmFoneEmpresa().Show();
                Hide();
            }
        }

        private void radCpf_CheckedChanged(object sender, EventArgs e)
        {
            mkdCnpjCpf.Mask = "000,000,000-00";
            mkdCnpjCpf.Focus();
        }

        private void radCnpj_CheckedChanged(object sender, EventArgs e)
        {
            mkdCnpjCpf.Mask = "00,000,000/0000-00";
            mkdCnpjCpf.Focus();
        }

        private void txtNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) radCnpj.Focus();
            
        }

        private void mkdCnpjCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (mkdCnpjCpf.MaskCompleted)
                {
                    txtRazao.Focus();
                }
                else
                {
                    MessageBox.Show("Complete o CNPJ ou CPF");
                    mkdCnpjCpf.Focus();
                }
            }

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtRazao.Focus();
        }
        private void txtRazao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) cmbStatus.Focus();
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Variaveis.funcao == "CADASTRAR")
                {
                    mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    Variaveis.dataCadEmpresa = DateTime.Parse(mkdDataCad.Text);
                }

                cmbHorario.Focus();
            }
        }

        private void cmbHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSalvar.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeEmpresa.ForeColor = Color.FromArgb(70, 10, 45);
            radCnpj.ForeColor = Color.FromArgb(70, 10, 45);
            radCpf.ForeColor = Color.FromArgb(70, 10, 45);
            lblRazao.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);

            if (txtNomeEmpresa.Text == String.Empty)
            {
                lblNomeEmpresa.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o nome da empresa.");
                txtNomeEmpresa.Focus();
            }
            else if (!mkdCnpjCpf.MaskCompleted)
            {
                radCnpj.ForeColor = Color.Red;
                radCpf.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o CNPJ ou CPF.");
                mkdCnpjCpf.Focus();
            }
            else if (txtRazao.Text == String.Empty)
            {
                lblRazao.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha a razão social.");
                txtRazao.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o email.");
                txtEmail.Focus();
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
            else if (cmbHorario.Text == String.Empty)
            {
                lblHorario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o horário de atendimento.");
                cmbHorario.Focus();
            }
            else
            {
                Variaveis.nomeEmpresa = txtNomeEmpresa.Text;
                Variaveis.cnpjCpf = mkdCnpjCpf.Text;
                Variaveis.razaoSocial = txtRazao.Text;
                Variaveis.emailEmpresa = txtEmail.Text;
                Variaveis.statusEmpresa = cmbStatus.Text;
                if (Variaveis.funcao == "CADASTRAR")
                {
                    mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    Variaveis.dataCadEmpresa = DateTime.Parse(mkdDataCad.Text);
                }
                Variaveis.dataCadEmpresa = DateTime.Parse(mkdDataCad.Text);
                Variaveis.horarioAtendEmpresa = DateTime.Parse(cmbHorario.Text);

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirEmpresa();
                    CarregarEmpresaCadastrada();
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarEmpresa();
                }

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            lblNomeEmpresa.ForeColor = Color.FromArgb(70, 10, 45);
            radCnpj.ForeColor = Color.FromArgb(70, 10, 45);
            radCpf.ForeColor = Color.FromArgb(70, 10, 45);
            lblRazao.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);

            txtNomeEmpresa.Clear();
            mkdCnpjCpf.Clear();
            txtRazao.Clear();
            txtEmail.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            cmbHorario.SelectedIndex = -1;

            txtNomeEmpresa.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFoneEmpresa();
        }

        private void dgvFoneEmpresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFoneEmpresa.Sort(dgvFoneEmpresa.Columns[1], ListSortDirection.Ascending); // ao clicar no cabeçalho da coluna, obrigar a ordenar pela coluna 1 (nomeEmpresa)
            dgvFoneEmpresa.ClearSelection();
        }

        private void dgvFoneEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaFoneSelecionada = int.Parse(e.RowIndex.ToString());

            if (Variaveis.linhaFoneSelecionada >= 0)
            {
                Variaveis.codEmpresa = Convert.ToInt32(dgvFoneEmpresa[0, Variaveis.linhaFoneSelecionada].Value);
            }
        }
    }
}
