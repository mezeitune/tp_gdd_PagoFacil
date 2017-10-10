namespace PagoAgilFrba.AbmFactura
{
    partial class ModificarItemFactura
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
            this.botonModificarUnItem = new System.Windows.Forms.Button();
            this.txtCantidadItem = new System.Windows.Forms.TextBox();
            this.txtMontoItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonModificarUnItem
            // 
            this.botonModificarUnItem.Location = new System.Drawing.Point(208, 144);
            this.botonModificarUnItem.Name = "botonModificarUnItem";
            this.botonModificarUnItem.Size = new System.Drawing.Size(109, 34);
            this.botonModificarUnItem.TabIndex = 66;
            this.botonModificarUnItem.Text = "Modificar Item";
            this.botonModificarUnItem.UseVisualStyleBackColor = true;
            this.botonModificarUnItem.Click += new System.EventHandler(this.botonModificarUnItem_Click);
            // 
            // txtCantidadItem
            // 
            this.txtCantidadItem.Location = new System.Drawing.Point(234, 87);
            this.txtCantidadItem.Name = "txtCantidadItem";
            this.txtCantidadItem.Size = new System.Drawing.Size(193, 20);
            this.txtCantidadItem.TabIndex = 65;
            this.txtCantidadItem.TextChanged += new System.EventHandler(this.txtCantidadItem_TextChanged);
            // 
            // txtMontoItem
            // 
            this.txtMontoItem.Location = new System.Drawing.Point(234, 56);
            this.txtMontoItem.Name = "txtMontoItem";
            this.txtMontoItem.Size = new System.Drawing.Size(193, 20);
            this.txtMontoItem.TabIndex = 64;
            this.txtMontoItem.TextChanged += new System.EventHandler(this.txtMontoItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 61;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(55, 150);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 67;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(382, 150);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 68;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ModificarItemFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 224);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.botonModificarUnItem);
            this.Controls.Add(this.txtCantidadItem);
            this.Controls.Add(this.txtMontoItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarItemFactura";
            this.Text = "ModificarItemFactura";
            this.Load += new System.EventHandler(this.ModificarItemFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModificarUnItem;
        private System.Windows.Forms.TextBox txtCantidadItem;
        private System.Windows.Forms.TextBox txtMontoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}