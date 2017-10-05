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
            this.rolParaModificar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModificarUnRol
            // 
            this.ModificarUnRol.Location = new System.Drawing.Point(163, 124);
            this.ModificarUnRol.Name = "ModificarUnRol";
            this.ModificarUnRol.Size = new System.Drawing.Size(116, 40);
            this.ModificarUnRol.TabIndex = 5;
            this.ModificarUnRol.Text = "Modificar Rol";
            this.ModificarUnRol.UseVisualStyleBackColor = true;
            this.ModificarUnRol.Click += new System.EventHandler(this.ModificarRol_Click);
            // 
            // rolParaModificar
            // 
            this.rolParaModificar.FormattingEnabled = true;
            this.rolParaModificar.Location = new System.Drawing.Point(215, 51);
            this.rolParaModificar.Name = "rolParaModificar";
            this.rolParaModificar.Size = new System.Drawing.Size(197, 21);
            this.rolParaModificar.TabIndex = 4;
            this.rolParaModificar.SelectedIndexChanged += new System.EventHandler(this.rolParaModificar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un Rol para modificarlo";
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 213);
            this.Controls.Add(this.ModificarUnRol);
            this.Controls.Add(this.rolParaModificar);
            this.Controls.Add(this.label1);
            this.Name = "ModificarRol";
            this.Text = "ModificarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificarUnRol;
        private System.Windows.Forms.ComboBox rolParaModificar;
        private System.Windows.Forms.Label label1;
    }
}