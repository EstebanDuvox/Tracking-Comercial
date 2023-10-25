namespace Tracking_Comercial.Ventanas
{
    public partial class RegU : Form
    {
        public RegU()
        {
            InitializeComponent();
            if (txtU.TextLength<3 || txtC.TextLength < 8)
            {
                btnA.Enabled = false;
            }else btnA.Enabled = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtU_Click(object sender, EventArgs e)
        {
            txtU.Text = "";
            txtU.ForeColor = Color.Black;
        }

        private void txtC_Click(object sender, EventArgs e)
        {
            txtU.Text = "";
            txtU.ForeColor = Color.Black;
            txtU.UseSystemPasswordChar = true;
        }
    }
}
