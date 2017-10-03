namespace PagoAgilFrba.AbmCliente
{
    partial class Baja_Modificacion_Cliente
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
            this.buscaPorNombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDniExacto = new System.Windows.Forms.TextBox();
            this.buscaPorApellido = new System.Windows.Forms.Button();
            this.buscaPorDniExacto = new System.Windows.Forms.Button();
            this.ModificacionCliente = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buscaPorNombre
            // 
            this.buscaPorNombre.Location = new System.Drawing.Point(12, 77);
            this.buscaPorNombre.Name = "buscaPorNombre";
            this.buscaPorNombre.Size = new System.Drawing.Size(134, 23);
            this.buscaPorNombre.TabIndex = 0;
            this.buscaPorNombre.Text = "Buscar por Nombre";
            this.buscaPorNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscaPorNombre.UseVisualStyleBackColor = true;
            this.buscaPorNombre.Click += new System.EventHandler(this.buscaPorNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre, apellido o dni (este ultimo exacto) para buscar un cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(200, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtDniExacto
            // 
            this.txtDniExacto.Location = new System.Drawing.Point(375, 51);
            this.txtDniExacto.Name = "txtDniExacto";
            this.txtDniExacto.Size = new System.Drawing.Size(111, 20);
            this.txtDniExacto.TabIndex = 4;
            // 
            // buscaPorApellido
            // 
            this.buscaPorApellido.Location = new System.Drawing.Point(200, 77);
            this.buscaPorApellido.Name = "buscaPorApellido";
            this.buscaPorApellido.Size = new System.Drawing.Size(116, 23);
            this.buscaPorApellido.TabIndex = 5;
            this.buscaPorApellido.Text = "Buscar por Apellido";
            this.buscaPorApellido.UseVisualStyleBackColor = true;
            this.buscaPorApellido.Click += new System.EventHandler(this.buscaPorApellido_Click);
            // 
            // buscaPorDniExacto
            // 
            this.buscaPorDniExacto.Location = new System.Drawing.Point(375, 77);
            this.buscaPorDniExacto.Name = "buscaPorDniExacto";
            this.buscaPorDniExacto.Size = new System.Drawing.Size(111, 23);
            this.buscaPorDniExacto.TabIndex = 6;
            this.buscaPorDniExacto.Text = "Buscar por DNI";
            this.buscaPorDniExacto.UseVisualStyleBackColor = true;
            this.buscaPorDniExacto.Click += new System.EventHandler(this.buscaPorDniExacto_Click);
            // 
            // ModificacionCliente
            // 
            this.ModificacionCliente.Location = new System.Drawing.Point(200, 363);
            this.ModificacionCliente.Name = "ModificacionCliente";
            this.ModificacionCliente.Size = new System.Drawing.Size(95, 38);
            this.ModificacionCliente.TabIndex = 7;
            this.ModificacionCliente.Text = "MODIFICAR";
            this.ModificacionCliente.UseVisualStyleBackColor = true;
            this.ModificacionCliente.Click += new System.EventHandler(this.ModificacionCliente_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 172);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Baja_Modificacion_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ModificacionCliente);
            this.Controls.Add(this.buscaPorDniExacto);
            this.Controls.Add(this.buscaPorApellido);
            this.Controls.Add(this.txtDniExacto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaPorNombre);
            this.Name = "Baja_Modificacion_Cliente";
            this.Text = "Baja_Modificacion_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscaPorNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDniExacto;
        private System.Windows.Forms.Button buscaPorApellido;
        private System.Windows.Forms.Button buscaPorDniExacto;
        private System.Windows.Forms.Button ModificacionCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;


    }
}