namespace PagoAgilFrba.AbmCliente
{
    partial class ModificacionClienteee
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
            this.ModificacionCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.txtDniExacto = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificacionCliente
            // 
            this.ModificacionCliente.Location = new System.Drawing.Point(213, 313);
            this.ModificacionCliente.Name = "ModificacionCliente";
            this.ModificacionCliente.Size = new System.Drawing.Size(95, 38);
            this.ModificacionCliente.TabIndex = 7;
            this.ModificacionCliente.Text = "Modificar Cliente";
            this.ModificacionCliente.UseVisualStyleBackColor = true;
            this.ModificacionCliente.Click += new System.EventHandler(this.ModificacionCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(2, 67);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Nombre";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(244, 112);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(116, 23);
            this.buscar.TabIndex = 25;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // txtDniExacto
            // 
            this.txtDniExacto.Location = new System.Drawing.Point(461, 64);
            this.txtDniExacto.Name = "txtDniExacto";
            this.txtDniExacto.Size = new System.Drawing.Size(124, 20);
            this.txtDniExacto.TabIndex = 24;
            this.txtDniExacto.TextChanged += new System.EventHandler(this.txtDniExacto_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(262, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 20);
            this.txtApellido.TabIndex = 23;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese el nombre, apellido o dni (este ultimo exacto) para buscar un cliente";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(67, 112);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 58;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(510, 321);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 59;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Direccion,
            this.CodPostal});
            this.dataGridView1.Location = new System.Drawing.Point(39, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 110);
            this.dataGridView1.TabIndex = 78;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // CodPostal
            // 
            this.CodPostal.HeaderText = "Codigo Postal";
            this.CodPostal.Name = "CodPostal";
            // 
            // ModificacionClienteee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtDniExacto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModificacionCliente);
            this.Name = "ModificacionClienteee";
            this.Text = "Baja_Modificacion_Cliente";
            this.Load += new System.EventHandler(this.Baja_Modificacion_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificacionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox txtDniExacto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPostal;


    }
}