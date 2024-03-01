using MySql.Data.MySqlClient;
using System.Data;
using Miracle.FileZilla.Api;
using System.Net.Http.Json;

namespace Tracking_Comercial.SQL
{
    internal class Usuario : ConexionS
    { //Heredo la clase de conexiones
        public List<string>? listU()
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = "Select Nom_U from usuarios";
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                List<string> lu = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();
                if (cmd.ExecuteNonQuery() == -1)
                {
                    return lu;
                }
                else { return null; }
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

        public DataTable? ingresar(string user, string pass)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand(); //declaro variable para el comando a ejecutar
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From usuarios Where Nom_U='{user}' or Con_U='{pass}';";
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (cmd.ExecuteNonQuery() == -1)
                {
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
        public void crear(string user, string pass)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Insert into usuarios (Nom_U,Con_U) values ('{user}','{pass}');";
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.InsertCommand = cmd;
                if (cmd.ExecuteNonQuery() != -1)
                {
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
                cmd.CommandText = "Select * From usuarios;";
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (cmd.ExecuteNonQuery() == -1)
                {
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

        public void eliminar(string id)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Delete from usuarios Where Nom_U='{id}'";
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.DeleteCommand = cmd;
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show($"El usuario '{id}' fue eliminado con exito");
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

        public DataTable? buscar(string campo, string sol)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From usuarios Where {campo}='{sol}';";
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (cmd.ExecuteNonQuery() == -1)
                {
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

        public void modificar(string id, string txt1, string txt2, bool cb1, bool cb2)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                if (cb1 == true && cb2 == false)
                {
                    cmd.CommandText = $"Update usuarios set Con_U='{txt1}' Where Nom_U='{id}';";
                }
                else if (cb1 == true && cb2 == true)
                {
                    cmd.CommandText = $"Update usuarios set Con_U='{txt1}',Tipo_U='{txt2}' Where Nom_U='{id}';";
                }
                else if (cb1 == false && cb2 == true)
                {
                    cmd.CommandText = $"Update usuarios set Tipo_U='{txt2}' Where Nom_U='{id}'";
                }
                else
                {
                    MessageBox.Show("Marque una casilla, por favor.");
                    desconectado();
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.UpdateCommand = cmd;
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("Los datos del usuario se han actualizado exitosamente.");
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