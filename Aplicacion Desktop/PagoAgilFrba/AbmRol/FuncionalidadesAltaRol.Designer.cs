namespace PagoAgilFrba.AbmRol
{
    partial class FuncionalidadesAltaRol
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
            this.agregarFuncionalidadAlRolModificado = new System.Windows.Forms.Button();
            this.FuncionalidadesAMostrar = new System.Windows.Forms.ComboBox();
            this.Funcionalidad = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarFuncionalidadAlRolModificado
            // 
            this.agregarFuncionalidadAlRolModificado.Location = new System.Drawing.Point(112, 135);
            this.agregarFuncionalidadAlRolModificado.Name = "agregarFuncionalidadAlRolModificado";
            this.agregarFuncionalidadAlRolModificado.Size = new System.Drawing.Size(133, 33);
            this.agregarFuncionalidadAlRolModificado.TabIndex = 0;
            this.agregarFuncionalidadAlRolModificado.Text = "Agregar Funcionalidad";
            this.agregarFuncionalidadAlRolModificado.UseVisualStyleBackColor = true;
            this.agregarFuncionalidadAlRolModificado.Click += new System.EventHandler(this.agregarFuncionalidadAlRol_Click);
            // 
            // FuncionalidadesAMostrar
            // 
            this.FuncionalidadesAMostrar.FormattingEnabled = true;
            this.FuncionalidadesAMostrar.Location = new System.Drawing.Point(128, 63);
            this.FuncionalidadesAMostrar.Name = "FuncionalidadesAMostrar";
            this.FuncionalidadesAMostrar.Size = new System.Drawing.Size(211, 21);
            this.FuncionalidadesAMostrar.TabIndex = 1;
            this.FuncionalidadesAMostrar.SelectedIndexChanged += new System.EventHandler(this.funcionalidadesAMostar_SelectedIndexChanged);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSize = true;
            this.Funcionalidad.Location = new System.Drawing.Point(26, 66);
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.Funcionalidad.TabIndex = 2;
            this.Funcionalidad.Text = "Funcionalidad";
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(264, 181);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 64;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // FuncionalidadesAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 216);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.Funcionalidad);
            this.Controls.Add(this.FuncionalidadesAMostrar);
            this.Controls.Add(this.agregarFuncionalidadAlRolModificado);
            this.Name = "FuncionalidadesAltaRol";
            this.Text = "FuncionalidadesAltaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarFuncionalidadAlRolModificado;
        private System.Windows.Forms.ComboBox FuncionalidadesAMostrar;
        private System.Windows.Forms.Label Funcionalidad;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}