using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Formularios.Secundarios
{
    public partial class mod_P : Form
    {
        public mod_P()
        {
            InitializeComponent();
            Prospecto p = new Prospecto();
            cbU.DataSource = p.listP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Prospecto u = new Prospecto();
            int x = int.Parse(txtP.Text);
            u.Actualizar(cbU.Text, txtD.Text,txtE.Text,dtP.Text,x, chD.Checked, chE.Checked,chF.Checked,chP.Checked);
            this.Close();
        }

        private void chC_CheckedChanged(object sender, EventArgs e)
        {
            txtD.Enabled = true;
        }

        private void chTU_CheckedChanged(object sender, EventArgs e)
        {
            txtE.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dtP.Enabled = true;
        }

        private void chP_CheckedChanged(object sender, EventArgs e)
        {
            txtP.Enabled = true;    
        }
    }
}