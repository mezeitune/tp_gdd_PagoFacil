namespace PagoAgilFrba.AbmEmpresa
{
    partial class BajaEmpresa
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
            System.Windows.Forms.Button Limpiar;
            this.DarDeBaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRubro = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.Label();
            this.textCUIT = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            Limpiar.Location = new System.Drawing.Point(12, 179);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new System.Drawing.Size(93, 32);
            Limpiar.TabIndex = 8;
            Limpiar.Text = "&Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            // 
            // DarDeBaja
            // 
            this.DarDeBaja.Location = new System.Drawing.Point(259, 179);
            this.DarDeBaja.Name = "DarDeBaja";
            this.DarDeBaja.Size = new System.Drawing.Size(146, 32);
            this.DarDeBaja.TabIndex = 9;
            this.DarDeBaja.Text = "Dar de &baja";
            this.DarDeBaja.UseVisualStyleBackColor = true;
            this.DarDeBaja.Click += new System.EventHandler(this.DarDeBaja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRubro);
            this.groupBox1.Controls.Add(this.textDireccion);
            this.groupBox1.Controls.Add(this.textCUIT);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de empresa";
            // 
            // textRubro
            // 
            this.textRubro.AutoSize = true;
            this.textRubro.Location = new System.Drawing.Point(127, 120);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(95, 15);
            this.textRubro.TabIndex = 11;
            this.textRubro.Text = "texto rubro";
            // 
            // textDireccion
            // 
            this.textDireccion.AutoSize = true;
            this.textDireccion.Location = new System.Drawing.Point(127, 89);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(127, 15);
            this.textDireccion.TabIndex = 10;
            this.textDireccion.Text = "texto direccion";
            // 
            // textCUIT
            // 
            this.textCUIT.AutoSize = true;
            this.textCUIT.Location = new System.Drawing.Point(127, 58);
            this.textCUIT.Name = "textCUIT";
            this.textCUIT.Size = new System.Drawing.Size(87, 15);
            this.textCUIT.TabIndex = 9;
            this.textCUIT.Text = "texto cuit";
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Location = new System.Drawing.Point(127, 27);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(103, 15);
            this.textNombre.TabIndex = 8;
            this.textNombre.Text = "texto nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Rubro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "&CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Nombre:";
            // 
            // BajaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 223);
            this.Controls.Add(this.DarDeBaja);
            this.Controls.Add(Limpiar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "BajaEmpresa";
            this.Text = "Baja Empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DarDeBaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label textNombre;
        public System.Windows.Forms.Label textRubro;
        public System.Windows.Forms.Label textDireccion;
        public System.Windows.Forms.Label textCUIT;
    }
}