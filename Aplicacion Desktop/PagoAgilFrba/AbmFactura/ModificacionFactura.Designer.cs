﻿namespace PagoAgilFrba.AbmFactura
{
    partial class ModificacionFactura
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
            this.BajaLogicaCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNroFacturaModif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BajaLogicaCliente
            // 
            this.BajaLogicaCliente.Location = new System.Drawing.Point(260, 166);
            this.BajaLogicaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BajaLogicaCliente.Name = "BajaLogicaCliente";
            this.BajaLogicaCliente.Size = new System.Drawing.Size(128, 44);
            this.BajaLogicaCliente.TabIndex = 33;
            this.BajaLogicaCliente.Text = "Modificar Factura";
            this.BajaLogicaCliente.UseVisualStyleBackColor = true;
            this.BajaLogicaCliente.Click += new System.EventHandler(this.ModificarFactura_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Numero de Factura";
            // 
            // comboBoxNroFacturaModif
            // 
            this.comboBoxNroFacturaModif.FormattingEnabled = true;
            this.comboBoxNroFacturaModif.Location = new System.Drawing.Point(240, 81);
            this.comboBoxNroFacturaModif.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxNroFacturaModif.Name = "comboBoxNroFacturaModif";
            this.comboBoxNroFacturaModif.Size = new System.Drawing.Size(439, 23);
            this.comboBoxNroFacturaModif.TabIndex = 31;
            this.comboBoxNroFacturaModif.SelectedIndexChanged += new System.EventHandler(this.comboBoxNroFacturaModif_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Elija una Factura a modificar, recuerde que no apareceran las facturas pagas como" +
    " tambien las rendidas";
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(580, 183);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 61;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ModificacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 216);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.BajaLogicaCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNroFacturaModif);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModificacionFactura";
            this.Text = "ModificacionFactura";
            this.Load += new System.EventHandler(this.ModificacionFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BajaLogicaCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNroFacturaModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}