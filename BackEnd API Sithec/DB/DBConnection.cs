using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqlConnectionServer
{
    public class DBConnection
    {
        //Cadena de Conexion
        public SqlConnection connection = new SqlConnection("Data Source=Localhost;Initial Catalog = API Sithec; Integrated Security=True;");

    
        //Metodo para abrir la conexion
        public void open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ", ex.Message);
            }
        }

            //Metodo para cerrar la conexion
        public void close()
        {
            connection.Close();
        }
    }
}
