using System.Collections.Specialized;
using System.Data;
using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Ventanas
{
    public partial class AppP : Form
    {
        public AppP()
        {
            InitializeComponent();
        }

        private void app_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            RegU a = new RegU();
            a.Show();
        }

        private void tpU_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            DataTable dt = new DataTable();
            dt = u.mostrar();
            dgU.DataSource = dt;
            cbU.DataSource = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();
        }

        private void btnBU_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.buscar(cbU.Text, txtBU.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn.ActiveForm.Show();
            this.Close();
        }
    }
}
