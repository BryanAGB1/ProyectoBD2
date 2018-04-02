using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CapaLogica
{
    public class CargarCBO
    {
        public void CargarCBOBase(ComboBox cbo, string server)
        {

            //ConsultasBD consulta = new ConsultasBD();
            //consulta.consultarBD_En_Instancia(cbo);
            string sql = "" +
               "SELECT name " +
               "FROM master..sysdatabases " +
               "ORDER BY name";

            ConexionBD cbd = new ConexionBD();
            cbd.ejecucionVerBasesDisponibles(sql, cbo,server);

        }

        public void ConseguirInstancias(ComboBox cbo)
        {
            RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");
            List<string> instancias = new List<string>();
            string instancia = "";
            foreach (string s in key.GetValueNames())
            {
                instancia = Environment.MachineName + "\\" + s;
                instancias.Add(instancia);
            }
            cbo.DataSource = instancias.ToArray();

            key.Close();
            baseKey.Close();
        }


    }
}
