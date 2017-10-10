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
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonModificarSucursal = new System.Windows.Forms.Button();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(115, 94);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtDireccionSucursal.TabIndex = 33;
            this.txtDireccionSucursal.TextChanged += new System.EventHandler(this.txtDireccionSucursal_TextChanged);
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
            // botonModificarSucursal
            // 
            this.botonModificarSucursal.Location = new System.Drawing.Point(132, 221);
            this.botonModificarSucursal.Name = "botonModificarSucursal";
            this.botonModificarSucursal.Size = new System.Drawing.Size(109, 34);
            this.botonModificarSucursal.TabIndex = 31;
            this.botonModificarSucursal.Text = "Modificar sucursal";
            this.botonModificarSucursal.UseVisualStyleBackColor = true;
            this.botonModificarSucursal.Click += new System.EventHandler(this.ModificarSucursal_Click);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(115, 48);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtNombreSucursal.TabIndex = 28;
            this.txtNombreSucursal.TextChanged += new System.EventHandler(this.txtNombreSucursal_TextChanged);
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
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(305, 253);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 66;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ModificarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 288);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonModificarSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label2);
            this.Name = "ModificarSucursal";
            this.Text = "ModificarSucursal";
            this.Load += new System.EventHandler(this.ModificarSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonModificarSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}