using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Formularios.Secundarios
{
    public partial class mod_U : Form
    {
        public mod_U()
        {
            InitializeComponent();
            Usuario u = new Usuario();
            cbU.DataSource = u.listU();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.modificar(cbU.Text, txtC.Text, cbTU.Text, chC.Checked, chTU.Checked);
            this.Close();
        }

        private void chC_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }

        private void chTU_CheckedChanged(object sender, EventArgs e)
        {
            cbTU.Enabled = true;
        }
    }
}
