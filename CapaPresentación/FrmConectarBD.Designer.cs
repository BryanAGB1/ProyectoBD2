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
            this.SuspendLayout();
            // 
            // cboBases
            // 
            this.cboBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBases.FormattingEnabled = true;
            this.cboBases.Location = new System.Drawing.Point(78, 158);
            this.cboBases.Name = "cboBases";
            this.cboBases.Size = new System.Drawing.Size(624, 41);
            this.cboBases.TabIndex = 0;
            // 
            // lblBases
            // 
            this.lblBases.AutoSize = true;
            this.lblBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBases.Location = new System.Drawing.Point(171, 74);
            this.lblBases.Name = "lblBases";
            this.lblBases.Size = new System.Drawing.Size(438, 39);
            this.lblBases.TabIndex = 1;
            this.lblBases.Text = "Bases de datos disponibles";
            // 
            // btnProbarConex
            // 
            this.btnProbarConex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConex.Location = new System.Drawing.Point(78, 244);
            this.btnProbarConex.Name = "btnProbarConex";
            this.btnProbarConex.Size = new System.Drawing.Size(624, 46);
            this.btnProbarConex.TabIndex = 2;
            this.btnProbarConex.Text = "Probar conexión";
            this.btnProbarConex.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(78, 311);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(624, 46);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(78, 378);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(624, 46);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(78, 443);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(624, 46);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar formulario";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmConectarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.btnProbarConex);
            this.Controls.Add(this.lblBases);
            this.Controls.Add(this.cboBases);
            this.Name = "FrmConectarBD";
            this.Text = "FrmConectarBD";
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
    }
}