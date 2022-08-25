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
    public partial class frmFoneEmpresa : Form
    {
        public frmFoneEmpresa()
        {
            InitializeComponent();
        }
        private void InserirFoneEmpresa()
        {
            try
            {
                banco.Conectar();

                string inserir = "INSERT INTO foneempresa(idFoneEmpresa,numeroFoneEmpresa,operFoneEmpresa,descFoneEmpresa,idEmpresa)VALUES(DEFAULT,@numero,@operadora,@descricao,@codEmpresa)";

                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numero", Variaveis.foneEmpresa);
                cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneEmpresa);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneEmpresa);
                cmd.Parameters.AddWithValue("@codEmpresa", Variaveis.codEmpresa);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Telefone da empresa cadastrada com sucesso!", "CADASTRO DO TELEFONE DA EMPRESA");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar telefone da empresa!\n\n" + ex.Message, "Erro.");
            }
        }

        private void AlterarFoneEmpresa()
        {
            {
                try
                {
                    banco.Conectar();

                    string alterar = "UPDATE foneempresa SET idFoneEmpresa=@codFone,numeroFoneEmpresa=@numerp,operFoneEmpresa=@operadora,descFoneEmpresa=@descricao";

                    MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                    cmd.Parameters.AddWithValue("@numero", Variaveis.foneEmpresa);
                    cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneEmpresa);
                    cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneEmpresa);
                    cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneEmpresa);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Telefone da empresa alterada com sucesso!", "ALTERAÇÃO DO TELEFONE DA EMPRESA");

                    banco.Desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar telefone da empresa!\n\n" + ex.Message, "Erro.");
                }
            }
        }

        private void CarregarEmpresas()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idEmpresa,nomeEmpresa FROM empresa ORDER BY nomeEmpresa";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbNomeEmpresa.DataSource = dt;
                cmbNomeEmpresa.DisplayMember = "nomeEmpresa";
                cmbNomeEmpresa.ValueMember = "idEmpresa";
                cmbNomeEmpresa.SelectedIndex = -1;

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de empresas!\n\n" + ex.Message, "ERRO");
            }
        }

        private void CarregarDadosFoneEmpresa()
        {
            try
            {
                banco.Conectar();

                string selecionar = "SELECT idFoneEmpresa,numeroFoneEmpresa,operFoneEmpresa,descFoneEmpresa,nomeEmpresa FROM foneempresa INNER JOIN empresa ON foneempresa.idEmpresa = empresa.idEmpresa WHERE idFoneEmpresa=@codFone";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneEmpresa);
                
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variaveis.foneEmpresa = reader.GetString(1);
                    Variaveis.operFoneEmpresa = reader.GetString(2);
                    Variaveis.descFoneEmpresa = reader.GetString(3);
                    Variaveis.nomeEmpresa = reader.GetString(4);

                    txtCodigo.Text = Variaveis.foneEmpresa.ToString();
                    txtCodigo.Text = Variaveis.operFoneEmpresa;
                    txtCodigo.Text = Variaveis.descFoneEmpresa;
                    txtCodigo.Text = Variaveis.nomeEmpresa;
                }

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados de telefone da empresa!\n\n" + ex.Message, "ERRO");
            }
        }


        private void picSair_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadEmpresa().Show();
            Close();
        }

        private void frmFoneEmpresa_Load(object sender, EventArgs e)
        {
            pnlFoneEmpresa.Location = new Point(this.Width / 2 - pnlFoneEmpresa.Width / 2, this.Height / 2 - pnlFoneEmpresa.Height / 2);

            CarregarEmpresas();
            cmbNomeEmpresa.Text = Variaveis.nomeEmpresa;

            if (Variaveis.funcao == "ALTERAR FONE")
            {
                CarregarDadosFoneEmpresa();
            }
        }

        private void cmbNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
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
            Variaveis.nomeEmpresa = cmbNomeEmpresa.Text;
            Variaveis.foneEmpresa = mkdTelefone.Text;
            Variaveis.operFoneEmpresa = cmbOperadora.Text;
            Variaveis.descFoneEmpresa = txtDescricao.Text;


            if (Variaveis.funcao == "CADASTRAR FONE")
            {
                InserirFoneEmpresa();
            }
            else if (Variaveis.funcao == "ALTERAR FONE")
            {
                AlterarFoneEmpresa();
            }

            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
        }
    }
}
