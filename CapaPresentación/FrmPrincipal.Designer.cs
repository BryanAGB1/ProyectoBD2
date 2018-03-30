namespace CapaPresentación
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVolverMenuInicial = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnSeleccionBaseDatos = new System.Windows.Forms.Button();
            this.BtnPruebas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVolverMenuInicial
            // 
            this.BtnVolverMenuInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverMenuInicial.Location = new System.Drawing.Point(12, 146);
            this.BtnVolverMenuInicial.Name = "BtnVolverMenuInicial";
            this.BtnVolverMenuInicial.Size = new System.Drawing.Size(1240, 70);
            this.BtnVolverMenuInicial.TabIndex = 0;
            this.BtnVolverMenuInicial.Text = "Volver al inicio de la aplicación";
            this.BtnVolverMenuInicial.UseVisualStyleBackColor = true;
            this.BtnVolverMenuInicial.Click += new System.EventHandler(this.BtnVolverMenuInicial_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Location = new System.Drawing.Point(12, 236);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(1240, 70);
            this.BtnReportes.TabIndex = 9;
            this.BtnReportes.Text = "Reportes de las ejecuciones de pruebas anteriores ";
            this.BtnReportes.UseVisualStyleBackColor = true;
            // 
            // BtnSeleccionBaseDatos
            // 
            this.BtnSeleccionBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionBaseDatos.Location = new System.Drawing.Point(12, 337);
            this.BtnSeleccionBaseDatos.Name = "BtnSeleccionBaseDatos";
            this.BtnSeleccionBaseDatos.Size = new System.Drawing.Size(1240, 70);
            this.BtnSeleccionBaseDatos.TabIndex = 10;
            this.BtnSeleccionBaseDatos.Text = "Selección de base de datos";
            this.BtnSeleccionBaseDatos.UseVisualStyleBackColor = true;
            // 
            // BtnPruebas
            // 
            this.BtnPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPruebas.Location = new System.Drawing.Point(12, 435);
            this.BtnPruebas.Name = "BtnPruebas";
            this.BtnPruebas.Size = new System.Drawing.Size(1240, 70);
            this.BtnPruebas.TabIndex = 11;
            this.BtnPruebas.Text = "Realizar Pruebas";
            this.BtnPruebas.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BtnPruebas);
            this.Controls.Add(this.BtnSeleccionBaseDatos);
            this.Controls.Add(this.BtnReportes);
            this.Controls.Add(this.BtnVolverMenuInicial);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolverMenuInicial;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnSeleccionBaseDatos;
        private System.Windows.Forms.Button BtnPruebas;
    }
}