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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Limpiar;
            System.Windows.Forms.Label guion1;
            System.Windows.Forms.Label label5;
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DarDeAlta = new System.Windows.Forms.Button();
            this.CUITTipo = new System.Windows.Forms.TextBox();
            this.CUITNumero = new System.Windows.Forms.TextBox();
            this.CUITVerificador = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            Limpiar = new System.Windows.Forms.Button();
            guion1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            Limpiar.Location = new System.Drawing.Point(12, 179);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new System.Drawing.Size(93, 32);
            Limpiar.TabIndex = 5;
            Limpiar.Text = "&Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(117, 87);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(260, 25);
            this.Direccion.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(117, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(260, 25);
            this.Nombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(guion1);
            this.groupBox1.Controls.Add(this.CUITVerificador);
            this.groupBox1.Controls.Add(this.CUITNumero);
            this.groupBox1.Controls.Add(this.CUITTipo);
            this.groupBox1.Controls.Add(this.Rubro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 153);
            this.groupBox1.TabIndex = 0;
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
            this.label4.Location = new System.Drawing.Point(5, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Rubro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "&CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Nombre:";
            // 
            // DarDeAlta
            // 
            this.DarDeAlta.Location = new System.Drawing.Point(259, 179);
            this.DarDeAlta.Name = "DarDeAlta";
            this.DarDeAlta.Size = new System.Drawing.Size(147, 32);
            this.DarDeAlta.TabIndex = 6;
            this.DarDeAlta.Text = "Dar de &alta";
            this.DarDeAlta.UseVisualStyleBackColor = true;
            this.DarDeAlta.Click += new System.EventHandler(this.DarDeAlta_Click);
            // 
            // CUITTipo
            // 
            this.CUITTipo.Location = new System.Drawing.Point(117, 55);
            this.CUITTipo.MaxLength = 2;
            this.CUITTipo.Name = "CUITTipo";
            this.CUITTipo.Size = new System.Drawing.Size(35, 25);
            this.CUITTipo.TabIndex = 8;
            this.CUITTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            this.CUITTipo.Validating += new System.ComponentModel.CancelEventHandler(this.CUITTipo_Validating);
            // 
            // CUITNumero
            // 
            this.CUITNumero.Location = new System.Drawing.Point(179, 55);
            this.CUITNumero.MaxLength = 8;
            this.CUITNumero.Name = "CUITNumero";
            this.CUITNumero.Size = new System.Drawing.Size(144, 25);
            this.CUITNumero.TabIndex = 9;
            this.CUITNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // CUITVerificador
            // 
            this.CUITVerificador.Location = new System.Drawing.Point(350, 55);
            this.CUITVerificador.MaxLength = 1;
            this.CUITVerificador.Name = "CUITVerificador";
            this.CUITVerificador.Size = new System.Drawing.Size(27, 25);
            this.CUITVerificador.TabIndex = 10;
            this.CUITVerificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // guion1
            // 
            guion1.AutoSize = true;
            guion1.Location = new System.Drawing.Point(158, 58);
            guion1.Name = "guion1";
            guion1.Size = new System.Drawing.Size(15, 15);
            guion1.TabIndex = 11;
            guion1.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(329, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(15, 15);
            label5.TabIndex = 12;
            label5.Text = "-";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AltaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 223);
            this.Controls.Add(this.DarDeAlta);
            this.Controls.Add(Limpiar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AltaEmpresa";
            this.Text = "Alta Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaEmpresa_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Rubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DarDeAlta;
        private System.Windows.Forms.TextBox CUITVerificador;
        private System.Windows.Forms.TextBox CUITNumero;
        private System.Windows.Forms.TextBox CUITTipo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}