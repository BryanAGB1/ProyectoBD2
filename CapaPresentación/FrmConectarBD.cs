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
using Microsoft.Win32;

namespace CapaPresentación
{
    public partial class FrmConectarBD : Form
    {
        public FrmConectarBD()
        {
            InitializeComponent();
        }
        CargarCBO cargar = new CargarCBO();

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal p = new FrmPrincipal();
            p.Show();
            this.Hide();
        }

        private void FrmConectarBD_Load(object sender, EventArgs e)
        {
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
            cboBases.Items.Add("prueba");
            cargar.ConseguirInstancias(cboInstancias);

        }

        private void btnProbarConex_Click(object sender, EventArgs e)
        {
            if (cboInstancias.Text != ""&& cboBases.Text != "")
            {   
                    BtnAceptar.Visible = true;
                    BtnCancelar.Visible = true;
               
                
            }
            else
            {
                MessageBox.Show("Por favor ingresa datos para poder probar la conexion");
            }
        }

        private void cboBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscarBases_Click(object sender, EventArgs e)
        {
            string server = cboInstancias.Text;
            CargarCBO cargar = new CargarCBO();
            cargar.CargarCBOBase(cboBases, server);


        }
    }
}
