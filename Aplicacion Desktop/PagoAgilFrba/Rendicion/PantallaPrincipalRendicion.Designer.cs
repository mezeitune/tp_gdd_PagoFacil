namespace PagoAgilFrba.Rendicion
{
    partial class PantallaPrincipalRendicion
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
            this.limpiar = new System.Windows.Forms.Button();
            this.registrarRendicion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.importeTotalRendicion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.porcentajeComision = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumerodeFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeACobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadFacturasRendidas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.FechaRendicion = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(499, 450);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 71;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(13, 450);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 70;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // registrarRendicion
            // 
            this.registrarRendicion.Location = new System.Drawing.Point(255, 444);
            this.registrarRendicion.Name = "registrarRendicion";
            this.registrarRendicion.Size = new System.Drawing.Size(109, 34);
            this.registrarRendicion.TabIndex = 69;
            this.registrarRendicion.Text = "Registrar Rendicion";
            this.registrarRendicion.UseVisualStyleBackColor = true;
            this.registrarRendicion.Click += new System.EventHandler(this.registrarRendicion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.importeTotalRendicion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.porcentajeComision);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.CantidadFacturasRendidas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboEmpresa);
            this.groupBox1.Controls.Add(this.FechaRendicion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 370);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Rendicion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Seleccione la fecha de la rendicion y la empresa y podra ver las facturas a rendi" +
    "r";
            // 
            // importeTotalRendicion
            // 
            this.importeTotalRendicion.Location = new System.Drawing.Point(242, 337);
            this.importeTotalRendicion.Name = "importeTotalRendicion";
            this.importeTotalRendicion.Size = new System.Drawing.Size(231, 20);
            this.importeTotalRendicion.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Importe A Rendir                      $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Porcentaje Comision                %";
            // 
            // porcentajeComision
            // 
            this.porcentajeComision.Location = new System.Drawing.Point(242, 304);
            this.porcentajeComision.Name = "porcentajeComision";
            this.porcentajeComision.Size = new System.Drawing.Size(41, 20);
            this.porcentajeComision.TabIndex = 74;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumerodeFactura,
            this.importeACobrar});
            this.dataGridView1.Location = new System.Drawing.Point(25, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 142);
            this.dataGridView1.TabIndex = 75;
            // 
            // NumerodeFactura
            // 
            this.NumerodeFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumerodeFactura.HeaderText = "Numero de Factura";
            this.NumerodeFactura.Name = "NumerodeFactura";
            this.NumerodeFactura.ReadOnly = true;
            // 
            // importeACobrar
            // 
            this.importeACobrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importeACobrar.HeaderText = "Importe a cobrar";
            this.importeACobrar.Name = "importeACobrar";
            this.importeACobrar.ReadOnly = true;
            // 
            // CantidadFacturasRendidas
            // 
            this.CantidadFacturasRendidas.Location = new System.Drawing.Point(242, 119);
            this.CantidadFacturasRendidas.Name = "CantidadFacturasRendidas";
            this.CantidadFacturasRendidas.Size = new System.Drawing.Size(231, 20);
            this.CantidadFacturasRendidas.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Cantidad de Facturas A Rendir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Empresa";
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(242, 88);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(231, 21);
            this.comboEmpresa.TabIndex = 67;
            this.comboEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboEmpresa_SelectedIndexChanged);
            // 
            // FechaRendicion
            // 
            this.FechaRendicion.Location = new System.Drawing.Point(242, 62);
            this.FechaRendicion.Name = "FechaRendicion";
            this.FechaRendicion.Size = new System.Drawing.Size(231, 20);
            this.FechaRendicion.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Fecha de la Rendicion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Nota: Si no puede visualizar algun dato es probable que no este/n habilitado/s.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(458, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Si esto ocurre, por favor, dirijase a \"Modifacion\" ubicada en \"ABM\" para corrobar" +
    " la informacion";
            // 
            // PantallaPrincipalRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 490);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.registrarRendicion);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPrincipalRendicion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaPrincipalRendicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button registrarRendicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CantidadFacturasRendidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.DateTimePicker FechaRendicion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox importeTotalRendicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox porcentajeComision;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerodeFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeACobrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}