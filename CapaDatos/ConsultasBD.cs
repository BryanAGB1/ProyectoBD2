using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConsultasBD
    {
        
        public void consultarBD_En_Instancia(String sentencia)
        {
            SqlConnection conex = new SqlConnection();
            //llamar para conectarse a la instancia

            string comando = "SELECT name " +
                "FROM master..sysdatabases " +
                "ORDER BY name";
            List < string > bases= new List<string>();
            SqlCommand comandoSQL = new SqlCommand(comando, conex);

            try
            {

            }
            catch(SqlException ex)
            {

            }
             


        }
    }

}
