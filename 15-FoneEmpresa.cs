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
    public partial class frmFoneEmpresa : Form
    {
        public frmFoneEmpresa()
        {
            InitializeComponent();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmCadEmpresa().Show();
            Close();
        }

        private void frmFoneEmpresa_Load(object sender, EventArgs e)
        {
            pnlFoneEmpresa.Location = new Point(this.Width / 2 - pnlFoneEmpresa.Width / 2, this.Height / 2 - pnlFoneEmpresa.Height / 2);
        }

    }
}
