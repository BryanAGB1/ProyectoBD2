namespace CapaPresentación
{
    partial class FrmConectarBD
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
            this.cboBases = new System.Windows.Forms.ComboBox();
            this.lblBases = new System.Windows.Forms.Label();
            this.btnProbarConex = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBases
            // 
            this.cboBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBases.FormattingEnabled = true;
            this.cboBases.Location = new System.Drawing.Point(78, 186);
            this.cboBases.Name = "cboBases";
            this.cboBases.Size = new System.Drawing.Size(624, 41);
            this.cboBases.TabIndex = 0;
            // 
            // lblBases
            // 
            this.lblBases.AutoSize = true;
            this.lblBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBases.Location = new System.Drawing.Point(221, 154);
            this.lblBases.Name = "lblBases";
            this.lblBases.Size = new System.Drawing.Size(310, 29);
            this.lblBases.TabIndex = 1;
            this.lblBases.Text = "Bases de datos disponibles";
            // 
            // btnProbarConex
            // 
            this.btnProbarConex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConex.Location = new System.Drawing.Point(78, 295);
            this.btnProbarConex.Name = "btnProbarConex";
            this.btnProbarConex.Size = new System.Drawing.Size(624, 46);
            this.btnProbarConex.TabIndex = 2;
            this.btnProbarConex.Text = "Probar conexión";
            this.btnProbarConex.UseVisualStyleBackColor = true;
            this.btnProbarConex.Click += new System.EventHandler(this.btnProbarConex_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(78, 362);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(624, 46);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(78, 429);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(624, 46);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(78, 494);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(624, 46);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar formulario";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(78, 96);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(624, 38);
            this.txtServer.TabIndex = 6;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(84, 64);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(608, 29);
            this.lblServer.TabIndex = 7;
            this.lblServer.Text = "Ingrese el servidor con el que vas a realizar las pruebas";
            // 
            // FrmConectarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.btnProbarConex);
            this.Controls.Add(this.lblBases);
            this.Controls.Add(this.cboBases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConectarBD";
            this.Text = "FrmConectarBD";
            this.Load += new System.EventHandler(this.FrmConectarBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBases;
        private System.Windows.Forms.Label lblBases;
        private System.Windows.Forms.Button btnProbarConex;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
    }
}