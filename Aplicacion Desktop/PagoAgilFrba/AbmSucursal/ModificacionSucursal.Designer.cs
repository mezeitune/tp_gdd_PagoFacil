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
            this.botonModificarSucursal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.txtCodPostalSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 172);
            this.flowLayoutPanel1.TabIndex = 35;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cod Postal";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(223, 104);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(131, 23);
            this.buscar.TabIndex = 40;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // txtCodPostalSucursal
            // 
            this.txtCodPostalSucursal.Location = new System.Drawing.Point(457, 60);
            this.txtCodPostalSucursal.Name = "txtCodPostalSucursal";
            this.txtCodPostalSucursal.Size = new System.Drawing.Size(130, 20);
            this.txtCodPostalSucursal.TabIndex = 39;
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(256, 60);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(131, 20);
            this.txtDireccionSucursal.TabIndex = 38;
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(52, 60);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(134, 20);
            this.txtNombreSucursal.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese el nombre, direccion o codigo postal para buscar una sucursal";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(12, 104);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 44;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // ModificacionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtCodPostalSucursal);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.botonModificarSucursal);
            this.Name = "ModificacionSucursal";
            this.Text = "ModificacionSucursal";
            this.Load += new System.EventHandler(this.ModificacionSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button botonModificarSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox txtCodPostalSucursal;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;

    }
}