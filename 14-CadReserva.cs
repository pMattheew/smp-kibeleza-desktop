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
        public frmCadReserva()
        {
            InitializeComponent();
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
    }
}
