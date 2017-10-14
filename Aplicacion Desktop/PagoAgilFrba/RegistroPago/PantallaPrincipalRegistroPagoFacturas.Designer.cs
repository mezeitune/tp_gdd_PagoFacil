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
            this.comboSucursal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaVencFact = new System.Windows.Forms.DateTimePicker();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmpresas = new System.Windows.Forms.ComboBox();
            this.comboFacturasAPagar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FechaCobro = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.registrarUnPago = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.medioPago = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medioPago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboSucursal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ImporteFact);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FechaVencFact);
            this.groupBox1.Controls.Add(this.comboCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboEmpresas);
            this.groupBox1.Controls.Add(this.comboFacturasAPagar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.FechaCobro);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pago";
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
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Importe                                                    $";
            // 
            // ImporteFact
            // 
            this.ImporteFact.Location = new System.Drawing.Point(213, 191);
            this.ImporteFact.Name = "ImporteFact";
            this.ImporteFact.Size = new System.Drawing.Size(231, 20);
            this.ImporteFact.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Fecha de vencimiento Factura Elegida";
            // 
            // FechaVencFact
            // 
            this.FechaVencFact.Location = new System.Drawing.Point(213, 161);
            this.FechaVencFact.Name = "FechaVencFact";
            this.FechaVencFact.Size = new System.Drawing.Size(231, 20);
            this.FechaVencFact.TabIndex = 71;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(213, 125);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(231, 21);
            this.comboCliente.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "DNI Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "CUIT Empresa :";
            // 
            // comboEmpresas
            // 
            this.comboEmpresas.FormattingEnabled = true;
            this.comboEmpresas.Location = new System.Drawing.Point(213, 92);
            this.comboEmpresas.Name = "comboEmpresas";
            this.comboEmpresas.Size = new System.Drawing.Size(231, 21);
            this.comboEmpresas.TabIndex = 67;
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
            // FechaCobro
            // 
            this.FechaCobro.Location = new System.Drawing.Point(211, 59);
            this.FechaCobro.Name = "FechaCobro";
            this.FechaCobro.Size = new System.Drawing.Size(233, 20);
            this.FechaCobro.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Fecha de Cobro";
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(381, 316);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 67;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(21, 316);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 66;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // registrarUnPago
            // 
            this.registrarUnPago.Location = new System.Drawing.Point(192, 310);
            this.registrarUnPago.Name = "registrarUnPago";
            this.registrarUnPago.Size = new System.Drawing.Size(109, 34);
            this.registrarUnPago.TabIndex = 64;
            this.registrarUnPago.Text = "Registrar Pago";
            this.registrarUnPago.UseVisualStyleBackColor = true;
            this.registrarUnPago.Click += new System.EventHandler(this.registrarUnPago_Click);
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
            // medioPago
            // 
            this.medioPago.FormattingEnabled = true;
            this.medioPago.Location = new System.Drawing.Point(213, 246);
            this.medioPago.Name = "medioPago";
            this.medioPago.Size = new System.Drawing.Size(231, 21);
            this.medioPago.TabIndex = 78;
            // 
            // PantallaPrincipalRegistroPagoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 367);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.registrarUnPago);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPrincipalRegistroPagoFacturas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaPrincipalRegistroPagoFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImporteFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaVencFact;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmpresas;
        private System.Windows.Forms.ComboBox comboFacturasAPagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker FechaCobro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button registrarUnPago;
        private System.Windows.Forms.ComboBox medioPago;
        private System.Windows.Forms.Label label6;

    }
}