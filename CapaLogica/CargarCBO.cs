using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;

namespace CapaLogica
{
    class CargarCBO
    {
        public void CargarCBOBase(string sentencia,ComboBox cbo )
        {
            ConsultasBD consulta = new ConsultasBD();
            consulta.consultarBD_En_Instancia(sentencia);
            cbo.Items.Add(sentencia);

        }


    }
}
