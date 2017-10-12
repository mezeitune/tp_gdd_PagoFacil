namespace PagoAgilFrba.AbmRol
{
    partial class AltaRol
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
            System.Windows.Forms.Label labelNombreDeRol;
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.DarDeAlta = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.ListadoFuncionalidades = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            labelNombreDeRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreDeRol
            // 
            labelNombreDeRol.AutoSize = true;
            labelNombreDeRol.Location = new System.Drawing.Point(13, 9);
            labelNombreDeRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNombreDeRol.Name = "labelNombreDeRol";
            labelNombreDeRol.Size = new System.Drawing.Size(119, 15);
            labelNombreDeRol.TabIndex = 0;
            labelNombreDeRol.Text = "&Nombre de rol:";
            // 
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(140, 6);
            this.nombreRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(298, 25);
            this.nombreRol.TabIndex = 1;
            this.nombreRol.Leave += new System.EventHandler(this.nombreRol_Leave);
            // 
            // DarDeAlta
            // 
            this.DarDeAlta.Location = new System.Drawing.Point(295, 243);
            this.DarDeAlta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DarDeAlta.Name = "DarDeAlta";
            this.DarDeAlta.Size = new System.Drawing.Size(143, 27);
            this.DarDeAlta.TabIndex = 5;
            this.DarDeAlta.Text = "Dar de &alta";
            this.DarDeAlta.UseVisualStyleBackColor = true;
            this.DarDeAlta.Click += new System.EventHandler(this.DarDeAlta_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(16, 243);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 61;
            this.volverALaPaginaAnterior.Text = "&Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ListadoFuncionalidades
            // 
            this.ListadoFuncionalidades.AllowUserToResizeColumns = false;
            this.ListadoFuncionalidades.AllowUserToResizeRows = false;
            this.ListadoFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidad});
            this.ListadoFuncionalidades.Location = new System.Drawing.Point(16, 37);
            this.ListadoFuncionalidades.Name = "ListadoFuncionalidades";
            this.ListadoFuncionalidades.RowTemplate.Height = 27;
            this.ListadoFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ListadoFuncionalidades.Size = new System.Drawing.Size(422, 200);
            this.ListadoFuncionalidades.TabIndex = 62;
            this.ListadoFuncionalidades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoFuncionalidades_CellValueChanged);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.volverALaPaginaAnterior;
            this.ClientSize = new System.Drawing.Size(452, 281);
            this.Controls.Add(this.ListadoFuncionalidades);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.DarDeAlta);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(labelNombreDeRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AltaRol";
            this.Text = "Alta rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Button DarDeAlta;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.DataGridView ListadoFuncionalidades;
        private System.Windows.Forms.DataGridViewComboBoxColumn Funcionalidad;
    }
}