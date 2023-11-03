using MySql.Data.MySqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Conexiones : Para
    {
        protected MySqlConnection cc;
        public int id_usuario;

        public dynamic conectado()
        {
            try
            {
                Para opara = new Para();
                opara.Conexion = "Server='127.0.0.1';Database='tc';User Id=root; Password='';";
                cc = new MySqlConnection(opara.Conexion);
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