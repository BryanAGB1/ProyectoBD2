using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class ConsultasBD
    {
        
        public void consultarBD_En_Instancia(ComboBox cbo )
        {
            //Cambiar esto por el metodo de conectarse a la instancia
            SqlConnection conex = new SqlConnection();
            //llamar para conectarse a la instancia

            string comando = 
                "SELECT name " +
                "FROM master..sysdatabases " +
                "ORDER BY name";
            List < string > bases= new List<string>();
            SqlCommand comandoSQL = new SqlCommand(comando, conex);

            try
            {
                conex.Open();
                SqlDataReader reader = comandoSQL.ExecuteReader();

                while (reader.Read())
                    bases.Add((string)reader[0]);
            }
            catch(SqlException ex)
            {
                if (ex.Number != 4060)
                    MessageBox.Show("Conexión Fallida");
                else
                {
                    
                    cbo.Items.Clear();
                    return;
                }
            }
            cbo.DataSource = bases.ToArray();





        }
    }

}
