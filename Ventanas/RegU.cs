using System.Windows.Forms.VisualStyles;
using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Ventanas
{
    public partial class RegU : Form
    {
        public RegU()
        {
            InitializeComponent();
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
        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
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
                crear(txtU.Text.ToLower(), txtC.Text);
                this.Close();
            }
        }

        private void crear(string u, String p)
        {
            Usuario funcion = new Usuario();
            funcion.crear(u, p);
        }

    }
}
