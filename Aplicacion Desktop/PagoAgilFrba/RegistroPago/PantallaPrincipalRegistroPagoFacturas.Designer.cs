namespace PagoAgilFrba.RegistroPago
{
    partial class PantallaPrincipalRegistroPagoFacturas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num_fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venc_fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.medioPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboSucursal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteFact = new System.Windows.Forms.TextBox();
            this.comboFacturasAPagar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.registrarUnPago = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboClientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.medioPago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboSucursal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ImporteFact);
            this.groupBox1.Controls.Add(this.comboFacturasAPagar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pago";
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(213, 273);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(231, 21);
            this.comboClientes.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "DNI Cliente :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_fact,
            this.fecha_venc_fact,
            this.dni_cliente,
            this.cuit_empresa,
            this.totalFactura});
            this.dataGridView1.Location = new System.Drawing.Point(9, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(568, 118);
            this.dataGridView1.TabIndex = 80;
            // 
            // num_fact
            // 
            this.num_fact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num_fact.HeaderText = "NUM FACT";
            this.num_fact.Name = "num_fact";
            this.num_fact.ReadOnly = true;
            // 
            // fecha_venc_fact
            // 
            this.fecha_venc_fact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_venc_fact.HeaderText = "FECHA VENC";
            this.fecha_venc_fact.Name = "fecha_venc_fact";
            this.fecha_venc_fact.ReadOnly = true;
            // 
            // dni_cliente
            // 
            this.dni_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dni_cliente.HeaderText = "DNI CLIENTE";
            this.dni_cliente.Name = "dni_cliente";
            this.dni_cliente.ReadOnly = true;
            // 
            // cuit_empresa
            // 
            this.cuit_empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cuit_empresa.HeaderText = "CUIT EMPRESA";
            this.cuit_empresa.Name = "cuit_empresa";
            this.cuit_empresa.ReadOnly = true;
            // 
            // totalFactura
            // 
            this.totalFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalFactura.HeaderText = "TOTAL";
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Agregar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarFactura);
            // 
            // medioPago
            // 
            this.medioPago.FormattingEnabled = true;
            this.medioPago.Location = new System.Drawing.Point(213, 246);
            this.medioPago.Name = "medioPago";
            this.medioPago.Size = new System.Drawing.Size(231, 21);
            this.medioPago.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Medio de pago :";
            // 
            // comboSucursal
            // 
            this.comboSucursal.FormattingEnabled = true;
            this.comboSucursal.Location = new System.Drawing.Point(213, 217);
            this.comboSucursal.Name = "comboSucursal";
            this.comboSucursal.Size = new System.Drawing.Size(231, 21);
            this.comboSucursal.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Codigo Postal Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Importe Total Facturas Seleccionadas    $";
            // 
            // ImporteFact
            // 
            this.ImporteFact.Location = new System.Drawing.Point(213, 194);
            this.ImporteFact.Name = "ImporteFact";
            this.ImporteFact.Size = new System.Drawing.Size(231, 20);
            this.ImporteFact.TabIndex = 73;
            // 
            // comboFacturasAPagar
            // 
            this.comboFacturasAPagar.FormattingEnabled = true;
            this.comboFacturasAPagar.Location = new System.Drawing.Point(213, 24);
            this.comboFacturasAPagar.Name = "comboFacturasAPagar";
            this.comboFacturasAPagar.Size = new System.Drawing.Size(231, 21);
            this.comboFacturasAPagar.TabIndex = 66;
            this.comboFacturasAPagar.SelectedIndexChanged += new System.EventHandler(this.comboFacturasAPagar_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Numero de Factura:";
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(526, 335);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 67;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(21, 335);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 66;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // registrarUnPago
            // 
            this.registrarUnPago.Location = new System.Drawing.Point(251, 329);
            this.registrarUnPago.Name = "registrarUnPago";
            this.registrarUnPago.Size = new System.Drawing.Size(109, 34);
            this.registrarUnPago.TabIndex = 64;
            this.registrarUnPago.Text = "Registrar Pago";
            this.registrarUnPago.UseVisualStyleBackColor = true;
            this.registrarUnPago.Click += new System.EventHandler(this.registrarUnPago_Click);
            // 
            // PantallaPrincipalRegistroPagoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 367);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.registrarUnPago);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPrincipalRegistroPagoFacturas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaPrincipalRegistroPagoFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImporteFact;
        private System.Windows.Forms.ComboBox comboFacturasAPagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button registrarUnPago;
        private System.Windows.Forms.ComboBox medioPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venc_fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFactura;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label1;

    }
}