namespace PagoAgilFrba.AbmRol
{
    partial class SeleccionarRol
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
            this.ModificarRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.ListadoRol = new System.Windows.Forms.DataGridView();
            this.IDRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRol)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificarRol
            // 
            this.ModificarRol.Location = new System.Drawing.Point(261, 205);
            this.ModificarRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModificarRol.Name = "ModificarRol";
            this.ModificarRol.Size = new System.Drawing.Size(132, 27);
            this.ModificarRol.TabIndex = 5;
            this.ModificarRol.Text = "&Modificar Rol";
            this.ModificarRol.UseVisualStyleBackColor = true;
            this.ModificarRol.Click += new System.EventHandler(this.ModificarRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un rol para modificar:";
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(16, 205);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 62;
            this.volverALaPaginaAnterior.Text = "&Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ListadoRol
            // 
            this.ListadoRol.AllowUserToAddRows = false;
            this.ListadoRol.AllowUserToDeleteRows = false;
            this.ListadoRol.AllowUserToOrderColumns = true;
            this.ListadoRol.AllowUserToResizeColumns = false;
            this.ListadoRol.AllowUserToResizeRows = false;
            this.ListadoRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRol,
            this.NombreRol});
            this.ListadoRol.Location = new System.Drawing.Point(16, 27);
            this.ListadoRol.MultiSelect = false;
            this.ListadoRol.Name = "ListadoRol";
            this.ListadoRol.ReadOnly = true;
            this.ListadoRol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListadoRol.RowTemplate.Height = 27;
            this.ListadoRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoRol.Size = new System.Drawing.Size(377, 172);
            this.ListadoRol.TabIndex = 64;
            // 
            // IDRol
            // 
            this.IDRol.HeaderText = "ID";
            this.IDRol.Name = "IDRol";
            this.IDRol.ReadOnly = true;
            this.IDRol.Visible = false;
            // 
            // NombreRol
            // 
            this.NombreRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreRol.HeaderText = "Nombre de rol";
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.ReadOnly = true;
            // 
            // SeleccionarRol
            // 
            this.AcceptButton = this.ModificarRol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.volverALaPaginaAnterior;
            this.ClientSize = new System.Drawing.Size(412, 242);
            this.Controls.Add(this.ListadoRol);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.ModificarRol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SeleccionarRol";
            this.Text = "Seleccionar Rol";
            this.Load += new System.EventHandler(this.SeleccionarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificarRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.DataGridView ListadoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRol;
    }
}