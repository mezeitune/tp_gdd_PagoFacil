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
            System.Windows.Forms.Label label3;
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.gbSucursal = new System.Windows.Forms.GroupBox();
            this.SucursalesDisponibles = new System.Windows.Forms.ComboBox();
            this.IrAlMenu = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbSucursal.SuspendLayout();
            this.SuspendLayout();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 27);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "&Sucursal:";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.Rol);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(label2);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(label1);
            this.gbLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbLogin.Location = new System.Drawing.Point(13, 12);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbLogin.Size = new System.Drawing.Size(346, 114);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Ingresar como:";
            // 
            // Rol
            // 
            this.Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rol.FormattingEnabled = true;
            this.Rol.Location = new System.Drawing.Point(133, 78);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(206, 23);
            this.Rol.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(133, 49);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(206, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 18);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 25);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Enabled = false;
            this.botonIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonIngresar.Location = new System.Drawing.Point(259, 197);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(100, 27);
            this.botonIngresar.TabIndex = 5;
            this.botonIngresar.Text = "&Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // gbSucursal
            // 
            this.gbSucursal.Controls.Add(this.SucursalesDisponibles);
            this.gbSucursal.Controls.Add(label3);
            this.gbSucursal.Enabled = false;
            this.gbSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbSucursal.Location = new System.Drawing.Point(13, 132);
            this.gbSucursal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSucursal.Name = "gbSucursal";
            this.gbSucursal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSucursal.Size = new System.Drawing.Size(346, 59);
            this.gbSucursal.TabIndex = 0;
            this.gbSucursal.TabStop = false;
            this.gbSucursal.Text = "Cobrador - Sucursal";
            this.gbSucursal.EnabledChanged += new System.EventHandler(this.gbSucursal_EnabledChanged);
            // 
            // SucursalesDisponibles
            // 
            this.SucursalesDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SucursalesDisponibles.FormattingEnabled = true;
            this.SucursalesDisponibles.Location = new System.Drawing.Point(133, 24);
            this.SucursalesDisponibles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SucursalesDisponibles.Name = "SucursalesDisponibles";
            this.SucursalesDisponibles.Size = new System.Drawing.Size(205, 23);
            this.SucursalesDisponibles.TabIndex = 7;
            // 
            // IrAlMenu
            // 
            this.IrAlMenu.Enabled = false;
            this.IrAlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IrAlMenu.Location = new System.Drawing.Point(163, 197);
            this.IrAlMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IrAlMenu.Name = "IrAlMenu";
            this.IrAlMenu.Size = new System.Drawing.Size(196, 27);
            this.IrAlMenu.TabIndex = 6;
            this.IrAlMenu.Text = "Ir al &menú principal";
            this.IrAlMenu.UseVisualStyleBackColor = true;
            this.IrAlMenu.Visible = false;
            this.IrAlMenu.Click += new System.EventHandler(this.IrAlMenu_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 233);
            this.Controls.Add(this.IrAlMenu);
            this.Controls.Add(this.gbSucursal);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbSucursal.ResumeLayout(false);
            this.gbSucursal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.ComboBox SucursalesDisponibles;
        private System.Windows.Forms.GroupBox gbSucursal;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Rol;
        private System.Windows.Forms.Button IrAlMenu;
    }
}