namespace PagoAgilFrba.AbmCliente
{
    partial class ModificacionClienteee
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.txtDniExacto = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dnii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaLogica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(2, 67);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Nombre";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(262, 100);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(116, 23);
            this.buscar.TabIndex = 25;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // txtDniExacto
            // 
            this.txtDniExacto.Location = new System.Drawing.Point(461, 64);
            this.txtDniExacto.Name = "txtDniExacto";
            this.txtDniExacto.Size = new System.Drawing.Size(124, 20);
            this.txtDniExacto.TabIndex = 24;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(262, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 20);
            this.txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese el nombre, apellido o dni (este ultimo exacto) para buscar un cliente";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(77, 100);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 58;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(510, 354);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 59;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnii,
            this.dataGridViewTextBoxColumn1,
            this.DNI,
            this.mailCliente,
            this.telefono,
            this.calleCliente,
            this.nroPiso,
            this.departamento,
            this.locCliente,
            this.fechaNacimiento,
            this.codPos,
            this.estadoCliente});
            this.dataGridView1.Location = new System.Drawing.Point(5, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 166);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarCliente);
            // 
            // dnii
            // 
            this.dnii.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dnii.HeaderText = "DNI";
            this.dnii.Name = "dnii";
            this.dnii.ReadOnly = true;
            this.dnii.Width = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 79;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DNI.HeaderText = "APELLIDO";
            this.DNI.Name = "DNI";
            this.DNI.Width = 84;
            // 
            // mailCliente
            // 
            this.mailCliente.HeaderText = "MAIL";
            this.mailCliente.Name = "mailCliente";
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefono.HeaderText = "TEL";
            this.telefono.Name = "telefono";
            this.telefono.Width = 52;
            // 
            // calleCliente
            // 
            this.calleCliente.HeaderText = "CALLE";
            this.calleCliente.Name = "calleCliente";
            // 
            // nroPiso
            // 
            this.nroPiso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nroPiso.HeaderText = "Nro PISO";
            this.nroPiso.Name = "nroPiso";
            this.nroPiso.Width = 77;
            // 
            // departamento
            // 
            this.departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.departamento.HeaderText = "DEPTO";
            this.departamento.Name = "departamento";
            this.departamento.Width = 69;
            // 
            // locCliente
            // 
            this.locCliente.HeaderText = "LOCALIDAD";
            this.locCliente.Name = "locCliente";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaNacimiento.HeaderText = "FECHA NAC";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Width = 92;
            // 
            // codPos
            // 
            this.codPos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codPos.HeaderText = "COD POSTAL";
            this.codPos.Name = "codPos";
            // 
            // estadoCliente
            // 
            this.estadoCliente.HeaderText = "HABILITACION";
            this.estadoCliente.Name = "estadoCliente";
            this.estadoCliente.ReadOnly = true;
            // 
            // bajaLogica
            // 
            this.bajaLogica.Location = new System.Drawing.Point(77, 354);
            this.bajaLogica.Name = "bajaLogica";
            this.bajaLogica.Size = new System.Drawing.Size(109, 23);
            this.bajaLogica.TabIndex = 79;
            this.bajaLogica.Text = "Baja Logica";
            this.bajaLogica.UseVisualStyleBackColor = true;
            this.bajaLogica.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Haga click en el cliente que quiera modificar o dar de baja";
            // 
            // ModificacionClienteee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bajaLogica);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtDniExacto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionClienteee";
            this.Text = "Baja_Modificacion_Cliente";
            this.Load += new System.EventHandler(this.Baja_Modificacion_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox txtDniExacto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bajaLogica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnii;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn locCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        


    }
}