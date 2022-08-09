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
            if (e.KeyChar == (char)Keys.Enter && mkdCnpjCpf.MaskCompleted == true)
            {
                txtRazao.Focus();
            }
            else
            {
                MessageBox.Show("Complete o CNPJ ou CPF");
                mkdCnpjCpf.Focus();
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
            pnlTelefone.Enabled = true;
        }
    }
}
