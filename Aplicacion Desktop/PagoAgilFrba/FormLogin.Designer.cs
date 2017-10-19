namespace PagoAgilFrba
{
    partial class FormLogin
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label3;
            this.gbAdministrador = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.radioCobrador = new System.Windows.Forms.RadioButton();
            this.radioAdministrador = new System.Windows.Forms.RadioButton();
            this.gbInvitado = new System.Windows.Forms.GroupBox();
            this.SucursalesDisponibles = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            this.gbAdministrador.SuspendLayout();
            groupBox2.SuspendLayout();
            this.gbInvitado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdministrador
            // 
            this.gbAdministrador.Controls.Add(this.txtPassword);
            this.gbAdministrador.Controls.Add(label2);
            this.gbAdministrador.Controls.Add(this.txtUsuario);
            this.gbAdministrador.Controls.Add(label1);
            this.gbAdministrador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbAdministrador.Location = new System.Drawing.Point(13, 12);
            this.gbAdministrador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAdministrador.Name = "gbAdministrador";
            this.gbAdministrador.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAdministrador.Size = new System.Drawing.Size(314, 87);
            this.gbAdministrador.TabIndex = 0;
            this.gbAdministrador.TabStop = false;
            this.gbAdministrador.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(111, 49);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(195, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 52);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "&Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(111, 18);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(195, 25);
            this.txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 21);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "&Usuario:";
            // 
            // botonIngresar
            // 
            this.botonIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonIngresar.Location = new System.Drawing.Point(514, 136);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(100, 27);
            this.botonIngresar.TabIndex = 5;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.radioCobrador);
            groupBox2.Controls.Add(this.radioAdministrador);
            groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox2.Location = new System.Drawing.Point(13, 105);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(314, 58);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresar como: ";
            // 
            // radioCobrador
            // 
            this.radioCobrador.AutoSize = true;
            this.radioCobrador.Location = new System.Drawing.Point(148, 24);
            this.radioCobrador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioCobrador.Name = "radioCobrador";
            this.radioCobrador.Size = new System.Drawing.Size(92, 19);
            this.radioCobrador.TabIndex = 1;
            this.radioCobrador.Text = "Cobrador";
            this.radioCobrador.UseVisualStyleBackColor = true;
            this.radioCobrador.CheckedChanged += new System.EventHandler(this.radioCobrador_CheckedChanged);
            // 
            // radioAdministrador
            // 
            this.radioAdministrador.AutoSize = true;
            this.radioAdministrador.Checked = true;
            this.radioAdministrador.Location = new System.Drawing.Point(8, 24);
            this.radioAdministrador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioAdministrador.Name = "radioAdministrador";
            this.radioAdministrador.Size = new System.Drawing.Size(132, 19);
            this.radioAdministrador.TabIndex = 0;
            this.radioAdministrador.TabStop = true;
            this.radioAdministrador.Text = "Administrador";
            this.radioAdministrador.UseVisualStyleBackColor = true;
            this.radioAdministrador.CheckedChanged += new System.EventHandler(this.radioAdministrador_CheckedChanged);
            // 
            // gbInvitado
            // 
            this.gbInvitado.Controls.Add(this.SucursalesDisponibles);
            this.gbInvitado.Controls.Add(label3);
            this.gbInvitado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbInvitado.Location = new System.Drawing.Point(335, 12);
            this.gbInvitado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInvitado.Name = "gbInvitado";
            this.gbInvitado.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInvitado.Size = new System.Drawing.Size(279, 87);
            this.gbInvitado.TabIndex = 4;
            this.gbInvitado.TabStop = false;
            this.gbInvitado.Text = "Cobrador - Sucursal";
            // 
            // SucursalesDisponibles
            // 
            this.SucursalesDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SucursalesDisponibles.FormattingEnabled = true;
            this.SucursalesDisponibles.Location = new System.Drawing.Point(95, 24);
            this.SucursalesDisponibles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SucursalesDisponibles.Name = "SucursalesDisponibles";
            this.SucursalesDisponibles.Size = new System.Drawing.Size(176, 23);
            this.SucursalesDisponibles.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 28);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "&Sucursal:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 178);
            this.Controls.Add(this.gbInvitado);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.gbAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.FormPrincipalAdministrador_Load);
            this.gbAdministrador.ResumeLayout(false);
            this.gbAdministrador.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.gbInvitado.ResumeLayout(false);
            this.gbInvitado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.RadioButton radioCobrador;
        private System.Windows.Forms.RadioButton radioAdministrador;
        private System.Windows.Forms.ComboBox SucursalesDisponibles;
        private System.Windows.Forms.GroupBox gbInvitado;
        private System.Windows.Forms.GroupBox gbAdministrador;
    }
}