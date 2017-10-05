namespace PagoAgilFrba.AbmRol
{
    partial class BajaRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.rolParaDarDeBaja = new System.Windows.Forms.ComboBox();
            this.darDeBajaRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un Rol para inhabilitarlo";
            // 
            // rolParaDarDeBaja
            // 
            this.rolParaDarDeBaja.FormattingEnabled = true;
            this.rolParaDarDeBaja.Location = new System.Drawing.Point(227, 32);
            this.rolParaDarDeBaja.Name = "rolParaDarDeBaja";
            this.rolParaDarDeBaja.Size = new System.Drawing.Size(197, 21);
            this.rolParaDarDeBaja.TabIndex = 1;
            this.rolParaDarDeBaja.SelectedIndexChanged += new System.EventHandler(this.rolParaDarDeBaja_SelectedIndexChanged);
            // 
            // darDeBajaRol
            // 
            this.darDeBajaRol.Location = new System.Drawing.Point(175, 105);
            this.darDeBajaRol.Name = "darDeBajaRol";
            this.darDeBajaRol.Size = new System.Drawing.Size(116, 40);
            this.darDeBajaRol.TabIndex = 2;
            this.darDeBajaRol.Text = "Inhabilitar Rol";
            this.darDeBajaRol.UseVisualStyleBackColor = true;
            this.darDeBajaRol.Click += new System.EventHandler(this.darDeBajaRol_Click);
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 190);
            this.Controls.Add(this.darDeBajaRol);
            this.Controls.Add(this.rolParaDarDeBaja);
            this.Controls.Add(this.label1);
            this.Name = "BajaRol";
            this.Text = "BajaRol";
            this.Load += new System.EventHandler(this.BajaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rolParaDarDeBaja;
        private System.Windows.Forms.Button darDeBajaRol;
    }
}