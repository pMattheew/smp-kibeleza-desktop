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
    public partial class frmFoneCliente : Form
    {
        public frmFoneCliente()
        {
            InitializeComponent();
        }
        private void InserirFoneCliente()
        {
            try
            {
                banco.Conectar();

                string inserir = "INSERT INTO fonecliente(idFoneCliente,numeroFoneCliente,operFoneCliente,descFoneCliente,idCliente)VALUES(DEFAULT,@numero,@operadora,@descricao,@codCliente)";

                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numero", Variaveis.foneCliente);
                cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneCliente);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneCliente);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Telefone do cliente cadastrado com sucesso!", "CADASTRO DO TELEFONE DO CLIENTE");

                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o telefone do cliente! \n\n" + ex.Message, "ERRO");
            }
        }
        private void AlterarFoneCliente()
        {
            {
                try
                {
                    banco.Conectar();

                    string alterar = "UPDATE foneClienteSET idFoneCliente=@codFone,numeroFoneCliente=@numero,operFoneCliente=@operadora,descFoneCliente=@descricao";

                    MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                    cmd.Parameters.AddWithValue("@numero", Variaveis.foneCliente);
                    cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneCliente);
                    cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneCliente);
                    cmd.Parameters.AddWithValue("@codFoneCliente", Variaveis.codFoneCliente);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Telefone do cliente alterado com sucesso!", "ALTERAÇÃO DO TELEFONE DO CLIENTE");

                    banco.Desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar telefone do cliente!\n\n" + ex.Message, "Erro.");
                }
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

                cmbNomeCliente.DataSource = dt;
                cmbNomeCliente.DisplayMember = "nomeCliente";
                cmbNomeCliente.ValueMember = "idCliente";
                cmbNomeCliente.SelectedIndex = -1;

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de clientes!\n\n" + ex.Message, "ERRO");
            }
        }
        private void CarregarDadosFoneCliente()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idFoneCliente,numeroFoneCliente,operFoneCliente,descFoneCliente,nomeClienteFROM foneclienteINNER JOIN clienteON fonecliente.idCliente= cliente.idClienteWHERE idFoneCliente=@codFoneCliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codFoneCliente", Variaveis.codFoneCliente);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.foneCliente= reader.GetString(1);
                    Variaveis.operFoneCliente= reader.GetString(2);
                    Variaveis.descFoneCliente= reader.GetString(3);
                    Variaveis.nomeCliente= reader.GetString(4);

                    txtCodigo.Text = Variaveis.foneCliente.ToString();
                    txtCodigo.Text = Variaveis.operFoneCliente;
                    txtCodigo.Text = Variaveis.descFoneCliente;
                    txtCodigo.Text = Variaveis.nomeCliente;
                }

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados de telefone do cliente!\n\n" + ex.Message, "ERRO");
            }
        }

        private void frmFoneCliente_Load(object sender, EventArgs e)
        {
            pnlFoneCliente.Location = new Point(this.Width / 2 - pnlFoneCliente.Width / 2, this.Height / 2 - pnlFoneCliente.Height / 2);

            CarregarClientes();
            cmbNomeCliente.Text = Variaveis.nomeCliente;

            if (Variaveis.funcao == "ALTERAR FONE")
            {
                CarregarDadosFoneCliente();
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmCadCliente().Show();
            Close();
        }

        private void cmbNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdTelefone.Focus();
            }
        }

        private void mkdTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbOperadora.Focus();
            }
        }

        private void cmbOperadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Variaveis.nomeCliente= cmbNomeCliente.Text;
            Variaveis.foneCliente= mkdTelefone.Text;
            Variaveis.operFoneCliente= cmbOperadora.Text;
            Variaveis.descFoneCliente= txtDescricao.Text;


            if (Variaveis.funcao == "CADASTRAR FONE")
            {
                InserirFoneCliente();
            }
            else if (Variaveis.funcao == "ALTERAR FONE")
            {
                AlterarFoneCliente();
            }

            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
        }
    }
}
