using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PagoAgilFrba
{
    static class Program
    {

       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(){

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          
            SQLManager manager = new SQLManager();
        

            Application.Run(new FormLogin());
        }

        public static SqlConnection conexion()
        {
            string configuracion = ConfigurationManager.AppSettings["configuracionSQL"].ToString();
            SqlConnection laConexion = new SqlConnection(configuracion);
            try
            {
                laConexion.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error al intentar establacer conexión con la base de datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(exitCode: 1);
            }
            return laConexion;
        }

        public static DateTime fechaHoy()
        {
            return DateTime.ParseExact(ConfigurationManager.AppSettings["FechaSistema"], "yyyy-dd-MM HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
