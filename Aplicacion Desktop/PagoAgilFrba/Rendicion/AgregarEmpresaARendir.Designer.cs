namespace PagoAgilFrba.Rendicion
{
    partial class AgregarEmpresaARendir
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
            this.BajaLogicaCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNroFactura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(296, 165);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 66;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // BajaLogicaCliente
            // 
            this.BajaLogicaCliente.Location = new System.Drawing.Point(139, 139);
            this.BajaLogicaCliente.Name = "BajaLogicaCliente";
            this.BajaLogicaCliente.Size = new System.Drawing.Size(96, 38);
            this.BajaLogicaCliente.TabIndex = 65;
            this.BajaLogicaCliente.Text = "Agregar Factura";
            this.BajaLogicaCliente.UseVisualStyleBackColor = true;
            this.BajaLogicaCliente.Click += new System.EventHandler(this.AgregarFacturaARendir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Numero de Factura";
            // 
            // comboBoxNroFactura
            // 
            this.comboBoxNroFactura.FormattingEnabled = true;
            this.comboBoxNroFactura.Location = new System.Drawing.Point(139, 75);
            this.comboBoxNroFactura.Name = "comboBoxNroFactura";
            this.comboBoxNroFactura.Size = new System.Drawing.Size(212, 21);
            this.comboBoxNroFactura.TabIndex = 63;
            this.comboBoxNroFactura.SelectedIndexChanged += new System.EventHandler(this.comboBoxNroFacturaModif_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Elija una Factura a Rendir";
            // 
            // AgregarEmpresaARendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 189);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.BajaLogicaCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNroFactura);
            this.Controls.Add(this.label1);
            this.Name = "AgregarEmpresaARendir";
            this.Text = "AgregarEmpresaARendir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button BajaLogicaCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNroFactura;
        private System.Windows.Forms.Label label1;
    }
}