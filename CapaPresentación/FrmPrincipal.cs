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
    }
}
