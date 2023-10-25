using System.Data.SqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Conexiones
    {
        protected new SqlConnection cc;
        public int id_usuario;

        public dynamic conectado()
        {
            try
            {
                Para opara = new Para();
                cc = new SqlConnection(opara.Conexion);
                cc.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public dynamic desconectado()
        {
            try
            {
                if (cc.State == System.Data.ConnectionState.Open)
                {
                    cc.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            }
        }
    }