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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Deshacer;
            System.Windows.Forms.Label guion2;
            System.Windows.Forms.Label guion1;
            this.Actualizar = new System.Windows.Forms.Button();
            this.GroupBoxDatos = new System.Windows.Forms.GroupBox();
            this.CUITVerificador = new System.Windows.Forms.TextBox();
            this.CUITNumero = new System.Windows.Forms.TextBox();
            this.CUITTipo = new System.Windows.Forms.TextBox();
            this.Habilitar = new System.Windows.Forms.CheckBox();
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            Deshacer = new System.Windows.Forms.Button();
            guion2 = new System.Windows.Forms.Label();
            guion1 = new System.Windows.Forms.Label();
            this.GroupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Deshacer
            // 
            Deshacer.Location = new System.Drawing.Point(12, 193);
            Deshacer.Name = "Deshacer";
            Deshacer.Size = new System.Drawing.Size(157, 32);
            Deshacer.TabIndex = 6;
            Deshacer.Text = "&Deshacer todo";
            Deshacer.UseVisualStyleBackColor = true;
            Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // guion2
            // 
            guion2.AutoSize = true;
            guion2.Location = new System.Drawing.Point(329, 58);
            guion2.Name = "guion2";
            guion2.Size = new System.Drawing.Size(15, 15);
            guion2.TabIndex = 17;
            guion2.Text = "-";
            // 
            // guion1
            // 
            guion1.AutoSize = true;
            guion1.Location = new System.Drawing.Point(157, 58);
            guion1.Name = "guion1";
            guion1.Size = new System.Drawing.Size(15, 15);
            guion1.TabIndex = 16;
            guion1.Text = "-";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(259, 193);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(147, 32);
            this.Actualizar.TabIndex = 7;
            this.Actualizar.Text = "&Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // GroupBoxDatos
            // 
            this.GroupBoxDatos.Controls.Add(guion2);
            this.GroupBoxDatos.Controls.Add(guion1);
            this.GroupBoxDatos.Controls.Add(this.CUITVerificador);
            this.GroupBoxDatos.Controls.Add(this.CUITNumero);
            this.GroupBoxDatos.Controls.Add(this.CUITTipo);
            this.GroupBoxDatos.Controls.Add(this.Habilitar);
            this.GroupBoxDatos.Controls.Add(this.Rubro);
            this.GroupBoxDatos.Controls.Add(this.label4);
            this.GroupBoxDatos.Controls.Add(this.label3);
            this.GroupBoxDatos.Controls.Add(this.label2);
            this.GroupBoxDatos.Controls.Add(this.label1);
            this.GroupBoxDatos.Controls.Add(this.Nombre);
            this.GroupBoxDatos.Controls.Add(this.Direccion);
            this.GroupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxDatos.Name = "GroupBoxDatos";
            this.GroupBoxDatos.Size = new System.Drawing.Size(393, 175);
            this.GroupBoxDatos.TabIndex = 8;
            this.GroupBoxDatos.TabStop = false;
            this.GroupBoxDatos.Text = "Datos de empresa";
            // 
            // CUITVerificador
            // 
            this.CUITVerificador.Location = new System.Drawing.Point(349, 55);
            this.CUITVerificador.MaxLength = 1;
            this.CUITVerificador.Name = "CUITVerificador";
            this.CUITVerificador.Size = new System.Drawing.Size(27, 25);
            this.CUITVerificador.TabIndex = 15;
            this.CUITVerificador.TextChanged += new System.EventHandler(this.CUITVerificador_TextChanged);
            this.CUITVerificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // CUITNumero
            // 
            this.CUITNumero.Location = new System.Drawing.Point(179, 55);
            this.CUITNumero.MaxLength = 8;
            this.CUITNumero.Name = "CUITNumero";
            this.CUITNumero.Size = new System.Drawing.Size(144, 25);
            this.CUITNumero.TabIndex = 14;
            this.CUITNumero.TextChanged += new System.EventHandler(this.CUITNumero_TextChanged);
            this.CUITNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // CUITTipo
            // 
            this.CUITTipo.Location = new System.Drawing.Point(117, 55);
            this.CUITTipo.MaxLength = 2;
            this.CUITTipo.Name = "CUITTipo";
            this.CUITTipo.Size = new System.Drawing.Size(35, 25);
            this.CUITTipo.TabIndex = 13;
            this.CUITTipo.TextChanged += new System.EventHandler(this.CUITTipo_TextChanged);
            this.CUITTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // Habilitar
            // 
            this.Habilitar.AutoSize = true;
            this.Habilitar.Location = new System.Drawing.Point(9, 147);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(165, 19);
            this.Habilitar.TabIndex = 5;
            this.Habilitar.Text = "&Habilitar empresa";
            this.Habilitar.UseVisualStyleBackColor = true;
            // 
            // Rubro
            // 
            this.Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(117, 24);
            this.Nombre.MaxLength = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(260, 25);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_Direccion_TextChanged);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(117, 87);
            this.Direccion.MaxLength = 255;
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(260, 25);
            this.Direccion.TabIndex = 3;
            this.Direccion.TextChanged += new System.EventHandler(this.Nombre_Direccion_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ModificacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 242);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(Deshacer);
            this.Controls.Add(this.GroupBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModificacionEmpresa";
            this.Text = "Modificar empresa";
            this.Load += new System.EventHandler(this.ModificacionEmpresa_Load);
            this.GroupBoxDatos.ResumeLayout(false);
            this.GroupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Rubro;
        public System.Windows.Forms.TextBox Nombre;
        public System.Windows.Forms.TextBox Direccion;
        public System.Windows.Forms.CheckBox Habilitar;
        private System.Windows.Forms.TextBox CUITVerificador;
        private System.Windows.Forms.TextBox CUITNumero;
        private System.Windows.Forms.TextBox CUITTipo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.GroupBox GroupBoxDatos;
    }
}