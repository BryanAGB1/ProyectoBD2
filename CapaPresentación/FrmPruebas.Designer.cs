namespace CapaPresentación
{
    partial class FrmPruebas
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
            this.lblTipoPrueba = new System.Windows.Forms.Label();
            this.cboPruebas = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarEjecucion = new System.Windows.Forms.ProgressBar();
            this.lblContadorTiempo = new System.Windows.Forms.Label();
            this.lblContadorExitosas = new System.Windows.Forms.Label();
            this.lblContadorFallidas = new System.Windows.Forms.Label();
            this.lblCuantasPruebas = new System.Windows.Forms.Label();
            this.NumCantidadPruebas = new System.Windows.Forms.NumericUpDown();
            this.lblProgreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadPruebas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoPrueba
            // 
            this.lblTipoPrueba.AutoSize = true;
            this.lblTipoPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrueba.Location = new System.Drawing.Point(107, 16);
            this.lblTipoPrueba.Name = "lblTipoPrueba";
            this.lblTipoPrueba.Size = new System.Drawing.Size(140, 24);
            this.lblTipoPrueba.TabIndex = 0;
            this.lblTipoPrueba.Text = "Tipo de prueba";
            // 
            // cboPruebas
            // 
            this.cboPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPruebas.FormattingEnabled = true;
            this.cboPruebas.Location = new System.Drawing.Point(109, 57);
            this.cboPruebas.Name = "cboPruebas";
            this.cboPruebas.Size = new System.Drawing.Size(500, 28);
            this.cboPruebas.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 400);
            this.textBox1.TabIndex = 2;
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjecutar.Location = new System.Drawing.Point(672, 189);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(503, 100);
            this.BtnEjecutar.TabIndex = 3;
            this.BtnEjecutar.Text = "Ejecutar prueba";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(673, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(503, 100);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar Prueba";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTotal.Location = new System.Drawing.Point(106, 494);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(258, 25);
            this.lblTiempoTotal.TabIndex = 5;
            this.lblTiempoTotal.Text = "Tiempo total de ejecución";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Interaciones completadas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Interaciones fallidas";
            // 
            // progressBarEjecucion
            // 
            this.progressBarEjecucion.Location = new System.Drawing.Point(672, 466);
            this.progressBarEjecucion.Name = "progressBarEjecucion";
            this.progressBarEjecucion.Size = new System.Drawing.Size(500, 110);
            this.progressBarEjecucion.TabIndex = 8;
            // 
            // lblContadorTiempo
            // 
            this.lblContadorTiempo.AutoSize = true;
            this.lblContadorTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorTiempo.Location = new System.Drawing.Point(583, 491);
            this.lblContadorTiempo.Name = "lblContadorTiempo";
            this.lblContadorTiempo.Size = new System.Drawing.Size(26, 29);
            this.lblContadorTiempo.TabIndex = 9;
            this.lblContadorTiempo.Text = "0";
            // 
            // lblContadorExitosas
            // 
            this.lblContadorExitosas.AutoSize = true;
            this.lblContadorExitosas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorExitosas.Location = new System.Drawing.Point(583, 533);
            this.lblContadorExitosas.Name = "lblContadorExitosas";
            this.lblContadorExitosas.Size = new System.Drawing.Size(26, 29);
            this.lblContadorExitosas.TabIndex = 10;
            this.lblContadorExitosas.Text = "0";
            // 
            // lblContadorFallidas
            // 
            this.lblContadorFallidas.AutoSize = true;
            this.lblContadorFallidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorFallidas.Location = new System.Drawing.Point(583, 575);
            this.lblContadorFallidas.Name = "lblContadorFallidas";
            this.lblContadorFallidas.Size = new System.Drawing.Size(26, 29);
            this.lblContadorFallidas.TabIndex = 11;
            this.lblContadorFallidas.Text = "0";
            // 
            // lblCuantasPruebas
            // 
            this.lblCuantasPruebas.AutoSize = true;
            this.lblCuantasPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuantasPruebas.Location = new System.Drawing.Point(669, 79);
            this.lblCuantasPruebas.Name = "lblCuantasPruebas";
            this.lblCuantasPruebas.Size = new System.Drawing.Size(274, 24);
            this.lblCuantasPruebas.TabIndex = 12;
            this.lblCuantasPruebas.Text = "Cuantas pruebas desea realizar";
            // 
            // NumCantidadPruebas
            // 
            this.NumCantidadPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCantidadPruebas.Location = new System.Drawing.Point(672, 136);
            this.NumCantidadPruebas.Name = "NumCantidadPruebas";
            this.NumCantidadPruebas.Size = new System.Drawing.Size(503, 31);
            this.NumCantidadPruebas.TabIndex = 13;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.Location = new System.Drawing.Point(667, 423);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(261, 25);
            this.lblProgreso.TabIndex = 14;
            this.lblProgreso.Text = "Progreso en las ejecución";
            // 
            // FrmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.NumCantidadPruebas);
            this.Controls.Add(this.lblCuantasPruebas);
            this.Controls.Add(this.lblContadorFallidas);
            this.Controls.Add(this.lblContadorExitosas);
            this.Controls.Add(this.lblContadorTiempo);
            this.Controls.Add(this.progressBarEjecucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTiempoTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboPruebas);
            this.Controls.Add(this.lblTipoPrueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPruebas";
            this.Text = "FrmPruebas";
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadPruebas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPrueba;
        private System.Windows.Forms.ComboBox cboPruebas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarEjecucion;
        private System.Windows.Forms.Label lblContadorTiempo;
        private System.Windows.Forms.Label lblContadorExitosas;
        private System.Windows.Forms.Label lblContadorFallidas;
        private System.Windows.Forms.Label lblCuantasPruebas;
        private System.Windows.Forms.NumericUpDown NumCantidadPruebas;
        private System.Windows.Forms.Label lblProgreso;
    }
}