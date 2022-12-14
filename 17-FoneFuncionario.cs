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
    public partial class frmFoneFuncionario : Form
    {
        public frmFoneFuncionario()
        {
            InitializeComponent();
        }

        private void frmFoneFuncionario_Load(object sender, EventArgs e)
        {
            pnlFoneFuncionario.Location = new Point(this.Width / 2 - pnlFoneFuncionario.Width / 2, this.Height / 2 - pnlFoneFuncionario.Height / 2);
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmCadFuncionario().Show();
            Close();
        }

        private void cmbNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
