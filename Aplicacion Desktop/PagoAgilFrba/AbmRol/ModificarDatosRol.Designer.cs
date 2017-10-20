namespace PagoAgilFrba.AbmRol
{
    partial class ModificarDatosRol
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
            System.Windows.Forms.GroupBox groupBox;
            System.Windows.Forms.Label labelNombreDeRol;
            this.EstadoHabilitacion = new System.Windows.Forms.CheckBox();
            this.ListadoFuncionalidades = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            groupBox = new System.Windows.Forms.GroupBox();
            labelNombreDeRol = new System.Windows.Forms.Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(this.EstadoHabilitacion);
            groupBox.Controls.Add(labelNombreDeRol);
            groupBox.Controls.Add(this.ListadoFuncionalidades);
            groupBox.Controls.Add(this.nombreRol);
            groupBox.Location = new System.Drawing.Point(9, 10);
            groupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox.Name = "groupBox";
            groupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox.Size = new System.Drawing.Size(363, 247);
            groupBox.TabIndex = 66;
            groupBox.TabStop = false;
            groupBox.Text = "Datos";
            groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // EstadoHabilitacion
            // 
            this.EstadoHabilitacion.AutoSize = true;
            this.EstadoHabilitacion.Location = new System.Drawing.Point(5, 222);
            this.EstadoHabilitacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EstadoHabilitacion.Name = "EstadoHabilitacion";
            this.EstadoHabilitacion.Size = new System.Drawing.Size(78, 17);
            this.EstadoHabilitacion.TabIndex = 63;
            this.EstadoHabilitacion.Text = "&Habilitar rol";
            this.EstadoHabilitacion.UseVisualStyleBackColor = true;
            // 
            // labelNombreDeRol
            // 
            labelNombreDeRol.AutoSize = true;
            labelNombreDeRol.Location = new System.Drawing.Point(2, 18);
            labelNombreDeRol.Name = "labelNombreDeRol";
            labelNombreDeRol.Size = new System.Drawing.Size(76, 13);
            labelNombreDeRol.TabIndex = 0;
            labelNombreDeRol.Text = "&Nombre de rol:";
            // 
            // ListadoFuncionalidades
            // 
            this.ListadoFuncionalidades.AllowUserToResizeColumns = false;
            this.ListadoFuncionalidades.AllowUserToResizeRows = false;
            this.ListadoFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidad});
            this.ListadoFuncionalidades.Location = new System.Drawing.Point(4, 42);
            this.ListadoFuncionalidades.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListadoFuncionalidades.Name = "ListadoFuncionalidades";
            this.ListadoFuncionalidades.RowTemplate.Height = 27;
            this.ListadoFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ListadoFuncionalidades.Size = new System.Drawing.Size(354, 173);
            this.ListadoFuncionalidades.TabIndex = 62;
            this.ListadoFuncionalidades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoFuncionalidades_CellValueChanged);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(98, 16);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(262, 20);
            this.nombreRol.TabIndex = 1;
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(9, 263);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 65;
            this.volverALaPaginaAnterior.Text = "&Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(265, 263);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(107, 23);
            this.Actualizar.TabIndex = 64;
            this.Actualizar.Text = "&Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ModificarDatosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 296);
            this.Controls.Add(groupBox);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.Actualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModificarDatosRol";
            this.Text = "Modificar rol";
            this.Load += new System.EventHandler(this.ModificarDatosRol_Load);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoFuncionalidades;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.CheckBox EstadoHabilitacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Funcionalidad;
    }
}