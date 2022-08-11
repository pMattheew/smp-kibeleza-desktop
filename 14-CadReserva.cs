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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblObservacao.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataReserva.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblServico.ForeColor = Color.FromArgb(70, 10, 45);

            txtObservacao.Clear();
            cmbHorario.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;

            txtObservacao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblObservacao.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataReserva.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblServico.ForeColor = Color.FromArgb(70, 10, 45);

            if (txtObservacao.Text == String.Empty)
            {
                lblObservacao.ForeColor = Color.Red;
                MessageBox.Show("Por favor, dê uma observação à reserva.");
                txtObservacao.Focus();
            }
            else if (cmbHorario.Text == String.Empty)
            {
                lblHorario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o horário de atendimento.");
                cmbHorario.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o status.");
                cmbStatus.Focus();
            }
            else if (cmbFuncionario.Text == String.Empty)
            {
                lblFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha qual será o funcionário.");
                cmbFuncionario.Focus();
            }
            else if (cmbCliente.Text == String.Empty)
            {
                lblCliente.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha qual será o cliente.");
                cmbCliente.Focus();
            }
            else if (cmbServico.Text == String.Empty)
            {
                lblServico.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha qual será o serviço.");
                cmbServico.Focus();
            }
            else
            {
                Variaveis.obsReserva = txtObservacao.Text;
                Variaveis.horarioReserva = DateTime.Parse(cmbHorario.Text);
                Variaveis.statusReserva = cmbStatus.Text;
                Variaveis.funcionarioReserva = cmbFuncionario.Text;
                Variaveis.clienteReserva = cmbCliente.Text;
                Variaveis.servicoReserva = cmbServico.Text;

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
    }
}
