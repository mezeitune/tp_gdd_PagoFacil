namespace PagoAgilFrba.AbmEmpresa
{
    partial class ListadoEmpresas
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
            System.Windows.Forms.GroupBox DatosDeBusqueda;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CUIT = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.TextBox();
            DatosDeBusqueda = new System.Windows.Forms.GroupBox();
            DatosDeBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDeBusqueda
            // 
            DatosDeBusqueda.Controls.Add(this.Seleccionar);
            DatosDeBusqueda.Controls.Add(this.label3);
            DatosDeBusqueda.Controls.Add(this.Rubro);
            DatosDeBusqueda.Controls.Add(this.label2);
            DatosDeBusqueda.Controls.Add(this.label1);
            DatosDeBusqueda.Controls.Add(this.CUIT);
            DatosDeBusqueda.Controls.Add(this.Nombre);
            DatosDeBusqueda.Location = new System.Drawing.Point(9, 10);
            DatosDeBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            DatosDeBusqueda.Name = "DatosDeBusqueda";
            DatosDeBusqueda.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            DatosDeBusqueda.Size = new System.Drawing.Size(374, 82);
            DatosDeBusqueda.TabIndex = 0;
            DatosDeBusqueda.TabStop = false;
            DatosDeBusqueda.Text = "Datos de búsqueda";
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(280, 50);
            this.Seleccionar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(81, 26);
            this.Seleccionar.TabIndex = 4;
            this.Seleccionar.Text = "&Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Rubro:";
            // 
            // Rubro
            // 
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(242, 23);
            this.Rubro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(121, 21);
            this.Rubro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Nombre:";
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(56, 48);
            this.CUIT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(121, 20);
            this.CUIT.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(56, 21);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(121, 20);
            this.Nombre.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(298, 97);
            this.Buscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 28);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "&Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(9, 97);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(85, 28);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "&Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Listado
            // 
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColCUIT,
            this.ColRubro,
            this.ColDireccion});
            this.Listado.Location = new System.Drawing.Point(9, 130);
            this.Listado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Listado.MultiSelect = false;
            this.Listado.Name = "Listado";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Listado.RowTemplate.Height = 27;
            this.Listado.Size = new System.Drawing.Size(374, 283);
            this.Listado.TabIndex = 7;
            this.Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listado_CellContentClick);
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCUIT
            // 
            this.ColCUIT.HeaderText = "CUIT";
            this.ColCUIT.Name = "ColCUIT";
            this.ColCUIT.ReadOnly = true;
            // 
            // ColRubro
            // 
            this.ColRubro.HeaderText = "Rubro";
            this.ColRubro.Name = "ColRubro";
            this.ColRubro.ReadOnly = true;
            // 
            // ColDireccion
            // 
            this.ColDireccion.HeaderText = "Direccion";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(75, 24);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(160, 20);
            this.Direccion.TabIndex = 0;
            // 
            // ListadoEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 423);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(DatosDeBusqueda);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ListadoEmpresas";
            this.Text = "Seleccionar empresa";
            this.Load += new System.EventHandler(this.ListadoEmpresas_Load);
            DatosDeBusqueda.ResumeLayout(false);
            DatosDeBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.ComboBox Rubro;
        public System.Windows.Forms.DataGridView Listado;
    }
}