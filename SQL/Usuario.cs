using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Usuario : Conexiones
    {
        public DataTable? ingresar(string user, string pass)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From usuarios Where nom_u='{user}' or con_u='{pass}';";
                if (cmd.ExecuteNonQuery() == -1) {
                    MySqlDataAdapter da = new MySqlDataAdapter();
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

        public void crear(string user, string pass)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Insert into usuarios (nom_u,con_u) values ('{user}','{pass}');";
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.InsertCommand = cmd;
                    MessageBox.Show($"El usuario {user}. Fue creado con exito");
                }
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

        public DataTable? mostrar()
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From usuarios;";
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                desconectado();
            }
        }

        public void eliminar(int id,string user)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Delete from Usuarios where id_Usuario={id}";
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.DeleteCommand = cmd;
                    MessageBox.Show($"El usuario {user} fue eliminado con exito");
                }
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
