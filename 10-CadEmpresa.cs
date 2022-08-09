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
    }
}
