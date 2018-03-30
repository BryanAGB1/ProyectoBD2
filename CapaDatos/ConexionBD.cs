using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    class ConexionBD
    {
        SqlConnection conn;
        
        public void conectar()
        {
            //String conexion = "Data Source = BRYANPC\\SQL2016; Initial Catalog = UIAWK03; Integrated Security = True";
            String conexion = "SELECT databases.name FROM sys.databases WHERE databases.state = 0 ORDER BY databases.name";
            conn = new SqlConnection(conexion);

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
            }
        }

        public void desconectar()
        {
            conn.Close();
        }

        internal void insertar(String consulta)
        {
            conectar();
            SqlCommand comando = new SqlCommand(consulta, conn);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            desconectar();
        }

        internal void insertar(SqlCommand comando)
        {
            conectar();
            comando.Connection = conn;
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Detecto el error y notifico al usuario.
            }
            desconectar();
        }

        public DataTable consultar(String consulta)
        {
            conectar();
            SqlCommand comando = new SqlCommand(consulta, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            desconectar();
            return dt;
        }
    }//fin cls conexcion
}
