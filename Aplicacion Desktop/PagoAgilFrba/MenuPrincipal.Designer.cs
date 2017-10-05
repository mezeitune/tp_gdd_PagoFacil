namespace PagoAgilFrba
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonABMCliente = new System.Windows.Forms.Button();
            this.botonABMSucursal = new System.Windows.Forms.Button();
            this.botonABMEmpresa = new System.Windows.Forms.Button();
            this.botonABMFactura = new System.Windows.Forms.Button();
            this.botonABMRol = new System.Windows.Forms.Button();
            this.botonListadoEstadistico = new System.Windows.Forms.Button();
            this.botonRegistrarPago = new System.Windows.Forms.Button();
            this.botonRendicion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonABMCliente
            // 
            this.botonABMCliente.Location = new System.Drawing.Point(56, 54);
            this.botonABMCliente.Name = "botonABMCliente";
            this.botonABMCliente.Size = new System.Drawing.Size(101, 55);
            this.botonABMCliente.TabIndex = 0;
            this.botonABMCliente.Text = "ABM Cliente";
            this.botonABMCliente.UseVisualStyleBackColor = true;
            this.botonABMCliente.Click += new System.EventHandler(this.botonABMCliente_Click);
            // 
            // botonABMSucursal
            // 
            this.botonABMSucursal.Location = new System.Drawing.Point(251, 54);
            this.botonABMSucursal.Name = "botonABMSucursal";
            this.botonABMSucursal.Size = new System.Drawing.Size(101, 55);
            this.botonABMSucursal.TabIndex = 1;
            this.botonABMSucursal.Text = "ABM Sucursal";
            this.botonABMSucursal.UseVisualStyleBackColor = true;
            this.botonABMSucursal.Click += new System.EventHandler(this.botonABMSucursal_Click);
            // 
            // botonABMEmpresa
            // 
            this.botonABMEmpresa.Location = new System.Drawing.Point(56, 161);
            this.botonABMEmpresa.Name = "botonABMEmpresa";
            this.botonABMEmpresa.Size = new System.Drawing.Size(101, 55);
            this.botonABMEmpresa.TabIndex = 2;
            this.botonABMEmpresa.Text = "ABM Empresa";
            this.botonABMEmpresa.UseVisualStyleBackColor = true;
            this.botonABMEmpresa.Click += new System.EventHandler(this.botonABMEmpresa_Click);
            // 
            // botonABMFactura
            // 
            this.botonABMFactura.Location = new System.Drawing.Point(251, 161);
            this.botonABMFactura.Name = "botonABMFactura";
            this.botonABMFactura.Size = new System.Drawing.Size(101, 55);
            this.botonABMFactura.TabIndex = 3;
            this.botonABMFactura.Text = "ABM Factura";
            this.botonABMFactura.UseVisualStyleBackColor = true;
            this.botonABMFactura.Click += new System.EventHandler(this.botonABMFactura_Click);
            // 
            // botonABMRol
            // 
            this.botonABMRol.Location = new System.Drawing.Point(56, 263);
            this.botonABMRol.Name = "botonABMRol";
            this.botonABMRol.Size = new System.Drawing.Size(101, 55);
            this.botonABMRol.TabIndex = 4;
            this.botonABMRol.Text = "ABM Rol";
            this.botonABMRol.UseVisualStyleBackColor = true;
            this.botonABMRol.Click += new System.EventHandler(this.botonABMRol_Click);
            // 
            // botonListadoEstadistico
            // 
            this.botonListadoEstadistico.Location = new System.Drawing.Point(536, 54);
            this.botonListadoEstadistico.Name = "botonListadoEstadistico";
            this.botonListadoEstadistico.Size = new System.Drawing.Size(101, 55);
            this.botonListadoEstadistico.TabIndex = 5;
            this.botonListadoEstadistico.Text = "Estadisticas";
            this.botonListadoEstadistico.UseVisualStyleBackColor = true;
            this.botonListadoEstadistico.Click += new System.EventHandler(this.botonListadoEstadistico_Click);
            // 
            // botonRegistrarPago
            // 
            this.botonRegistrarPago.Location = new System.Drawing.Point(536, 161);
            this.botonRegistrarPago.Name = "botonRegistrarPago";
            this.botonRegistrarPago.Size = new System.Drawing.Size(101, 55);
            this.botonRegistrarPago.TabIndex = 6;
            this.botonRegistrarPago.Text = "Resgistrar Pago";
            this.botonRegistrarPago.UseVisualStyleBackColor = true;
            this.botonRegistrarPago.Click += new System.EventHandler(this.botonRegistrarPago_Click);
            // 
            // botonRendicion
            // 
            this.botonRendicion.Location = new System.Drawing.Point(536, 263);
            this.botonRendicion.Name = "botonRendicion";
            this.botonRendicion.Size = new System.Drawing.Size(101, 55);
            this.botonRendicion.TabIndex = 7;
            this.botonRendicion.Text = "Rendir Factura";
            this.botonRendicion.UseVisualStyleBackColor = true;
            this.botonRendicion.Click += new System.EventHandler(this.botonRendicion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ABM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "OTRAS FUNCIONALIDADES";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRendicion);
            this.Controls.Add(this.botonRegistrarPago);
            this.Controls.Add(this.botonListadoEstadistico);
            this.Controls.Add(this.botonABMRol);
            this.Controls.Add(this.botonABMFactura);
            this.Controls.Add(this.botonABMEmpresa);
            this.Controls.Add(this.botonABMSucursal);
            this.Controls.Add(this.botonABMCliente);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonABMCliente;
        private System.Windows.Forms.Button botonABMSucursal;
        private System.Windows.Forms.Button botonABMEmpresa;
        private System.Windows.Forms.Button botonABMFactura;
        private System.Windows.Forms.Button botonABMRol;
        private System.Windows.Forms.Button botonListadoEstadistico;
        private System.Windows.Forms.Button botonRegistrarPago;
        private System.Windows.Forms.Button botonRendicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

