using MySql.Data.MySqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Prospecto : Conexiones
    {
        public void crear(string pros, string pass)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Insert into prospectos(nom_u,con_u) values ('{pros}','{pass}');";
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.InsertCommand = cmd;
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

        public void eliminar(int id,string pros)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Delete from prospectos where id_prospecto={id}";
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.DeleteCommand = cmd;
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

        public DataTable? buscar(string campo,string sol) 
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From prospectos Where {campo}='{sol}';";
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

        
        public DataTable? Actualizar(int cant, string c1, string d1, string c2,string d2, string c3, string d3)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.connection = cc;
                if (cant == 1)
                {
                    cmd.CommandText = $"Update prospectos Set {c1}='{d1}';";
                }else if (cant == 2)
                {
                    cmd.CommandText = $"Update prospectos Set {c1}='{d1}',{c2}='{d2}';";
                }else 
                {
                    cmd.CommandText = $"Update prospectos Set {c1}='{d1}',{c2}='{d2}',{c3}='{d3}';";
                }
                if (cmd.ExecuteNonQuery != -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.UpdateCommand = cmd;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }finally
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = "Select * From prospectos;";
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    return dt;
                }
                desconectado();
            }
        }  
    }
}