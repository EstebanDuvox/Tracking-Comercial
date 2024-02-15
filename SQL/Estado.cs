using MySql.Data.MySqlClient;
using System.Data;

namespace Tracking_Comercial.SQL
{
    internal class Estado : Conexiones
    {
        public DataTable? mostrar()
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = "Select * From estados;";
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

        public void subar(int id)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string fileContent;
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "odt files (*.odt)|*.odt|doc files (*.doc)|*.doc|docx files (*.docx)|*.docx|pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 5;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        try
                        {
                            conectado();
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = cc;
                            cmd.CommandText = $"Update set ar_E='{fileContent}' From estados Where id_estado={id}";
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
        }

        public DataTable? buscar(string campo, string sol)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                cmd.CommandText = $"Select * From estados Where {campo}='{sol}';";
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

        public void Actualizar(string id, string txt1, string txt2, string txt3, bool ch1, bool ch2, bool ch3)
        {
            try
            {
                conectado();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cc;
                if (ch1 == true && ch2 == false && ch3 == false)
                {
                    cmd.CommandText = $"Update estados set nom_E='{txt1}' Where id_perfil='{id}';";
                }
                else if (ch1 == true && ch2 == true && ch3 == false)
                {
                    cmd.CommandText = $"Update estados set nom_E='{txt1}',nom_C='{txt2}' Where id_perfil='{id}';";
                }
                else if (ch1 == true && ch2 == false && ch3 == true)
                {
                    cmd.CommandText = $"Update estados set nom_E'{txt1}',ap_C='{txt3}' Where id";
                }
                else if (ch1 == true && ch2 == true && ch3 == true)
                {
                    cmd.CommandText = $"Update estados set nom_E='{txt1}',nom_C='{txt2}',ap_C='{txt3}' Where id_perfil='{id}';";
                }
                else if (ch1 == false && ch2 == true && ch3 == false)
                {
                    cmd.CommandText = $"Update estados set nom_C='{txt2}' Where id_perfil='{id}';";
                }
                else if (ch1 == false && ch2 == true && ch3 == true)
                {
                    cmd.CommandText = $"Update estados set nom_C='{txt2}',ap_C='{txt3}' Where id_perfil='{id}';";
                }
                else if (ch1 == false && ch2 == false && ch3 == true)
                {
                    cmd.CommandText = $"Update estados set ap_C='{txt3}' Where id_perfil='{id}';";
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
                    MessageBox.Show("El estado del prospecto se ha actualizado exitosamente.");
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