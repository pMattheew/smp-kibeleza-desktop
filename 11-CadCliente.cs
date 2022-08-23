using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        public bool ValidarFtp()
        {
            if (string.IsNullOrEmpty(Variaveis.enderecoServidorFtp) ||
                string.IsNullOrEmpty(Variaveis.usuarioFtp) ||
                string.IsNullOrEmpty(Variaveis.senha))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // CONVERTER A IMAGEM EM BYTES
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(Variaveis.usuarioFtp, Variaveis.senhaFtp);
            byte[] imageToByte = ftpClient.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        // CONVERTER A IMAGEM DE BYTE PARA BITMAP/IMG
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO cliente(idCliente,nomeCliente,emailCliente,senhaCliente,statusCliente,dataCadCliente,fotoCliente) VALUES (DEFAULT,@nome,@email,@senha,@status,@dataCad,@foto)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);

                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCad", Variaveis.dataCadCliente.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoCliente);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro do cliente");
                banco.Desconectar();

                // verificar credenciais e fazer upload da imagem
                if (ValidarFtp())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(Variaveis.fotoCliente);

                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoCliente, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não selecionada", "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente\n\n"+ ex.Message, "ERRO");
            }
        }

        private void AlterarCliente()
        {
            try
            {
                banco.Conectar();

                string alterar = "UPDATE cliente SET nomeCliente=@nome,emailCliente=@email,senhaCliente=@senha,statusCliente=@status WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);

                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!", "Alteração do cliente");

                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar cliente\n\n" + ex.Message, "ERRO");
            }
        }

        private void AlterarFotoCliente()
        {
            try
            {
                banco.Conectar();

                string alterar = "UPDATE cliente SET fotoCliente=@foto WHERE idCliente=@codigo";

                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);

                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);

                cmd.ExecuteNonQuery();

                banco.Desconectar();

                if (ValidarFtp())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(Variaveis.fotoCliente);

                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoCliente, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não selecionada\n\n" + ex.Message, "ERRO");
                        }
                    }
                }

                MessageBox.Show("Foto alterada com sucesso!", "Alteração do cliente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a foto do cliente\n\n" + ex.Message, "ERRO");
            }
        }

        private void CarregarClienteCadastrado()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idCliente FROM cliente WHERE nomeCliente=@nome";

                MySqlCommand cmd = new MySqlCommand(@selecionar, banco.conexao);

                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.codCliente = reader.GetInt32(0);
                    txtCodigo.Text = Variaveis.codCliente.ToString();
                }

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cliente cadastrado!\n\n" + ex.Message, "ERRO");
            }
        }

        private void CarregarDadosCliente()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT * FROM cliente WHERE idCliente=@codigo";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);

                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.nomeCliente= reader.GetString(1);
                    Variaveis.emailCliente = reader.GetString(2);
                    Variaveis.senhaCliente = reader.GetString(3);
                    Variaveis.statusCliente = reader.GetString(4);
                    Variaveis.dataCadCliente = reader.GetDateTime(5);
                    Variaveis.fotoCliente = reader.GetString(6).Remove(0, 8);

                    txtCodigo.Text = Variaveis.codCliente.ToString();
                    txtNomeCliente.Text = Variaveis.nomeCliente;
                    txtEmail.Text = Variaveis.emailCliente;
                    txtSenha.Text = Variaveis.senhaCliente;
                    cmbStatus.Text = Variaveis.statusCliente;
                    mkdDataCad.Text = Variaveis.dataCadCliente.ToString("dd/MM/yyyy");
                    picFoto.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServidorFtp + "cliente/" + Variaveis.fotoCliente));                   

                }

                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do cliente!\n\n" + ex.Message, "Erro.");
            }
        }

        private void CarregarFoneCliente()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT * FROM fonecliente WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneCliente.DataSource = dt;
                dgvFoneCliente.Columns[0].HeaderText = "CÓDIGO";
                dgvFoneCliente.Columns[0].Visible = false;
                dgvFoneCliente.Columns[1].HeaderText = "NÚMERO TELEFONE";
                dgvFoneCliente.Columns[2].HeaderText = "OPERADORA";
                dgvFoneCliente.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneCliente.Columns[4].HeaderText = "EMPRESA";
                dgvFoneCliente.Columns[4].Visible = false;
                dgvFoneCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefone do cliente!\n\n" + ex.Message, "ERRO");
            }
        }

        private void ExcluirFoneCliente()
        {
            try
            {
                banco.Conectar();

                string excluir = "DELETE FROM fonecliente WHERE idFoneCliente=@codFone";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneCliente.DataSource = dt;
                       
                dgvFoneCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir telefone do cliente!\n\n" + ex.Message, "ERRO");
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            if (Variaveis.funcao == "ALTERAR")
            {
                lblCadCliente.Text = "ALTERAR CLIENTE";
                pnlTelefone.Enabled = true;

                CarregarDadosCliente();
                CarregarFoneCliente();
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

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirCliente();
                    CarregarClienteCadastrado();
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarCliente();
                }

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFoneCliente();
        }
    }
}
