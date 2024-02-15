using MySql.Data.MySqlClient;

namespace Tracking_Comercial.SQL
{
    internal class Conexiones : Para
    {
        protected MySqlConnection cc;// declaro interfaz de conexion para MySQL

        public bool conectado()
        {
            try
            {
                Para opara = new Para(); //declaro variable para el parametro
                opara.Conexion = "Server='127.0.0.1';Database='tc';User Id=root; Password='';"; //Ingreso los datos del servidor de MySQL
                cc = new MySqlConnection(opara.Conexion); //Asigno los datos a la interfaz
                cc.Open();//abro la conexion
                return true;//se muestra que la conexion se realizo con exito
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// se muestra un mensaje en caso de que no se logre la conexion.
                return false;//se muestra que no se logro concretar la conexion.
            }
        }

        public bool desconectado()
        {
            try
            {
                if (cc.State == System.Data.ConnectionState.Open) //comprueba si la esta conectado a la DB
                {
                    cc.Close(); //cierra la conexion
                    return true;//muestra el que se cerro con exito
                }
                else
                {
                    return false;//muestra que no estaba conectada a la DB
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //se muestra un msg en caso de no encontrar el srv de MySQL
                return false;
            }
        }
    }
}