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
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmContato_Load(object sender, EventArgs e)
        {

            pnlContato.Location = new Point(this.Width / 2 - pnlContato.Width / 2, this.Height / 2 - pnlContato.Height / 2);
        }
    }
}
