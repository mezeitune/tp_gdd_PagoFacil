namespace PagoAgilFrba.AbmFactura
{
    partial class ModificarDatosFactura
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
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.botonModificarUnItem = new System.Windows.Forms.Button();
            this.ModificarUnaFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxItemsDeFactura = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.FechaVencFact = new System.Windows.Forms.DateTimePicker();
            this.FechaAltaFactura = new System.Windows.Forms.DateTimePicker();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(256, 241);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(200, 20);
            this.txtTotalFactura.TabIndex = 68;
            this.txtTotalFactura.TextChanged += new System.EventHandler(this.txtTotalFactura_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 67;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botonModificarUnItem
            // 
            this.botonModificarUnItem.Location = new System.Drawing.Point(410, 278);
            this.botonModificarUnItem.Name = "botonModificarUnItem";
            this.botonModificarUnItem.Size = new System.Drawing.Size(100, 23);
            this.botonModificarUnItem.TabIndex = 65;
            this.botonModificarUnItem.Text = "Modificar Item";
            this.botonModificarUnItem.UseVisualStyleBackColor = true;
            this.botonModificarUnItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarUnaFactura
            // 
            this.ModificarUnaFactura.Location = new System.Drawing.Point(224, 358);
            this.ModificarUnaFactura.Name = "ModificarUnaFactura";
            this.ModificarUnaFactura.Size = new System.Drawing.Size(109, 34);
            this.ModificarUnaFactura.TabIndex = 64;
            this.ModificarUnaFactura.Text = "Modificar Factura";
            this.ModificarUnaFactura.UseVisualStyleBackColor = true;
            this.ModificarUnaFactura.Click += new System.EventHandler(this.ModificarUnaFactura_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha Vencimiento Factura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Fecha Alta Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Numero de Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Item a modificar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxItemsDeFactura
            // 
            this.comboBoxItemsDeFactura.FormattingEnabled = true;
            this.comboBoxItemsDeFactura.Location = new System.Drawing.Point(256, 280);
            this.comboBoxItemsDeFactura.Name = "comboBoxItemsDeFactura";
            this.comboBoxItemsDeFactura.Size = new System.Drawing.Size(148, 21);
            this.comboBoxItemsDeFactura.TabIndex = 70;
            this.comboBoxItemsDeFactura.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemsDeFactura_SelectedIndexChanged);
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(256, 72);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(200, 21);
            this.comboCliente.TabIndex = 71;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(256, 103);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(200, 21);
            this.comboEmpresa.TabIndex = 72;
            this.comboEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboEmpresa_SelectedIndexChanged);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(256, 136);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(200, 20);
            this.txtNroFactura.TabIndex = 61;
            this.txtNroFactura.TextChanged += new System.EventHandler(this.txtNroFactura_TextChanged);
            // 
            // FechaVencFact
            // 
            this.FechaVencFact.Location = new System.Drawing.Point(256, 195);
            this.FechaVencFact.Name = "FechaVencFact";
            this.FechaVencFact.Size = new System.Drawing.Size(200, 20);
            this.FechaVencFact.TabIndex = 73;
            this.FechaVencFact.ValueChanged += new System.EventHandler(this.FechaVencFact_ValueChanged);
            // 
            // FechaAltaFactura
            // 
            this.FechaAltaFactura.Location = new System.Drawing.Point(256, 163);
            this.FechaAltaFactura.Name = "FechaAltaFactura";
            this.FechaAltaFactura.Size = new System.Drawing.Size(200, 20);
            this.FechaAltaFactura.TabIndex = 74;
            this.FechaAltaFactura.ValueChanged += new System.EventHandler(this.FechaAltaFactura_ValueChanged);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(80, 358);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 75;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(410, 358);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 76;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ModificarDatosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 444);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.FechaAltaFactura);
            this.Controls.Add(this.FechaVencFact);
            this.Controls.Add(this.comboEmpresa);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.comboBoxItemsDeFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botonModificarUnItem);
            this.Controls.Add(this.ModificarUnaFactura);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarDatosFactura";
            this.Text = "ModificarFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonModificarUnItem;
        private System.Windows.Forms.Button ModificarUnaFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxItemsDeFactura;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.DateTimePicker FechaVencFact;
        private System.Windows.Forms.DateTimePicker FechaAltaFactura;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}