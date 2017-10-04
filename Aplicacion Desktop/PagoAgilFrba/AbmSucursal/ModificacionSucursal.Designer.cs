namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificacionSucursal
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buscaPorCodPostal = new System.Windows.Forms.Button();
            this.buscaPorDireccion = new System.Windows.Forms.Button();
            this.txtCodPostalSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaPorNombre = new System.Windows.Forms.Button();
            this.botonModificarSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 172);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // buscaPorCodPostal
            // 
            this.buscaPorCodPostal.Location = new System.Drawing.Point(418, 85);
            this.buscaPorCodPostal.Name = "buscaPorCodPostal";
            this.buscaPorCodPostal.Size = new System.Drawing.Size(130, 23);
            this.buscaPorCodPostal.TabIndex = 34;
            this.buscaPorCodPostal.Text = "Buscar por Cod Postal";
            this.buscaPorCodPostal.UseVisualStyleBackColor = true;
            this.buscaPorCodPostal.Click += new System.EventHandler(this.buscaPorCodPostal_Click);
            // 
            // buscaPorDireccion
            // 
            this.buscaPorDireccion.Location = new System.Drawing.Point(243, 85);
            this.buscaPorDireccion.Name = "buscaPorDireccion";
            this.buscaPorDireccion.Size = new System.Drawing.Size(131, 23);
            this.buscaPorDireccion.TabIndex = 33;
            this.buscaPorDireccion.Text = "Buscar por direccion";
            this.buscaPorDireccion.UseVisualStyleBackColor = true;
            this.buscaPorDireccion.Click += new System.EventHandler(this.buscaPorCodigoPostal_Click);
            // 
            // txtCodPostalSucursal
            // 
            this.txtCodPostalSucursal.Location = new System.Drawing.Point(418, 59);
            this.txtCodPostalSucursal.Name = "txtCodPostalSucursal";
            this.txtCodPostalSucursal.Size = new System.Drawing.Size(130, 20);
            this.txtCodPostalSucursal.TabIndex = 32;
            this.txtCodPostalSucursal.TextChanged += new System.EventHandler(this.txtCodPostal_TextChanged);
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(243, 59);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(131, 20);
            this.txtDireccionSucursal.TabIndex = 31;
            this.txtDireccionSucursal.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(55, 59);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(134, 20);
            this.txtNombreSucursal.TabIndex = 30;
            this.txtNombreSucursal.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ingrese el nombre, direccion o codigo postal para buscar una sucursal";
            // 
            // buscaPorNombre
            // 
            this.buscaPorNombre.Location = new System.Drawing.Point(55, 85);
            this.buscaPorNombre.Name = "buscaPorNombre";
            this.buscaPorNombre.Size = new System.Drawing.Size(134, 23);
            this.buscaPorNombre.TabIndex = 28;
            this.buscaPorNombre.Text = "Buscar por Nombre";
            this.buscaPorNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscaPorNombre.UseVisualStyleBackColor = true;
            this.buscaPorNombre.Click += new System.EventHandler(this.buscaPorNombre_Click);
            // 
            // botonModificarSucursal
            // 
            this.botonModificarSucursal.Location = new System.Drawing.Point(231, 357);
            this.botonModificarSucursal.Name = "botonModificarSucursal";
            this.botonModificarSucursal.Size = new System.Drawing.Size(125, 38);
            this.botonModificarSucursal.TabIndex = 27;
            this.botonModificarSucursal.Text = "Modificar Sucursal Seleccionada";
            this.botonModificarSucursal.UseVisualStyleBackColor = true;
            this.botonModificarSucursal.Click += new System.EventHandler(this.BajaLogicaSucursal_Click);
            // 
            // ModificacionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buscaPorCodPostal);
            this.Controls.Add(this.buscaPorDireccion);
            this.Controls.Add(this.txtCodPostalSucursal);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaPorNombre);
            this.Controls.Add(this.botonModificarSucursal);
            this.Name = "ModificacionSucursal";
            this.Text = "ModificacionSucursal";
            this.Load += new System.EventHandler(this.ModificacionSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buscaPorCodPostal;
        private System.Windows.Forms.Button buscaPorDireccion;
        private System.Windows.Forms.TextBox txtCodPostalSucursal;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscaPorNombre;
        private System.Windows.Forms.Button botonModificarSucursal;

    }
}