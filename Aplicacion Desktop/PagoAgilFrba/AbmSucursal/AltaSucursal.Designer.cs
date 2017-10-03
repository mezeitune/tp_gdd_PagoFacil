namespace PagoAgilFrba.AbmSucursal
{
    partial class AltaSucursal
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
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPostalCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DarAltaCliente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(94, 43);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(193, 20);
            this.txtNombreCliente.TabIndex = 14;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // txtCodPostalCliente
            // 
            this.txtCodPostalCliente.Location = new System.Drawing.Point(94, 135);
            this.txtCodPostalCliente.Name = "txtCodPostalCliente";
            this.txtCodPostalCliente.Size = new System.Drawing.Size(193, 20);
            this.txtCodPostalCliente.TabIndex = 23;
            this.txtCodPostalCliente.TextChanged += new System.EventHandler(this.txtCodPostalCliente_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Codigo postal";
            // 
            // DarAltaCliente
            // 
            this.DarAltaCliente.Location = new System.Drawing.Point(111, 216);
            this.DarAltaCliente.Name = "DarAltaCliente";
            this.DarAltaCliente.Size = new System.Drawing.Size(109, 34);
            this.DarAltaCliente.TabIndex = 24;
            this.DarAltaCliente.Text = "Dar de alta sucursal";
            this.DarAltaCliente.UseVisualStyleBackColor = true;
            this.DarAltaCliente.Click += new System.EventHandler(this.DarAltaCliente_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(94, 89);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(193, 20);
            this.txtDireccion.TabIndex = 26;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Direccion";
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 262);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarAltaCliente);
            this.Controls.Add(this.txtCodPostalCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Name = "AltaSucursal";
            this.Text = "AltaSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPostalCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DarAltaCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
    }
}