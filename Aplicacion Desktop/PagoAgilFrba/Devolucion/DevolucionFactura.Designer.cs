namespace PagoAgilFrba.Devolucion
{
    partial class DevolucionFactura
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
            this.registrarDevolucion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.motivosDevolucion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num_fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venc_fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboFacturasADevolver = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(701, 467);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 71;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(16, 467);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 27);
            this.limpiar.TabIndex = 70;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // registrarDevolucion
            // 
            this.registrarDevolucion.Location = new System.Drawing.Point(347, 455);
            this.registrarDevolucion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.registrarDevolucion.Name = "registrarDevolucion";
            this.registrarDevolucion.Size = new System.Drawing.Size(145, 39);
            this.registrarDevolucion.TabIndex = 69;
            this.registrarDevolucion.Text = "Registrar Devolucion";
            this.registrarDevolucion.UseVisualStyleBackColor = true;
            this.registrarDevolucion.Click += new System.EventHandler(this.registrarDevolucion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.motivosDevolucion);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboFacturasADevolver);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(785, 344);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 15);
            this.label2.TabIndex = 82;
            this.label2.Text = "Seleccione la/s factura/s a devolver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Motivo Devolucion:";
            // 
            // motivosDevolucion
            // 
            this.motivosDevolucion.FormattingEnabled = true;
            this.motivosDevolucion.Location = new System.Drawing.Point(284, 308);
            this.motivosDevolucion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.motivosDevolucion.Name = "motivosDevolucion";
            this.motivosDevolucion.Size = new System.Drawing.Size(307, 23);
            this.motivosDevolucion.TabIndex = 81;
            this.motivosDevolucion.SelectedIndexChanged += new System.EventHandler(this.motivosDevolucion_SelectedIndexChanged);
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
            this.totalFactura,
            this.numeroPago});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(757, 189);
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
            this.totalFactura.HeaderText = "TOTAL FACTURA";
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.ReadOnly = true;
            // 
            // numeroPago
            // 
            this.numeroPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroPago.HeaderText = "NUMERO PAGO";
            this.numeroPago.Name = "numeroPago";
            this.numeroPago.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 27);
            this.button1.TabIndex = 79;
            this.button1.Text = "Agregar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboFacturasADevolver
            // 
            this.comboFacturasADevolver.FormattingEnabled = true;
            this.comboFacturasADevolver.Location = new System.Drawing.Point(284, 54);
            this.comboFacturasADevolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboFacturasADevolver.Name = "comboFacturasADevolver";
            this.comboFacturasADevolver.Size = new System.Drawing.Size(307, 23);
            this.comboFacturasADevolver.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 15);
            this.label10.TabIndex = 59;
            this.label10.Text = "Numero de Factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(775, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "Si esto ocurre, por favor, dirijase a \"Modifacion\" ubicada en \"ABM\" para corrobar" +
    " la informacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(511, 15);
            this.label8.TabIndex = 89;
            this.label8.Text = "Nota 2: Las facturas ya rendidas no se mostraran para devolver.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(639, 15);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nota: Si no puede visualizar algun dato es probable que no este/n habilitado/s.";
            // 
            // DevolucionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.registrarDevolucion);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DevolucionFactura";
            this.Text = "DevolucionFactura";
            this.Load += new System.EventHandler(this.DevolucionFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button registrarDevolucion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboFacturasADevolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox motivosDevolucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venc_fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPago;
    }
}