namespace PagoAgilFrba.AbmFactura
{
    partial class AltaFactura
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
            this.DarAltaFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.FechaAltaFac = new System.Windows.Forms.DateTimePicker();
            this.FechaVencFact = new System.Windows.Forms.DateTimePicker();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DarAltaFactura
            // 
            this.DarAltaFactura.Location = new System.Drawing.Point(173, 296);
            this.DarAltaFactura.Name = "DarAltaFactura";
            this.DarAltaFactura.Size = new System.Drawing.Size(121, 50);
            this.DarAltaFactura.TabIndex = 47;
            this.DarAltaFactura.Text = "Dar de alta factura";
            this.DarAltaFactura.UseVisualStyleBackColor = true;
            this.DarAltaFactura.Click += new System.EventHandler(this.DarAltaFactura_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha Vencimiento Factura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fecha Alta Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Numero de Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "DNI Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 50;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(225, 225);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(193, 20);
            this.txtTotalFactura.TabIndex = 51;
            this.txtTotalFactura.TextChanged += new System.EventHandler(this.txtTotalFactura_TextChanged);
            // 
            // FechaAltaFac
            // 
            this.FechaAltaFac.Location = new System.Drawing.Point(225, 157);
            this.FechaAltaFac.Name = "FechaAltaFac";
            this.FechaAltaFac.Size = new System.Drawing.Size(200, 20);
            this.FechaAltaFac.TabIndex = 54;
            this.FechaAltaFac.ValueChanged += new System.EventHandler(this.FechaAltaFact_ValueChanged);
            // 
            // FechaVencFact
            // 
            this.FechaVencFact.Location = new System.Drawing.Point(225, 189);
            this.FechaVencFact.Name = "FechaVencFact";
            this.FechaVencFact.Size = new System.Drawing.Size(200, 20);
            this.FechaVencFact.TabIndex = 55;
            this.FechaVencFact.ValueChanged += new System.EventHandler(this.FechaVencFact_ValueChanged);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(46, 366);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 56;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(350, 366);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 60;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(225, 124);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(193, 20);
            this.txtNroFactura.TabIndex = 38;
            this.txtNroFactura.TextChanged += new System.EventHandler(this.txtNroFactura_TextChanged);
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(225, 91);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(193, 21);
            this.comboEmpresa.TabIndex = 53;
            this.comboEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboEmpresa_SelectedIndexChanged);
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(225, 55);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(193, 21);
            this.comboCliente.TabIndex = 52;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Recuerde primero dar de alta la factura y luego ingresar sus items";
            // 
            // AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 401);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.FechaVencFact);
            this.Controls.Add(this.FechaAltaFac);
            this.Controls.Add(this.comboEmpresa);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DarAltaFactura);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaFactura";
            this.Text = "AltaFactura";
            this.Load += new System.EventHandler(this.AltaFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DarAltaFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.DateTimePicker FechaAltaFac;
        private System.Windows.Forms.DateTimePicker FechaVencFact;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label7;
    }
}