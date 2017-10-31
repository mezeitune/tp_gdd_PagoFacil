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
            System.Windows.Forms.Button EliminarFuncionalidad;
            System.Windows.Forms.Label labelNombreDeRol;
            this.GroupBoxDatos = new System.Windows.Forms.GroupBox();
            this.EstadoHabilitacion = new System.Windows.Forms.CheckBox();
            this.ListadoFuncionalidades = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            EliminarFuncionalidad = new System.Windows.Forms.Button();
            labelNombreDeRol = new System.Windows.Forms.Label();
            this.GroupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxDatos
            // 
            this.GroupBoxDatos.Controls.Add(EliminarFuncionalidad);
            this.GroupBoxDatos.Controls.Add(this.EstadoHabilitacion);
            this.GroupBoxDatos.Controls.Add(labelNombreDeRol);
            this.GroupBoxDatos.Controls.Add(this.ListadoFuncionalidades);
            this.GroupBoxDatos.Controls.Add(this.nombreRol);
            this.GroupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxDatos.Name = "GroupBoxDatos";
            this.GroupBoxDatos.Size = new System.Drawing.Size(484, 285);
            this.GroupBoxDatos.TabIndex = 66;
            this.GroupBoxDatos.TabStop = false;
            this.GroupBoxDatos.Text = "Datos";
            // 
            // EliminarFuncionalidad
            // 
            EliminarFuncionalidad.Location = new System.Drawing.Point(252, 49);
            EliminarFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EliminarFuncionalidad.Name = "EliminarFuncionalidad";
            EliminarFuncionalidad.Size = new System.Drawing.Size(227, 27);
            EliminarFuncionalidad.TabIndex = 65;
            EliminarFuncionalidad.Text = "&Eliminar funcionalidad";
            EliminarFuncionalidad.UseVisualStyleBackColor = true;
            EliminarFuncionalidad.Click += new System.EventHandler(this.EliminarFuncionalidad_Click);
            // 
            // EstadoHabilitacion
            // 
            this.EstadoHabilitacion.AutoSize = true;
            this.EstadoHabilitacion.Location = new System.Drawing.Point(7, 256);
            this.EstadoHabilitacion.Name = "EstadoHabilitacion";
            this.EstadoHabilitacion.Size = new System.Drawing.Size(133, 19);
            this.EstadoHabilitacion.TabIndex = 63;
            this.EstadoHabilitacion.Text = "&Habilitar rol";
            this.EstadoHabilitacion.UseVisualStyleBackColor = true;
            // 
            // labelNombreDeRol
            // 
            labelNombreDeRol.AutoSize = true;
            labelNombreDeRol.Location = new System.Drawing.Point(3, 21);
            labelNombreDeRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNombreDeRol.Name = "labelNombreDeRol";
            labelNombreDeRol.Size = new System.Drawing.Size(119, 15);
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
            this.ListadoFuncionalidades.Location = new System.Drawing.Point(5, 82);
            this.ListadoFuncionalidades.Name = "ListadoFuncionalidades";
            this.ListadoFuncionalidades.RowTemplate.Height = 27;
            this.ListadoFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoFuncionalidades.Size = new System.Drawing.Size(472, 166);
            this.ListadoFuncionalidades.TabIndex = 62;
            this.ListadoFuncionalidades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoFuncionalidades_CellValueChanged);
            this.ListadoFuncionalidades.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListadoFuncionalidades_Modified);
            this.ListadoFuncionalidades.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListadoFuncionalidades_Modified);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(131, 18);
            this.nombreRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nombreRol.MaxLength = 30;
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(348, 25);
            this.nombreRol.TabIndex = 1;
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(12, 303);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 65;
            this.volverALaPaginaAnterior.Text = "&Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(353, 303);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(143, 27);
            this.Actualizar.TabIndex = 64;
            this.Actualizar.Text = "&Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ModificarDatosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 342);
            this.Controls.Add(this.GroupBoxDatos);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.Actualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ModificarDatosRol";
            this.Text = "Modificar rol";
            this.Load += new System.EventHandler(this.ModificarDatosRol_Load);
            this.GroupBoxDatos.ResumeLayout(false);
            this.GroupBoxDatos.PerformLayout();
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
        private System.Windows.Forms.GroupBox GroupBoxDatos;
    }
}