namespace PagoAgilFrba.AbmEmpresa
{
    partial class PantallaPrincipalABMEmpresa
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
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.Modificacion = new System.Windows.Forms.Button();
            this.Baja = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(189, 213);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(81, 27);
            this.volverALaPaginaAnterior.TabIndex = 7;
            this.volverALaPaginaAnterior.Text = "&Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // Modificacion
            // 
            this.Modificacion.Location = new System.Drawing.Point(12, 156);
            this.Modificacion.Name = "Modificacion";
            this.Modificacion.Size = new System.Drawing.Size(157, 43);
            this.Modificacion.TabIndex = 6;
            this.Modificacion.Text = "&Modificación";
            this.Modificacion.UseVisualStyleBackColor = true;
            this.Modificacion.Click += new System.EventHandler(this.Modificacion_Click);
            // 
            // Baja
            // 
            this.Baja.Location = new System.Drawing.Point(12, 87);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(157, 43);
            this.Baja.TabIndex = 5;
            this.Baja.Text = "&Baja";
            this.Baja.UseVisualStyleBackColor = true;
            this.Baja.Click += new System.EventHandler(this.Baja_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(12, 12);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(157, 46);
            this.Alta.TabIndex = 4;
            this.Alta.Text = "&Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // PantallaPrincipalABMEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 253);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.Modificacion);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.Alta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipalABMEmpresa";
            this.Text = "ABM Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaPrincipalABMEmpresa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button Modificacion;
        private System.Windows.Forms.Button Baja;
        private System.Windows.Forms.Button Alta;
    }
}