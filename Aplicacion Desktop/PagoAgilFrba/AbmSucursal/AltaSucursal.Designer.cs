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
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPostalSucursal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DarAltaSucursal = new System.Windows.Forms.Button();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(119, 33);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtNombreSucursal.TabIndex = 14;
            this.txtNombreSucursal.TextChanged += new System.EventHandler(this.txtNombreSucursal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // txtCodPostalSucursal
            // 
            this.txtCodPostalSucursal.Location = new System.Drawing.Point(119, 125);
            this.txtCodPostalSucursal.Name = "txtCodPostalSucursal";
            this.txtCodPostalSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtCodPostalSucursal.TabIndex = 23;
            this.txtCodPostalSucursal.TextChanged += new System.EventHandler(this.txtCodPostalSucursal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Codigo postal";
            // 
            // DarAltaSucursal
            // 
            this.DarAltaSucursal.Location = new System.Drawing.Point(130, 174);
            this.DarAltaSucursal.Name = "DarAltaSucursal";
            this.DarAltaSucursal.Size = new System.Drawing.Size(109, 34);
            this.DarAltaSucursal.TabIndex = 24;
            this.DarAltaSucursal.Text = "Dar de alta sucursal";
            this.DarAltaSucursal.UseVisualStyleBackColor = true;
            this.DarAltaSucursal.Click += new System.EventHandler(this.DarAltaSucursal_Click);
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(119, 79);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtDireccionSucursal.TabIndex = 26;
            this.txtDireccionSucursal.TextChanged += new System.EventHandler(this.txtDireccionSucursal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Direccion";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(13, 180);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 31;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(287, 180);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 64;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 220);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarAltaSucursal);
            this.Controls.Add(this.txtCodPostalSucursal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label2);
            this.Name = "AltaSucursal";
            this.Text = "AltaSucursal";
            this.Load += new System.EventHandler(this.AltaSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPostalSucursal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DarAltaSucursal;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}