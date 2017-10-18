namespace PagoAgilFrba.AbmFactura
{
    partial class agregarItemFacturaModificada
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agregarItems = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.botonGuardarUnItem = new System.Windows.Forms.Button();
            this.txtCantidadDeItems = new System.Windows.Forms.TextBox();
            this.txtMontoItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.monto,
            this.cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(16, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(477, 116);
            this.dataGridView1.TabIndex = 93;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(80, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(157, 20);
            this.txtDescripcion.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Descripcion:";
            // 
            // agregarItems
            // 
            this.agregarItems.Location = new System.Drawing.Point(276, 241);
            this.agregarItems.Name = "agregarItems";
            this.agregarItems.Size = new System.Drawing.Size(109, 42);
            this.agregarItems.TabIndex = 90;
            this.agregarItems.Text = "Agregar Items A La Factura";
            this.agregarItems.UseVisualStyleBackColor = true;
            this.agregarItems.Click += new System.EventHandler(this.agregarItems_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(416, 251);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 89;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(16, 251);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 88;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // botonGuardarUnItem
            // 
            this.botonGuardarUnItem.Location = new System.Drawing.Point(137, 241);
            this.botonGuardarUnItem.Name = "botonGuardarUnItem";
            this.botonGuardarUnItem.Size = new System.Drawing.Size(109, 42);
            this.botonGuardarUnItem.TabIndex = 87;
            this.botonGuardarUnItem.Text = "Guardar Item";
            this.botonGuardarUnItem.UseVisualStyleBackColor = true;
            this.botonGuardarUnItem.Click += new System.EventHandler(this.botonGuardarUnItem_Click);
            // 
            // txtCantidadDeItems
            // 
            this.txtCantidadDeItems.Location = new System.Drawing.Point(437, 55);
            this.txtCantidadDeItems.Name = "txtCantidadDeItems";
            this.txtCantidadDeItems.Size = new System.Drawing.Size(54, 20);
            this.txtCantidadDeItems.TabIndex = 86;
            // 
            // txtMontoItem
            // 
            this.txtMontoItem.Location = new System.Drawing.Point(299, 55);
            this.txtMontoItem.Name = "txtMontoItem";
            this.txtMontoItem.Size = new System.Drawing.Size(67, 20);
            this.txtMontoItem.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Ingrese los datos de los items que quiera agregar a la factura.";
            // 
            // agregarItemFacturaModificada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agregarItems);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.botonGuardarUnItem);
            this.Controls.Add(this.txtCantidadDeItems);
            this.Controls.Add(this.txtMontoItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "agregarItemFacturaModificada";
            this.Text = "agregarItemFacturaModificada";
            this.Load += new System.EventHandler(this.agregarItemFacturaModificada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregarItems;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button botonGuardarUnItem;
        private System.Windows.Forms.TextBox txtCantidadDeItems;
        private System.Windows.Forms.TextBox txtMontoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}