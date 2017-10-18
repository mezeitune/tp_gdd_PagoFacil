namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificarDatosSucursal
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
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.CodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaLogica = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // botonModificarSucursal
            // 
            this.botonModificarSucursal.Location = new System.Drawing.Point(326, 361);
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
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(512, 376);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 67;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // dataGridItems
            // 
            this.dataGridItems.AllowUserToAddRows = false;
            this.dataGridItems.AllowUserToDeleteRows = false;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPostal,
            this.Nombre,
            this.Direccion,
            this.EstadoHab});
            this.dataGridItems.Location = new System.Drawing.Point(5, 167);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.ReadOnly = true;
            this.dataGridItems.Size = new System.Drawing.Size(583, 175);
            this.dataGridItems.TabIndex = 77;
            this.dataGridItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarSucursal);
            // 
            // CodPostal
            // 
            this.CodPostal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodPostal.HeaderText = "Codigo Postal";
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // EstadoHab
            // 
            this.EstadoHab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstadoHab.HeaderText = "Estado Habilitacion";
            this.EstadoHab.Name = "EstadoHab";
            this.EstadoHab.ReadOnly = true;
            // 
            // bajaLogica
            // 
            this.bajaLogica.Location = new System.Drawing.Point(170, 361);
            this.bajaLogica.Name = "bajaLogica";
            this.bajaLogica.Size = new System.Drawing.Size(109, 38);
            this.bajaLogica.TabIndex = 80;
            this.bajaLogica.Text = "Baja Logica";
            this.bajaLogica.UseVisualStyleBackColor = true;
            this.bajaLogica.Click += new System.EventHandler(this.bajaLogica_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Haga click en la sucursal que quiera modificar o dar de baja";
            // 
            // ModificarDatosSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bajaLogica);
            this.Controls.Add(this.dataGridItems);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtCodPostalSucursal);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonModificarSucursal);
            this.Name = "ModificarDatosSucursal";
            this.Text = "ModificacionSucursal";
            this.Load += new System.EventHandler(this.ModificacionSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.Button bajaLogica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoHab;
        private System.Windows.Forms.Label label5;

    }
}