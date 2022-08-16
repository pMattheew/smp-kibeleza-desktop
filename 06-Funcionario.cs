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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void CarregarDados(string select)
        {
            try
            {
                banco.Conectar();
                MySqlCommand cmd = new MySqlCommand(select, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o relatório. \n\n", erro.Message);
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDados("SELECT * FROM `funcionariocompleto`");
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                chkAtivo.Enabled = false;
                chkAtivo.Checked = false;
                Variaveis.nomeFuncionario = txtNome.Text;
                CarregarDados("SELECT * FROM `funcionariocompleto` WHERE `NOME DO FUNCIONÁRIO` LIKE '"+ Variaveis.nomeFuncionario +"%'");
            }
            else
            {
                chkAtivo.Enabled = true;
                CarregarDados("SELECT * FROM `funcionariocompleto`");
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                CarregarDados("SELECT * FROM `funcionarioativo`");
            }
        }
    }
}
