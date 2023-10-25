using System.Data;
using System.Data.SqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Usuario : Conexiones
    {
        public DataTable? ingresar(string user, string pass)
        {
            try
            {
                conectado();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From usuarios Where nom_u='{user}' or con_u='{pass}';";
                if (cmd.ExecuteNonQuery() == -1) {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                } 
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally 
            {
                desconectado();
            }
        }

        public void crear(string user,string pass)
        {
            try
            {
                conectado();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Insert into usuarios (nom_u,con_u) values ('{user}','{pass}');";
                if (cmd.ExecuteNonQuery() != -1)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = cmd;
                }
                MessageBox.Show($"El usuario {user}. Fue creado con exito");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                desconectado(); 
            }
        }

    }
}
