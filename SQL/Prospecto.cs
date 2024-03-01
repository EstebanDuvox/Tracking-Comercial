using MySql.Data.MySqlClient;
using System.Data;

namespace Tracking_Comercial.SQL
{
    internal class Prospecto : ConexionS
    {
        public List<string>? listP()
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = "Select Pros from prospectos";
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

        public void crear(string pros, string pass)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Insert into prospectos(nom_u,con_u) values ('{pros}','{pass}');";
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.InsertCommand = cmd;
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show($"El prospecto {pros}. Fue creado con exito");
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
                cmd.CommandText = "Select * From prospectos;";
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

        public void eliminar(int id, string pros)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Delete from prospectos where id_prospecto={id}";
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.DeleteCommand = cmd;
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show($"El prospecto {pros} fue eliminado con exito");
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
                cmd.CommandText = $"Select * From prospectos Where {campo}='{sol}';";
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

        public void Actualizar(string id, string txt1, string txt2, bool cb1, bool cb2)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                if (cb1 == true && cb2 == false)
                {
                    cmd.CommandText = $"Update prospectos set Con_U='{txt1}' Where Nom_U='{id}';";
                }
                else if (cb1 == true && cb2 == true)
                {
                    cmd.CommandText = $"Update prospectos set Con_U='{txt1}',Tipo_U='{txt2}' Where Nom_U='{id}';";
                }
                else if (cb1 == false && cb2 == true)
                {
                    cmd.CommandText = $"Update prospectos set Tipo_U='{txt2}' Where Nom_U='{id}'";
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
                mostrar();
                desconectado();
            }
        }
    }
}