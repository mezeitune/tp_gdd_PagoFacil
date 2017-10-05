namespace PagoAgilFrba.AbmRol
{
    partial class AltaFuncionalidadesParaRolModificado
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
            this.Funcionalidad = new System.Windows.Forms.Label();
            this.FuncionalidadesAMostrar = new System.Windows.Forms.ComboBox();
            this.agregarFuncionalidadAlRol = new System.Windows.Forms.Button();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSize = true;
            this.Funcionalidad.Location = new System.Drawing.Point(47, 71);
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.Funcionalidad.TabIndex = 5;
            this.Funcionalidad.Text = "Funcionalidad";
            // 
            // FuncionalidadesAMostrar
            // 
            this.FuncionalidadesAMostrar.FormattingEnabled = true;
            this.FuncionalidadesAMostrar.Location = new System.Drawing.Point(149, 68);
            this.FuncionalidadesAMostrar.Name = "FuncionalidadesAMostrar";
            this.FuncionalidadesAMostrar.Size = new System.Drawing.Size(211, 21);
            this.FuncionalidadesAMostrar.TabIndex = 4;
            this.FuncionalidadesAMostrar.SelectedIndexChanged += new System.EventHandler(this.FuncionalidadesAMostrar_SelectedIndexChanged);
            // 
            // agregarFuncionalidadAlRol
            // 
            this.agregarFuncionalidadAlRol.Location = new System.Drawing.Point(133, 140);
            this.agregarFuncionalidadAlRol.Name = "agregarFuncionalidadAlRol";
            this.agregarFuncionalidadAlRol.Size = new System.Drawing.Size(133, 33);
            this.agregarFuncionalidadAlRol.TabIndex = 3;
            this.agregarFuncionalidadAlRol.Text = "Agregar Funcionalidad";
            this.agregarFuncionalidadAlRol.UseVisualStyleBackColor = true;
            this.agregarFuncionalidadAlRol.Click += new System.EventHandler(this.agregarFuncionalidadAlRol_Click);
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(317, 193);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 64;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // AltaFuncionalidadesParaRolModificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 228);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.Funcionalidad);
            this.Controls.Add(this.FuncionalidadesAMostrar);
            this.Controls.Add(this.agregarFuncionalidadAlRol);
            this.Name = "AltaFuncionalidadesParaRolModificado";
            this.Text = "AltaFuncionalidadesParaRolModificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Funcionalidad;
        private System.Windows.Forms.ComboBox FuncionalidadesAMostrar;
        private System.Windows.Forms.Button agregarFuncionalidadAlRol;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}