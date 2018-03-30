using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;

namespace CapaLogica
{
    public class CargarCBO
    {
        public void CargarCBOBase(ComboBox cbo)
        {
            
            ConsultasBD consulta = new ConsultasBD();
            consulta.consultarBD_En_Instancia(cbo);
           


        }




    }
}
