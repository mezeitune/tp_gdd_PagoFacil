namespace PagoAgilFrba.AbmEmpresa
{
    partial class AltaEmpresa
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
            this.CUIT = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DarDeAlta = new System.Windows.Forms.Button();
            Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            Limpiar.Location = new System.Drawing.Point(9, 155);
            Limpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new System.Drawing.Size(70, 28);
            Limpiar.TabIndex = 5;
            Limpiar.Text = "&Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
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
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(88, 21);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(196, 20);
            this.Nombre.TabIndex = 1;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(295, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de empresa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rubro
            // 
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(88, 101);
            this.Rubro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(196, 21);
            this.Rubro.TabIndex = 4;
            this.Rubro.SelectedIndexChanged += new System.EventHandler(this.Rubro_SelectedIndexChanged);
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
            // DarDeAlta
            // 
            this.DarDeAlta.Location = new System.Drawing.Point(194, 155);
            this.DarDeAlta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DarDeAlta.Name = "DarDeAlta";
            this.DarDeAlta.Size = new System.Drawing.Size(110, 28);
            this.DarDeAlta.TabIndex = 6;
            this.DarDeAlta.Text = "Dar de &alta";
            this.DarDeAlta.UseVisualStyleBackColor = true;
            this.DarDeAlta.Click += new System.EventHandler(this.DarDeAlta_Click);
            // 
            // AltaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 193);
            this.Controls.Add(this.DarDeAlta);
            this.Controls.Add(Limpiar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "AltaEmpresa";
            this.Text = "Alta Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.AltaEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Rubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DarDeAlta;
    }
}