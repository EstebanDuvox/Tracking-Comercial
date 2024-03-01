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
                cmd.CommandText = "Select prospecto from prospectos";
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

        public void crear(string pros, string des, string esp, string lim, int pres)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Insert into prospectos(prospecto,descr_nec_p,esp_tec_sol_c,fecha_lim,pres_lim) values ('{pros}','{des}','{esp}','{lim}','{pres}');";
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
                //cmd.CommandText = "Select prospectos.prospecto,perfiles.nom_e,perfiles.nom_c,perfiles.ap_c,prospectos.descr_nec_p,prospectos.esp_tec_sol_c,prospectos.fecha_lim,prospectos.pres_lim From prospectos,perfiles Where prospectos.id_perfil=perfiles.id_perfil;";
                cmd.CommandText = "select * from prospectos";
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

        public void eliminar(string id, string pros)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Delete from prospectos Where prospecto={id}";
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

        public void Actualizar(string pros, string des, string esp, string lim, int pres, bool ch1, bool ch2, bool ch3, bool ch4)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                if (ch1 == true && ch2 == false && ch3 == false && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}' Where prospecto='{pros}';";
                }
                else if (ch1 == true && ch2 == true && ch3 == false && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}', esp_tec_sol_c='{esp}' Where prospecto='{pros}';";
                }
                else if (ch1 == true && ch2 == true && ch3 == true && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}', esp_tec_sol_c='{esp}',fecha_lim='{lim}' Where prospecto='{pros}'";
                }
                else if (ch1 == true && ch2 == true && ch3 == true && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}', esp_tec_sol_c='{esp}',fecha_lim='{lim}', pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 == false && ch2 == true && ch3 == false && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set esp_tec_sol_c='{esp}' Where prospecto='{pros}'";
                }
                else if (ch1 == false && ch2 == true && ch3 == true && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set esp_tec_sol_c='{esp}', fecha_lim='{lim}' Where prospecto='{pros}'";
                }
                else if (ch1 == false && ch2 == true && ch3 == true && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set esp_tec_sol_c='{esp}',fecha_lim='{lim}', pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 == false && ch2 == false && ch3 == true && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set fecha_lim='{lim}' Where prospecto='{pros}'";
                }
                else if (ch1 == false && ch2 == false && ch3 == true && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set fecha_lim='{lim}', pres_lim= '{pres}' Where prospecto='{pros}'";

                }
                else if (ch1 == false && ch2 == false && ch3 == false && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 == true && ch2 == true && ch3 == true && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}', esp_tec_sol_c='{esp}',fecha_lim='{lim}', pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 == true && ch2 == false && ch3 == true && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}',fecha_lim='{lim}', pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 == true && ch2 == false && ch3 == false && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}', pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 = false && ch2 == true && ch3 == false && ch4 == true)
                {
                    cmd.CommandText = $"Update prospectos set  esp_tec_sol_c='{esp}', pres_lim= '{pres}' Where prospecto='{pros}'";
                }
                else if (ch1 == true && ch2 == false && ch3 == true && ch4 == false)
                {
                    cmd.CommandText = $"Update prospectos set descr_nec_p='{des}', fecha_lim='{lim}' Where prospecto='{pros}'";
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