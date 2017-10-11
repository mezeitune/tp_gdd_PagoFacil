namespace PagoAgilFrba.AbmFactura
{
    partial class AltaDeItemFactura
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
            this.botonGuardarUnItem = new System.Windows.Forms.Button();
            this.txtCantidadDeItems = new System.Windows.Forms.TextBox();
            this.txtMontoItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.generarFactura = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonGuardarUnItem
            // 
            this.botonGuardarUnItem.Location = new System.Drawing.Point(176, 122);
            this.botonGuardarUnItem.Name = "botonGuardarUnItem";
            this.botonGuardarUnItem.Size = new System.Drawing.Size(109, 34);
            this.botonGuardarUnItem.TabIndex = 60;
            this.botonGuardarUnItem.Text = "Guardar Item";
            this.botonGuardarUnItem.UseVisualStyleBackColor = true;
            this.botonGuardarUnItem.Click += new System.EventHandler(this.botonGuardarUnItem_Click);
            // 
            // txtCantidadDeItems
            // 
            this.txtCantidadDeItems.Location = new System.Drawing.Point(223, 83);
            this.txtCantidadDeItems.Name = "txtCantidadDeItems";
            this.txtCantidadDeItems.Size = new System.Drawing.Size(193, 20);
            this.txtCantidadDeItems.TabIndex = 56;
            this.txtCantidadDeItems.TextChanged += new System.EventHandler(this.txtCantidadDeItems_TextChanged);
            // 
            // txtMontoItem
            // 
            this.txtMontoItem.Location = new System.Drawing.Point(223, 52);
            this.txtMontoItem.Name = "txtMontoItem";
            this.txtMontoItem.Size = new System.Drawing.Size(193, 20);
            this.txtMontoItem.TabIndex = 55;
            this.txtMontoItem.TextChanged += new System.EventHandler(this.txtMontoItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Monto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 49;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(40, 128);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 61;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(360, 128);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 77;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // generarFactura
            // 
            this.generarFactura.Location = new System.Drawing.Point(176, 184);
            this.generarFactura.Name = "generarFactura";
            this.generarFactura.Size = new System.Drawing.Size(109, 42);
            this.generarFactura.TabIndex = 78;
            this.generarFactura.Text = "Generar Factura";
            this.generarFactura.UseVisualStyleBackColor = true;
            this.generarFactura.Click += new System.EventHandler(this.generarFactura_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(223, 18);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(193, 20);
            this.txtDescripcion.TabIndex = 80;
            // 
            // AltaDeItemFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 238);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generarFactura);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.botonGuardarUnItem);
            this.Controls.Add(this.txtCantidadDeItems);
            this.Controls.Add(this.txtMontoItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaDeItemFactura";
            this.Text = "AltaDeItemFactura";
            this.Load += new System.EventHandler(this.AltaDeItemFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonGuardarUnItem;
        private System.Windows.Forms.TextBox txtCantidadDeItems;
        private System.Windows.Forms.TextBox txtMontoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button generarFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}