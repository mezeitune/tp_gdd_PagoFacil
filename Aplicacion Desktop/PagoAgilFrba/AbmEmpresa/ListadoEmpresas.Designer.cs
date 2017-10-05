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
            DatosDeBusqueda.Location = new System.Drawing.Point(12, 12);
            DatosDeBusqueda.Name = "DatosDeBusqueda";
            DatosDeBusqueda.Size = new System.Drawing.Size(499, 95);
            DatosDeBusqueda.TabIndex = 0;
            DatosDeBusqueda.TabStop = false;
            DatosDeBusqueda.Text = "Datos de búsqueda";
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(374, 58);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(108, 30);
            this.Seleccionar.TabIndex = 4;
            this.Seleccionar.Text = "&Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Rubro:";
            // 
            // Rubro
            // 
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(322, 26);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(160, 23);
            this.Rubro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "&CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Nombre:";
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(75, 55);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(160, 25);
            this.CUIT.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(75, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(160, 25);
            this.Nombre.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(398, 112);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(113, 32);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "&Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 112);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(113, 32);
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
            this.Listado.Location = new System.Drawing.Point(12, 150);
            this.Listado.MultiSelect = false;
            this.Listado.Name = "Listado";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Listado.RowTemplate.Height = 27;
            this.Listado.Size = new System.Drawing.Size(499, 326);
            this.Listado.TabIndex = 7;
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
            this.Direccion.Size = new System.Drawing.Size(160, 25);
            this.Direccion.TabIndex = 0;
            // 
            // ListadoEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 488);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(DatosDeBusqueda);
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