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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Close();
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            pnlCadServico.Location = new Point(this.Width / 2 - pnlCadServico.Width / 2, this.Height / 2 - pnlCadServico.Height / 2);

            if (Variaveis.funcao == "ALTERAR")
            {
                lblCadServico.Text = "ALTERAR SERVIÇO";
            }
        }

        private void txtNomeServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValor.Focus();
            }
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
                btnFoto1.Focus();
            }
        }

        private void btnFoto1_Click(object sender, EventArgs e)
        {
            btnFoto2.Focus();
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            btnFoto3.Focus();
        }

        private void btnFoto3_Click(object sender, EventArgs e)
        {
            btnFoto4.Focus();
        }

        private void btnFoto4_Click(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTexto.Focus();
            }
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbTempoExec.Focus();
            }
        }

        private void cmbTempoExec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbEmpresa.Focus();
            }
        }

        private void cmbEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeServico.Clear();
            txtValor.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            txtDescricao.Clear();
            txtTexto.Clear();
            cmbTempoExec.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;

            txtNomeServico.Focus();
        }
    }
}
