﻿namespace PagoAgilFrba.AbmFactura
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.botonModificarUnItem = new System.Windows.Forms.Button();
            this.ModificarUnaFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxItemsDeFactura = new System.Windows.Forms.ComboBox();
            this.FechaVencFact = new System.Windows.Forms.DateTimePicker();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.totalFactura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 67;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botonModificarUnItem
            // 
            this.botonModificarUnItem.Location = new System.Drawing.Point(497, 138);
            this.botonModificarUnItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botonModificarUnItem.Name = "botonModificarUnItem";
            this.botonModificarUnItem.Size = new System.Drawing.Size(133, 27);
            this.botonModificarUnItem.TabIndex = 65;
            this.botonModificarUnItem.Text = "Modificar Item";
            this.botonModificarUnItem.UseVisualStyleBackColor = true;
            this.botonModificarUnItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarUnaFactura
            // 
            this.ModificarUnaFactura.Location = new System.Drawing.Point(363, 210);
            this.ModificarUnaFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModificarUnaFactura.Name = "ModificarUnaFactura";
            this.ModificarUnaFactura.Size = new System.Drawing.Size(145, 39);
            this.ModificarUnaFactura.TabIndex = 64;
            this.ModificarUnaFactura.Text = "Modificar Factura";
            this.ModificarUnaFactura.UseVisualStyleBackColor = true;
            this.ModificarUnaFactura.Click += new System.EventHandler(this.ModificarUnaFactura_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha Vencimiento Factura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 15);
            this.label10.TabIndex = 69;
            this.label10.Text = "Item a modificar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxItemsDeFactura
            // 
            this.comboBoxItemsDeFactura.FormattingEnabled = true;
            this.comboBoxItemsDeFactura.Location = new System.Drawing.Point(292, 141);
            this.comboBoxItemsDeFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxItemsDeFactura.Name = "comboBoxItemsDeFactura";
            this.comboBoxItemsDeFactura.Size = new System.Drawing.Size(196, 23);
            this.comboBoxItemsDeFactura.TabIndex = 70;
            this.comboBoxItemsDeFactura.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemsDeFactura_SelectedIndexChanged);
            // 
            // FechaVencFact
            // 
            this.FechaVencFact.Location = new System.Drawing.Point(292, 39);
            this.FechaVencFact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FechaVencFact.Name = "FechaVencFact";
            this.FechaVencFact.Size = new System.Drawing.Size(260, 25);
            this.FechaVencFact.TabIndex = 73;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(53, 217);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 27);
            this.limpiar.TabIndex = 75;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(531, 217);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 76;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // totalFactura
            // 
            this.totalFactura.Location = new System.Drawing.Point(292, 93);
            this.totalFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.Size = new System.Drawing.Size(200, 25);
            this.totalFactura.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 78;
            this.button1.Text = "Agregar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ModificarDatosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalFactura);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.FechaVencFact);
            this.Controls.Add(this.comboBoxItemsDeFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botonModificarUnItem);
            this.Controls.Add(this.ModificarUnaFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModificarDatosFactura";
            this.Text = "ModificarFactura";
            this.Load += new System.EventHandler(this.ModificarDatosFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonModificarUnItem;
        private System.Windows.Forms.Button ModificarUnaFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxItemsDeFactura;
        private System.Windows.Forms.DateTimePicker FechaVencFact;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.TextBox totalFactura;
        private System.Windows.Forms.Button button1;
    }
}