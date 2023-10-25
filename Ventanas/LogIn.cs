using Tracking_Comercial.Ventanas;

namespace Tracking_Comercial
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            this.Close();
            txtU.Clear();
            txtC.Clear();
            app a = new app();
            a.Show();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCU_Click(object sender, EventArgs e)
        {

        }

        /*private void verificar()
        {
            DataTable dt = new DataTable();
            Usuario funcion = new Usuario();
            string user, pass;
            dt = funcion.ingresar(txtU.Text.ToLower(), txtU.Text);
            dt.MinimumCapacity = 0;
            user = dt.Rows[0].Field<string>("nom_u");
            pass = dt.Rows[0].Field<string>("con_u");
            if (txtU.Text == user && txtC.Text == pass)
            {
                AyC();
            }
            else if (txtU.Text != user || txtC.Text != pass)
            {
                MessageBox.Show("Usuario y/o Contraseña no valido");
            }
        }*/

    }
}