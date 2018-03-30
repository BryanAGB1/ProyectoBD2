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
            string msg = "Para poder realizar pruebas con esta aplicacion, necesitaras lo siguiente: /n-Una base de datos en SQL server /n-SQL Server instalado en la maquina";
            MessageBox.Show(msg, Environment.NewLine);
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuInicial_Load(object sender, System.EventArgs e)
        {

        }
    }
}
