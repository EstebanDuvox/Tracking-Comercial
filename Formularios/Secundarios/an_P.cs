using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Formularios.Secundarios
{
    public partial class an_P : Form
    {
        public an_P()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Prospecto u = new Prospecto();
            int x = int.Parse(txtP.Text);
            u.crear(txtPro.Text,txtD.Text,txtE.Text,dtP.Text,x);
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