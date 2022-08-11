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
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void picSair_Click_1(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            pnlCadEmpresa.Location = new Point(this.Width / 2 - pnlCadEmpresa.Width / 2, this.Height / 2 - pnlCadEmpresa.Height / 2);

            if (Variaveis.funcao == "ALTERAR")
            {
                pnlTelefone.Enabled = true;
                lblCadEmpresa.Text = "ALTERAR EMPRESA";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmFoneEmpresa().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmFoneEmpresa().Show();
            Hide();
        }

        private void radCpf_CheckedChanged(object sender, EventArgs e)
        {
            mkdCnpjCpf.Mask = "000,000,000-00";
            mkdCnpjCpf.Focus();
        }

        private void radCnpj_CheckedChanged(object sender, EventArgs e)
        {
            mkdCnpjCpf.Mask = "00,000,000/0000-00";
            mkdCnpjCpf.Focus();
        }

        private void txtNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) radCnpj.Focus();
            
        }

        private void mkdCnpjCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (mkdCnpjCpf.MaskCompleted)
                {
                    txtRazao.Focus();
                }
                else
                {
                    MessageBox.Show("Complete o CNPJ ou CPF");
                    mkdCnpjCpf.Focus();
                }
            }

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtRazao.Focus();
        }
        private void txtRazao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) cmbStatus.Focus();
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cmbHorario.Focus();
            }
        }

        private void cmbHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSalvar.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeEmpresa.ForeColor = Color.FromArgb(70, 10, 45);
            radCnpj.ForeColor = Color.FromArgb(70, 10, 45);
            radCpf.ForeColor = Color.FromArgb(70, 10, 45);
            lblRazao.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);

            if (txtNomeEmpresa.Text == String.Empty)
            {
                lblNomeEmpresa.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o nome da empresa.");
                txtNomeEmpresa.Focus();
            }
            else if (!mkdCnpjCpf.MaskCompleted)
            {
                radCnpj.ForeColor = Color.Red;
                radCpf.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o CNPJ ou CPF.");
                mkdCnpjCpf.Focus();
            }
            else if (txtRazao.Text == String.Empty)
            {
                lblRazao.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha a razão social.");
                txtRazao.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o email.");
                txtEmail.Focus();
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
            else if (cmbHorario.Text == String.Empty)
            {
                lblHorario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o horário de atendimento.");
                cmbHorario.Focus();
            }
            else
            {
                Variaveis.nomeEmpresa = txtNomeEmpresa.Text;
                Variaveis.cnpjCpf = mkdCnpjCpf.Text;
                Variaveis.razaoSocial = txtRazao.Text;
                Variaveis.emailEmpresa = txtEmail.Text;
                Variaveis.statusEmpresa = cmbStatus.Text;
                mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCadEmpresa = DateTime.Parse(mkdDataCad.Text);
                Variaveis.horarioAtendEmpresa = DateTime.Parse(cmbHorario.Text);

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            lblNomeEmpresa.ForeColor = Color.FromArgb(70, 10, 45);
            radCnpj.ForeColor = Color.FromArgb(70, 10, 45);
            radCpf.ForeColor = Color.FromArgb(70, 10, 45);
            lblRazao.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);

            txtNomeEmpresa.Clear();
            mkdCnpjCpf.Clear();
            txtRazao.Clear();
            txtEmail.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            cmbHorario.SelectedIndex = -1;

            txtNomeEmpresa.Focus();
        }
    }
}
