using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;
using System.Threading;
namespace CapaLogica
{
    public class Metodos
    {
        private ThreadStart prueba;
        private Thread hilo;
        public void conectarConBase(string baseSeleccionada, string server)
        {
            ConexionBD cbd = new ConexionBD();
            string cadenaConex = "Data Source=" + server + ";Initial Catalog=" + baseSeleccionada + ";Integrated Security=True";
            cbd.conexionBDSeleccionada( cadenaConex);
        }

        private void llenarProgress(int valor, ProgressBar barra)
        {

            barra.Value = valor;

        }

        public void ejecucionProgressBar(NumericUpDown hilos, ProgressBar barra, NumericUpDown sentencias)
        {
            int val = Convert.ToInt32(hilos.Value);
            ConexionBD cbd = new ConexionBD();
            cbd.setSentencias(sentencias);
            llenarProgress(0,barra);
            for (int i = 0; i < val; i++)
            {

                prueba = new ThreadStart(cbd.EnviarConsulta);
                hilo = new Thread(prueba);
                hilo.Start();
                Thread.Sleep(100);
                llenarProgress(i,barra);
            }

            llenarProgress(100, barra);

        }

    }
}
