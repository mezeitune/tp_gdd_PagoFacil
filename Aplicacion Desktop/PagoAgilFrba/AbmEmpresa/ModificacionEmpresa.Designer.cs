namespace PagoAgilFrba.AbmEmpresa
{
    partial class ModificacionEmpresa
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
            System.Windows.Forms.Button Actualizar;
            System.Windows.Forms.Button Deshacer;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Habilitar = new System.Windows.Forms.CheckBox();
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.CUIT = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            Actualizar = new System.Windows.Forms.Button();
            Deshacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Actualizar
            // 
            Actualizar.Location = new System.Drawing.Point(194, 167);
            Actualizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new System.Drawing.Size(110, 28);
            Actualizar.TabIndex = 7;
            Actualizar.Text = "&Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Deshacer
            // 
            Deshacer.Location = new System.Drawing.Point(9, 167);
            Deshacer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Deshacer.Name = "Deshacer";
            Deshacer.Size = new System.Drawing.Size(118, 28);
            Deshacer.TabIndex = 6;
            Deshacer.Text = "&Deshacer todo";
            Deshacer.UseVisualStyleBackColor = true;
            Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Habilitar);
            this.groupBox1.Controls.Add(this.Rubro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.CUIT);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(295, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de empresa";
            // 
            // Habilitar
            // 
            this.Habilitar.AutoSize = true;
            this.Habilitar.Location = new System.Drawing.Point(7, 127);
            this.Habilitar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(107, 17);
            this.Habilitar.TabIndex = 5;
            this.Habilitar.Text = "&Habilitar empresa";
            this.Habilitar.UseVisualStyleBackColor = true;
            this.Habilitar.CheckedChanged += new System.EventHandler(this.Habilitar_CheckedChanged);
            // 
            // Rubro
            // 
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(88, 101);
            this.Rubro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(196, 21);
            this.Rubro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Rubro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Nombre:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(88, 21);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(196, 20);
            this.Nombre.TabIndex = 1;
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(88, 48);
            this.CUIT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CUIT.MaxLength = 13;
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(196, 20);
            this.CUIT.TabIndex = 2;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(88, 75);
            this.Direccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(196, 20);
            this.Direccion.TabIndex = 3;
            // 
            // ModificacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 210);
            this.Controls.Add(Actualizar);
            this.Controls.Add(Deshacer);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ModificacionEmpresa";
            this.Text = "Modificar empresa";
            this.Load += new System.EventHandler(this.ModificacionEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Rubro;
        public System.Windows.Forms.TextBox Nombre;
        public System.Windows.Forms.TextBox CUIT;
        public System.Windows.Forms.TextBox Direccion;
        public System.Windows.Forms.CheckBox Habilitar;
    }
}