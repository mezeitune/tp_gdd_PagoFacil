namespace PagoAgilFrba.AbmSucursal
{
    partial class BajaSucursal
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
            this.BajaLogicaSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(88, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 172);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // buscaPorCodPostal
            // 
            this.buscaPorCodPostal.Location = new System.Drawing.Point(405, 96);
            this.buscaPorCodPostal.Name = "buscaPorCodPostal";
            this.buscaPorCodPostal.Size = new System.Drawing.Size(130, 23);
            this.buscaPorCodPostal.TabIndex = 25;
            this.buscaPorCodPostal.Text = "Buscar por Cod Postal";
            this.buscaPorCodPostal.UseVisualStyleBackColor = true;
            this.buscaPorCodPostal.Click += new System.EventHandler(this.buscaPorCodPostal_Click);
            // 
            // buscaPorDireccion
            // 
            this.buscaPorDireccion.Location = new System.Drawing.Point(230, 96);
            this.buscaPorDireccion.Name = "buscaPorDireccion";
            this.buscaPorDireccion.Size = new System.Drawing.Size(131, 23);
            this.buscaPorDireccion.TabIndex = 24;
            this.buscaPorDireccion.Text = "Buscar por direccion";
            this.buscaPorDireccion.UseVisualStyleBackColor = true;
            this.buscaPorDireccion.Click += new System.EventHandler(this.buscaPorCodigoPostal_Click);
            // 
            // txtCodPostalSucursal
            // 
            this.txtCodPostalSucursal.Location = new System.Drawing.Point(405, 70);
            this.txtCodPostalSucursal.Name = "txtCodPostalSucursal";
            this.txtCodPostalSucursal.Size = new System.Drawing.Size(130, 20);
            this.txtCodPostalSucursal.TabIndex = 23;
            this.txtCodPostalSucursal.TextChanged += new System.EventHandler(this.txtCodPostal_TextChanged);
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(230, 70);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(131, 20);
            this.txtDireccionSucursal.TabIndex = 22;
            this.txtDireccionSucursal.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(42, 70);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(134, 20);
            this.txtNombreSucursal.TabIndex = 21;
            this.txtNombreSucursal.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ingrese el nombre, direccion o codigo postal para buscar una sucursal";
            // 
            // buscaPorNombre
            // 
            this.buscaPorNombre.Location = new System.Drawing.Point(42, 96);
            this.buscaPorNombre.Name = "buscaPorNombre";
            this.buscaPorNombre.Size = new System.Drawing.Size(134, 23);
            this.buscaPorNombre.TabIndex = 19;
            this.buscaPorNombre.Text = "Buscar por Nombre";
            this.buscaPorNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscaPorNombre.UseVisualStyleBackColor = true;
            this.buscaPorNombre.Click += new System.EventHandler(this.buscaPorNombre_Click);
            // 
            // BajaLogicaSucursal
            // 
            this.BajaLogicaSucursal.Location = new System.Drawing.Point(218, 368);
            this.BajaLogicaSucursal.Name = "BajaLogicaSucursal";
            this.BajaLogicaSucursal.Size = new System.Drawing.Size(96, 38);
            this.BajaLogicaSucursal.TabIndex = 18;
            this.BajaLogicaSucursal.Text = "Baja logica Sucursal";
            this.BajaLogicaSucursal.UseVisualStyleBackColor = true;
            this.BajaLogicaSucursal.Click += new System.EventHandler(this.BajaLogicaCliente_Click);
            // 
            // BajaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 438);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buscaPorCodPostal);
            this.Controls.Add(this.buscaPorDireccion);
            this.Controls.Add(this.txtCodPostalSucursal);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaPorNombre);
            this.Controls.Add(this.BajaLogicaSucursal);
            this.Name = "BajaSucursal";
            this.Text = "BajaSucursal";
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
        private System.Windows.Forms.Button BajaLogicaSucursal;
    }
}