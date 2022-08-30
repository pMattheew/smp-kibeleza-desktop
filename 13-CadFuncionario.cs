using System;
using System.Drawing;
using System.Windows.Forms;

namespace kibelezaPMS
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncionario.Location = new Point(this.Width / 2 - pnlCadFuncionario.Width / 2, this.Height / 2 - pnlCadFuncionario.Height / 2);

            if (Variaveis.funcao == "ALTERAR")
            {
                lblCadFuncionario.Text = "ALTERAR FUNCIONÁRIO";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmFoneFuncionario().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmFoneFuncionario().Show();
            Hide();
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbNivel.Focus();
            }
        }

        private void cmbNivel_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbHorario.Focus();
            }
        }

        private void cmbHorario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblNivel.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            mkdDataCad.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmpresa.ForeColor = Color.FromArgb(70, 10, 45);

            if (txtNomeFuncionario.Text == String.Empty)
            {
                lblNomeFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o nome do cliente.");
                txtNomeFuncionario.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o email.");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o email.");
                txtSenha.Focus();
            }
            else if (cmbNivel.Text == String.Empty)
            {
                lblNivel.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha o nível do funcionário.");
                cmbNivel.Focus();
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
                MessageBox.Show("Por favor, preencha a data de cadastro.");
                cmbHorario.Focus();
            }
            else if (cmbEmpresa.Text == String.Empty)
            {
                lblEmpresa.ForeColor = Color.Red;
                MessageBox.Show("Por favor, preencha a data de cadastro.");
                cmbEmpresa.Focus();
            }
            else
            {
                Variaveis.nomeFuncionario = txtNomeFuncionario.Text;
                Variaveis.emailFuncionario = txtEmail.Text;
                Variaveis.senhaFuncionario = txtSenha.Text;
                Variaveis.statusFuncionario = cmbStatus.Text;
                Variaveis.nivelFuncionario = cmbNivel.Text;
                mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCad = DateTime.Parse(mkdDataCad.Text);
                Variaveis.empresaFuncionario = cmbEmpresa.Text;
                Variaveis.horario = DateTime.Parse(cmbHorario.Text);
                // Variaveis.fotoCliente = "cliente/" + nomeFoto;

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblNivel.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            mkdDataCad.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorario.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmpresa.ForeColor = Color.FromArgb(70, 10, 45);

            txtNomeFuncionario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbNivel.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            cmbHorario.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;

            txtNomeFuncionario.Focus();
        }
    }
}
