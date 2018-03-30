using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnVolverMenuInicial_Click(object sender, EventArgs e)
        {
            FrmMenuInicial MI = new FrmMenuInicial();
            MI.Show();
            this.Hide();
        }

        private void BtnCrearTablas_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificacionTablas_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarTablas_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionBaseDatos_Click(object sender, EventArgs e)
        {
            FrmConectarBD cbd = new FrmConectarBD();
            cbd.Show();
            this.Hide();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            reportes.Show();
            this.Hide();
        }

        private void BtnPruebas_Click(object sender, EventArgs e)
        {
            FrmPruebas p = new FrmPruebas();
            p.Show();
            this.Hide();
        }
    }
}
