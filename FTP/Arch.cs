using FluentFTP;
using Tracking_Comercial.FTP;

namespace Tracking_Comercial.Filezilla
{
    internal class Arch : ConexionF
    {
        private FtpClient client;

        public void subir(string pros)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                var path = file.FileName;
                try
                {
                    conectado();
                    client.UploadFile(path, $".\\{pros}");
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

        public void descargar(string nomar, string pros)
        {
            var user = Environment.UserName;
            try
            {
                conectado();
                client.DownloadFile($"C:\\Users\\{user}\\Downloads", $".\\{pros}\\{nomar}");
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

        public void eliminar(string nomar, string pros)
        {
            try
            {
                conectado();
                client.DeleteFile($".\\{pros}\\{nomar}");
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
        //public List<string> lista(string pros)
        //{
        //    try
        //    {
        //        conectado();
        //        return client.GetListing($".\\{pros}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //    finally { desconectado() ; }
        //}
    }
}