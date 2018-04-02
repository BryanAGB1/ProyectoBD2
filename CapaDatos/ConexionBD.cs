using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class ConexionBD
    {

        SqlConnection conex;
        string baseUtilizar = "master";

        public void conectarbd( string cadenaConex)
        {
           
            conex = new SqlConnection(cadenaConex);
            
            try
            {
                conex.Open();
                MessageBox.Show("Conexion realizada");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Conexion NO realizada, ERROR EN LA CONEXION CON EL SERVIDOR");
            }
        }

        public void ejecucionVerBasesDisponibles(string comandoEjecutar, ComboBox cbo ,string server)
            
        {
            //server = "FRANPC-2017\\SQLEXPRESS";

            string cadenaConex = "Data Source="+server+";Initial Catalog="+baseUtilizar+";Integrated Security=True";
            conectarbd(cadenaConex);
            SqlCommand comando = new SqlCommand(comandoEjecutar, conex);
            List<string> databases = new List<string>();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    databases.Add((string)reader[0]);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados");
            }
            reader.Close();
            cbo.DataSource = databases.ToArray();
        }

    }//fin cls conexcion


}
