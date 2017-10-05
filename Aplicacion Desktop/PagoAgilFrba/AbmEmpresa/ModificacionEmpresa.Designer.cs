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
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.CUIT = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Habilitar = new System.Windows.Forms.CheckBox();
            Actualizar = new System.Windows.Forms.Button();
            Deshacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Actualizar
            // 
            Actualizar.Location = new System.Drawing.Point(259, 193);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new System.Drawing.Size(146, 32);
            Actualizar.TabIndex = 7;
            Actualizar.Text = "&Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            // 
            // Deshacer
            // 
            Deshacer.Location = new System.Drawing.Point(12, 193);
            Deshacer.Name = "Deshacer";
            Deshacer.Size = new System.Drawing.Size(158, 32);
            Deshacer.TabIndex = 6;
            Deshacer.Text = "&Deshacer todo";
            Deshacer.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de empresa";
            // 
            // Rubro
            // 
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(117, 117);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(260, 23);
            this.Rubro.TabIndex = 4;
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
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(117, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(260, 25);
            this.Nombre.TabIndex = 1;
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(117, 55);
            this.CUIT.MaxLength = 13;
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(260, 25);
            this.CUIT.TabIndex = 2;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(117, 86);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(260, 25);
            this.Direccion.TabIndex = 3;
            // 
            // Habilitar
            // 
            this.Habilitar.AutoSize = true;
            this.Habilitar.Location = new System.Drawing.Point(9, 146);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(165, 19);
            this.Habilitar.TabIndex = 5;
            this.Habilitar.Text = "&Habilitar empresa";
            this.Habilitar.UseVisualStyleBackColor = true;
            // 
            // ModificacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 242);
            this.Controls.Add(Actualizar);
            this.Controls.Add(Deshacer);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificacionEmpresa";
            this.Text = "Modificar empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Habilitar;
        private System.Windows.Forms.ComboBox Rubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.TextBox Direccion;
    }
}