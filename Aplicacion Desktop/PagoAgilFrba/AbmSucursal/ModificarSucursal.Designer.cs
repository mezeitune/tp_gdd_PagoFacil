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
            this.Habilitar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(105, 67);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtDireccionSucursal.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Direccion";
            // 
            // botonModificarSucursal
            // 
            this.botonModificarSucursal.Location = new System.Drawing.Point(128, 191);
            this.botonModificarSucursal.Name = "botonModificarSucursal";
            this.botonModificarSucursal.Size = new System.Drawing.Size(109, 34);
            this.botonModificarSucursal.TabIndex = 31;
            this.botonModificarSucursal.Text = "Modificar sucursal";
            this.botonModificarSucursal.UseVisualStyleBackColor = true;
            this.botonModificarSucursal.Click += new System.EventHandler(this.ModificarSucursal_Click);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(105, 30);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(193, 20);
            this.txtNombreSucursal.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(307, 197);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 66;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // Habilitar
            // 
            this.Habilitar.AutoSize = true;
            this.Habilitar.Location = new System.Drawing.Point(9, 109);
            this.Habilitar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(106, 17);
            this.Habilitar.TabIndex = 67;
            this.Habilitar.Text = "&Habilitar sucursal";
            this.Habilitar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccionSucursal);
            this.groupBox1.Controls.Add(this.Habilitar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreSucursal);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 144);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Sucursal";
            // 
            // ModificarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.botonModificarSucursal);
            this.Name = "ModificarSucursal";
            this.Text = "ModificarSucursal";
            this.Load += new System.EventHandler(this.ModificarSucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonModificarSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        public System.Windows.Forms.CheckBox Habilitar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}