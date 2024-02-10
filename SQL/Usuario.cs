using System.Data;
using MySql.Data.MySqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Usuario : Conexiones
    { //Heredo la clase de conexiones

        public List<string>? listU()
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = "Select Nom_U from usuarios";
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    List<string> lu = dt.AsEnumerable().Select(x => x.ToString()).ToList();
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
                cmd.CommandText = $"Select * From usuarios Where nom_u='{user}' or con_u='{pass}';";
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
                cmd.CommandText = "Select * From usuarios;";
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

        public void eliminar(string id)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Delete from Usuarios where Nom_U='{id}'";
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.DeleteCommand = cmd;
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

        public void modificar(string id, string txt1, string txt2, bool cb1, bool cb2)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                if (cb1 == true && cb2 == false)
                {
                    cmd.CommandText = $"Update Usuarios set con_U='{txt1}' Where Nom_U='{id}';";
                }
                else if (cb1 == true && cb2 == true)
                {
                    cmd.CommandText = $"Update Usuarios set con_U='{txt1}',Tipo_U='{txt2}' Where Nom_U='{id}';";
                }
                else if (cb1 == false && cb2 == true)
                {
                    cmd.CommandText = $"Update Usuarios set Tipo_U='{txt2}' where Nom_U='{id}'";
                }
                else
                {
                    MessageBox.Show("Marque una casilla, por favor.");
                    desconectado();
                }
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.UpdateCommand = cmd;
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
