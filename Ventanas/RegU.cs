namespace Tracking_Comercial.Ventanas
{
    public partial class RegU : Form
    {
        public RegU()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtU.TextLength < 3 && txtC.TextLength < 8)
            {
                MessageBox.Show("Por favor ingresar datos validos.");
            }
            else if(txtU.Text == "ej:pepito" &&  txtC.Text == "ej:admin123")
            {
                MessageBox.Show("Por favor modifique los cuadros de texto " +
                    ">:/");
            }else
            {
                this.Close();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtU_Click(object sender, EventArgs e)
        {
            txtU.Text = "";
            txtU.ForeColor = SystemColors.WindowText;
        }

        private void txtC_Click(object sender, EventArgs e)
        {
            txtC.Text = "";
            txtC.ForeColor = SystemColors.WindowText;
            txtC.UseSystemPasswordChar = true;
        }
    }
}
