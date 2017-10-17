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
            System.Windows.Forms.GroupBox groupBox;
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.DarDeAlta = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.ListadoFuncionalidades = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            labelNombreDeRol = new System.Windows.Forms.Label();
            groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).BeginInit();
            groupBox.SuspendLayout();
            this.SuspendLayout();
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
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(130, 18);
            this.nombreRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(348, 25);
            this.nombreRol.TabIndex = 1;
            this.nombreRol.Leave += new System.EventHandler(this.nombreRol_Leave);
            // 
            // DarDeAlta
            // 
            this.DarDeAlta.Location = new System.Drawing.Point(357, 277);
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
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(16, 277);
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
            this.ListadoFuncionalidades.Location = new System.Drawing.Point(6, 49);
            this.ListadoFuncionalidades.Name = "ListadoFuncionalidades";
            this.ListadoFuncionalidades.RowTemplate.Height = 27;
            this.ListadoFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ListadoFuncionalidades.Size = new System.Drawing.Size(472, 200);
            this.ListadoFuncionalidades.TabIndex = 62;
            this.ListadoFuncionalidades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoFuncionalidades_CellValueChanged);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(labelNombreDeRol);
            groupBox.Controls.Add(this.ListadoFuncionalidades);
            groupBox.Controls.Add(this.nombreRol);
            groupBox.Location = new System.Drawing.Point(16, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new System.Drawing.Size(484, 259);
            groupBox.TabIndex = 63;
            groupBox.TabStop = false;
            groupBox.Text = "Datos";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.volverALaPaginaAnterior;
            this.ClientSize = new System.Drawing.Size(516, 316);
            this.Controls.Add(groupBox);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.DarDeAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AltaRol";
            this.Text = "Alta rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFuncionalidades)).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Button DarDeAlta;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.DataGridView ListadoFuncionalidades;
        private System.Windows.Forms.DataGridViewComboBoxColumn Funcionalidad;
    }
}