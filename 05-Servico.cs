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
    public partial class frmServico : Form
    {
        public frmServico()
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

                dgvServico.DataSource = dt;

                dgvServico.ClearSelection();

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

        private void frmServico_Load(object sender, EventArgs e)
        {

            pnlServico.Location = new Point(this.Width / 2 - pnlServico.Width / 2, this.Height / 2 - pnlServico.Height / 2);
            CarregarDados("SELECT * FROM `servicocompleto`");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadServico().Show(); 
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadServico().Show();
            Hide();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                chkAtivo.Enabled = false;
                chkAtivo.Checked = false;
                CarregarDados("SELECT * FROM `servicocompleto` WHERE `NOME DO SERVIÇO` LIKE ");
            }
            else
            {
                chkAtivo.Enabled = true;
                CarregarDados("SELECT * FROM `servicocompleto`");
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAtivo.Checked)
            {
                CarregarDados("SELECT * FROM `servicoativo`");
            }
            else
            {
                CarregarDados("SELECT * FROM `servicocompleto`");
            }
        }
    }
}
