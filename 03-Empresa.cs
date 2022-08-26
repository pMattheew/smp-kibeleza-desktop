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

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(this.Width / 2 - pnlEmpresa.Width / 2, this.Height / 2 - pnlEmpresa.Height / 2);
            Variaveis.linhaSelecionada = -1;

            banco.CarregarDados("empresacompleta", dgvEmpresa);
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
                banco.CarregarDados("empresaativa", dgvEmpresa);
            }
            else
            {
                banco.CarregarDados("empresacompleta", dgvEmpresa);
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                chkAtivo.Enabled = true;
                banco.CarregarDados("empresacompleta", dgvEmpresa);
            }
            else
            {
                chkAtivo.Checked = false;
                chkAtivo.Enabled = false;
                Variaveis.nomeEmpresa = txtNome.Text;

                banco.CarregarDados("empresacompleta WHERE `NOME DA EMPRESA` LIKE '" + Variaveis.nomeEmpresa + "%' ", dgvEmpresa);
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

                    banco.ExcluirLinha("empresa", "idEmpresa", Variaveis.codEmpresa);
                    banco.CarregarDados("empresacompleta", dgvEmpresa);
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha.");
            }
        }
    }
}
