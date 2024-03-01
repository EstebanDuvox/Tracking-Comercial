using FluentFTP;

namespace Tracking_Comercial.FTP
{
    internal class ConexionF
    {
        public void conectado()
        {
            var con = new FtpClient("127.0.0.1", "Tester", "Himalaya");
            try
            {
                con.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void desconectado()
        {
            var con = new FtpClient("127.0.0.1", "Tester", "Himalaya");
            try
            {
                if (con.IsConnected == true)
                {
                    con.Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}