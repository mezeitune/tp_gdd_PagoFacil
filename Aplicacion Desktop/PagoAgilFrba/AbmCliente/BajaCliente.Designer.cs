namespace PagoAgilFrba.AbmCliente
{
    partial class BajaCliente
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buscaPorDniExacto = new System.Windows.Forms.Button();
            this.buscaPorApellido = new System.Windows.Forms.Button();
            this.txtDniExacto = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaPorNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BajaLogicaCliente
            // 
            this.BajaLogicaCliente.Location = new System.Drawing.Point(269, 397);
            this.BajaLogicaCliente.Name = "BajaLogicaCliente";
            this.BajaLogicaCliente.Size = new System.Drawing.Size(96, 38);
            this.BajaLogicaCliente.TabIndex = 9;
            this.BajaLogicaCliente.Text = "BAJA LOGICA";
            this.BajaLogicaCliente.UseVisualStyleBackColor = true;
            this.BajaLogicaCliente.Click += new System.EventHandler(this.BajaLogicaCliente_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 172);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // buscaPorDniExacto
            // 
            this.buscaPorDniExacto.Location = new System.Drawing.Point(444, 90);
            this.buscaPorDniExacto.Name = "buscaPorDniExacto";
            this.buscaPorDniExacto.Size = new System.Drawing.Size(111, 23);
            this.buscaPorDniExacto.TabIndex = 16;
            this.buscaPorDniExacto.Text = "Buscar por DNI";
            this.buscaPorDniExacto.UseVisualStyleBackColor = true;
            // 
            // buscaPorApellido
            // 
            this.buscaPorApellido.Location = new System.Drawing.Point(269, 90);
            this.buscaPorApellido.Name = "buscaPorApellido";
            this.buscaPorApellido.Size = new System.Drawing.Size(116, 23);
            this.buscaPorApellido.TabIndex = 15;
            this.buscaPorApellido.Text = "Buscar por Apellido";
            this.buscaPorApellido.UseVisualStyleBackColor = true;
            // 
            // txtDniExacto
            // 
            this.txtDniExacto.Location = new System.Drawing.Point(444, 64);
            this.txtDniExacto.Name = "txtDniExacto";
            this.txtDniExacto.Size = new System.Drawing.Size(111, 20);
            this.txtDniExacto.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(269, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el nombre, apellido o dni (este ultimo exacto) para buscar un cliente";
            // 
            // buscaPorNombre
            // 
            this.buscaPorNombre.Location = new System.Drawing.Point(81, 90);
            this.buscaPorNombre.Name = "buscaPorNombre";
            this.buscaPorNombre.Size = new System.Drawing.Size(134, 23);
            this.buscaPorNombre.TabIndex = 10;
            this.buscaPorNombre.Text = "Buscar por Nombre";
            this.buscaPorNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscaPorNombre.UseVisualStyleBackColor = true;
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 456);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buscaPorDniExacto);
            this.Controls.Add(this.buscaPorApellido);
            this.Controls.Add(this.txtDniExacto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaPorNombre);
            this.Controls.Add(this.BajaLogicaCliente);
            this.Name = "BajaCliente";
            this.Text = "BajaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BajaLogicaCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buscaPorDniExacto;
        private System.Windows.Forms.Button buscaPorApellido;
        private System.Windows.Forms.TextBox txtDniExacto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscaPorNombre;
    }
}