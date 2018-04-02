using System;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FrmMenuInicial : Form
    {
        public FrmMenuInicial()
        {
            InitializeComponent();
            
        }

        private void BtnIniciar_Click(object sender, System.EventArgs e)
        {
            FrmPrincipal p = new FrmPrincipal();
            p.Show();
            this.Hide();
            string msg = "Para poder realizar pruebas con esta aplicacion, necesitaras lo siguiente: \r\n-Una base de datos en SQL server \r\n-SQL Server instalado en la maquina \r\n-Permisos de administrador";
            MessageBox.Show(msg);
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuInicial_Load(object sender, System.EventArgs e)
        {
           //vamo a ver si funca
        }
    }
}
