namespace PagoAgilFrba.AbmRol
{
    partial class ModificarRol
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
            this.ModificarUnRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModificarUnRol
            // 
            this.ModificarUnRol.Location = new System.Drawing.Point(162, 205);
            this.ModificarUnRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModificarUnRol.Name = "ModificarUnRol";
            this.ModificarUnRol.Size = new System.Drawing.Size(155, 27);
            this.ModificarUnRol.TabIndex = 5;
            this.ModificarUnRol.Text = "Modificar Rol";
            this.ModificarUnRol.UseVisualStyleBackColor = true;
            this.ModificarUnRol.Click += new System.EventHandler(this.ModificarRol_Click);
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
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(463, 205);
            this.volverALaPaginaAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(100, 27);
            this.volverALaPaginaAnterior.TabIndex = 62;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 246);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.ModificarUnRol);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModificarRol";
            this.Text = "ModificarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificarUnRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
    }
}