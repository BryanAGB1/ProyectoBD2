using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class Metodos
    {
        public void conectarConBase(string baseSeleccionada, string server)
        {
            ConexionBD cbd = new ConexionBD();
            string cadenaConex = "Data Source=" + server + ";Initial Catalog=" + baseSeleccionada + ";Integrated Security=True";
            cbd.conexionBDSeleccionada( cadenaConex);
        }
    }
}
