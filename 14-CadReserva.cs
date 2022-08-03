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
        }
    }
}
