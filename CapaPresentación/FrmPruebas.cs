using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentación
{
    public partial class FrmPruebas : Form
    {
        private TimeSpan _start;

        public FrmPruebas()
        {
            InitializeComponent();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
                BtnCerrar.Visible = false;
                btnCancelar.Visible = true;
                Metodos met = new Metodos();
                met.ejecucionProgressBar(NumCantidadUsuarios, progressBarEjecucion, NumCantidadPruebas);
                _start = new TimeSpan(DateTime.Now.Ticks);
                ContadorTiempo();
        }

        private void txtCantidadPruebas_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BtnCerrar.Visible = true;
            btnCancelar.Visible = false;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal p = new FrmPrincipal();
            p.Show();
            this.Hide();
        }

        private void FrmPruebas_Load(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
        }

        private void NumCantidadPruebas_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void ContadorTiempo()
        {
            var end = new TimeSpan(DateTime.Now.Ticks);
           // DateTime.Now.Ticks
            end = end.Subtract(_start);
            var theTime = end.ToString();
            if (theTime.Length > 8)
                lblContadorTiempo.Text = theTime.Substring(0, 5);
            else
                lblContadorTiempo.Text = theTime + @".0000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
