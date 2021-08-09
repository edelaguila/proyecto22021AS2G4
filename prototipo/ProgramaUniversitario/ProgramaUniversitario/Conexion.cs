using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramaUniversitario
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=Proyecto");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Conectó");
            }
            return conn;
        }
        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }

        public static MySqlConnection conex()
        {
            string servidor = "server=den1.mysql2.gear.host; database=pruebauni; Uid=pruebauni; pwd=Sl00JJ~~iznm";

            MySqlConnection conexionBD = new MySqlConnection(servidor);

            try
            {
                return conexionBD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }


        }

    }
}