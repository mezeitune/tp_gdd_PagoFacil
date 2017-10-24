namespace PagoAgilFrba.ListadoEstadistico
{
    partial class PantallaPrincipalListadoEstadistico
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
            System.Windows.Forms.Label labelAnio;
            System.Windows.Forms.Label labelTrimestre;
            System.Windows.Forms.GroupBox GroupBoxDatos;
            System.Windows.Forms.Label labelTipoListado;
            System.Windows.Forms.GroupBox GroupBoxTop5;
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.Trimestre = new System.Windows.Forms.ComboBox();
            this.GenerarListado = new System.Windows.Forms.Button();
            this.PanelListado = new System.Windows.Forms.Panel();
            this.Anio = new System.Windows.Forms.NumericUpDown();
            this.TipoListado = new System.Windows.Forms.ComboBox();
            labelAnio = new System.Windows.Forms.Label();
            labelTrimestre = new System.Windows.Forms.Label();
            GroupBoxDatos = new System.Windows.Forms.GroupBox();
            labelTipoListado = new System.Windows.Forms.Label();
            GroupBoxTop5 = new System.Windows.Forms.GroupBox();
            GroupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anio)).BeginInit();
            GroupBoxTop5.SuspendLayout();
            this.SuspendLayout();
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(661, 410);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 9;
            this.volverALaPaginaAnterior.Text = "&Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Location = new System.Drawing.Point(7, 58);
            labelAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new System.Drawing.Size(39, 15);
            labelAnio.TabIndex = 3;
            labelAnio.Text = "&Año:";
            // 
            // labelTrimestre
            // 
            labelTrimestre.AutoSize = true;
            labelTrimestre.Location = new System.Drawing.Point(240, 58);
            labelTrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTrimestre.Name = "labelTrimestre";
            labelTrimestre.Size = new System.Drawing.Size(87, 15);
            labelTrimestre.TabIndex = 5;
            labelTrimestre.Text = "&Trimestre:";
            // 
            // Trimestre
            // 
            this.Trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Trimestre.FormattingEnabled = true;
            this.Trimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto"});
            this.Trimestre.Location = new System.Drawing.Point(335, 55);
            this.Trimestre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trimestre.Name = "Trimestre";
            this.Trimestre.Size = new System.Drawing.Size(187, 23);
            this.Trimestre.TabIndex = 6;
            // 
            // GenerarListado
            // 
            this.GenerarListado.Location = new System.Drawing.Point(580, 53);
            this.GenerarListado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenerarListado.Name = "GenerarListado";
            this.GenerarListado.Size = new System.Drawing.Size(162, 25);
            this.GenerarListado.TabIndex = 7;
            this.GenerarListado.Text = "&Generar listado";
            this.GenerarListado.UseVisualStyleBackColor = true;
            this.GenerarListado.Click += new System.EventHandler(this.GenerarListado_Click);
            // 
            // PanelListado
            // 
            this.PanelListado.Location = new System.Drawing.Point(10, 24);
            this.PanelListado.Name = "PanelListado";
            this.PanelListado.Size = new System.Drawing.Size(732, 270);
            this.PanelListado.TabIndex = 8;
            // 
            // GroupBoxDatos
            // 
            GroupBoxDatos.Controls.Add(this.TipoListado);
            GroupBoxDatos.Controls.Add(labelTipoListado);
            GroupBoxDatos.Controls.Add(this.Anio);
            GroupBoxDatos.Controls.Add(this.GenerarListado);
            GroupBoxDatos.Controls.Add(labelAnio);
            GroupBoxDatos.Controls.Add(labelTrimestre);
            GroupBoxDatos.Controls.Add(this.Trimestre);
            GroupBoxDatos.Location = new System.Drawing.Point(12, 12);
            GroupBoxDatos.Name = "GroupBoxDatos";
            GroupBoxDatos.Size = new System.Drawing.Size(749, 86);
            GroupBoxDatos.TabIndex = 0;
            GroupBoxDatos.TabStop = false;
            GroupBoxDatos.Text = "Datos de consulta";
            // 
            // Anio
            // 
            this.Anio.Location = new System.Drawing.Point(53, 53);
            this.Anio.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.Anio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Anio.Name = "Anio";
            this.Anio.Size = new System.Drawing.Size(133, 25);
            this.Anio.TabIndex = 4;
            this.Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Anio.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // labelTipoListado
            // 
            labelTipoListado.AutoSize = true;
            labelTipoListado.Location = new System.Drawing.Point(7, 27);
            labelTipoListado.Name = "labelTipoListado";
            labelTipoListado.Size = new System.Drawing.Size(247, 15);
            labelTipoListado.TabIndex = 1;
            labelTipoListado.Text = "&Seleccione el tipo de listado:";
            // 
            // TipoListado
            // 
            this.TipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoListado.FormattingEnabled = true;
            this.TipoListado.Location = new System.Drawing.Point(260, 24);
            this.TipoListado.Name = "TipoListado";
            this.TipoListado.Size = new System.Drawing.Size(482, 23);
            this.TipoListado.TabIndex = 2;
            this.TipoListado.SelectedIndexChanged += new System.EventHandler(this.TipoListado_SelectedIndexChanged);
            // 
            // GroupBoxTop5
            // 
            GroupBoxTop5.Controls.Add(this.PanelListado);
            GroupBoxTop5.Location = new System.Drawing.Point(12, 104);
            GroupBoxTop5.Name = "GroupBoxTop5";
            GroupBoxTop5.Size = new System.Drawing.Size(749, 300);
            GroupBoxTop5.TabIndex = 0;
            GroupBoxTop5.TabStop = false;
            GroupBoxTop5.Text = "Top 5";
            // 
            // PantallaPrincipalListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 446);
            this.Controls.Add(GroupBoxTop5);
            this.Controls.Add(GroupBoxDatos);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PantallaPrincipalListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.PantallaPrincipalListadoEstadistico_Load);
            GroupBoxDatos.ResumeLayout(false);
            GroupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anio)).EndInit();
            GroupBoxTop5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.ComboBox Trimestre;
        private System.Windows.Forms.Button GenerarListado;
        private System.Windows.Forms.Panel PanelListado;
        private System.Windows.Forms.NumericUpDown Anio;
        private System.Windows.Forms.ComboBox TipoListado;
    }
}