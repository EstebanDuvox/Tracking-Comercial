using Google.Protobuf.WellKnownTypes;
using System.Data;
using Tracking_Comercial.SQL;
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
            verificar(txtU.Text.ToLower(),txtC.Text);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCU_Click(object sender, EventArgs e)
        {
            RegU cu = new RegU();
            cu.Show();
        }
        private void verificar(string u,string p)
        {
            DataTable dt = new DataTable();
            Usuario funcion = new Usuario();
            string user, pass, tipo;
            int emp;
            dt = funcion.ingresar(u,p);
            dt.MinimumCapacity = 0;
            user = dt.Rows[0].Field<string>("nom_u");
            pass = dt.Rows[0].Field<string>("con_u");
            tipo = dt.Rows[0].Field<string>("tipo_u");
            emp = dt.Rows[0].Field<int>("id_perfil");
            if (u == user && p == pass)
            {
                this.Hide();
                txtU.Clear();
                txtC.Clear();
                AppP a = new AppP(tipo,emp);
                a.Show();
            }
            else if (u != user || p != pass)
            {
                MessageBox.Show("Usuario y/o contraseņa no valido");
            }
        }

    }
}