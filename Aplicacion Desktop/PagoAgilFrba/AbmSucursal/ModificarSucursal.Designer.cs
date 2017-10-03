namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificarSucursal
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DarAltaCliente = new System.Windows.Forms.Button();
            this.txtCodPostalCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(193, 20);
            this.txtDireccion.TabIndex = 33;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Direccion";
            // 
            // DarAltaCliente
            // 
            this.DarAltaCliente.Location = new System.Drawing.Point(132, 221);
            this.DarAltaCliente.Name = "DarAltaCliente";
            this.DarAltaCliente.Size = new System.Drawing.Size(109, 34);
            this.DarAltaCliente.TabIndex = 31;
            this.DarAltaCliente.Text = "Modificar sucursal";
            this.DarAltaCliente.UseVisualStyleBackColor = true;
            this.DarAltaCliente.Click += new System.EventHandler(this.DarAltaCliente_Click);
            // 
            // txtCodPostalCliente
            // 
            this.txtCodPostalCliente.Location = new System.Drawing.Point(115, 140);
            this.txtCodPostalCliente.Name = "txtCodPostalCliente";
            this.txtCodPostalCliente.Size = new System.Drawing.Size(193, 20);
            this.txtCodPostalCliente.TabIndex = 30;
            this.txtCodPostalCliente.TextChanged += new System.EventHandler(this.txtCodPostalCliente_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Codigo postal";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(115, 48);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(193, 20);
            this.txtNombreCliente.TabIndex = 28;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // ModificarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 288);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarAltaCliente);
            this.Controls.Add(this.txtCodPostalCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Name = "ModificarSucursal";
            this.Text = "ModificarSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DarAltaCliente;
        private System.Windows.Forms.TextBox txtCodPostalCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
    }
}