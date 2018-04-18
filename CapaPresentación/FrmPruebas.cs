using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentación
{
    public partial class FrmPruebas : Form
    {
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
    }
}
