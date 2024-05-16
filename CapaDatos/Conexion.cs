using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    return true; // Si la conexión se abre correctamente, devuelve true
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al probar la conexión: " + ex.Message);
                return false; // Si ocurre algún error al abrir la conexión, devuelve false
            }
        }
    }
}
