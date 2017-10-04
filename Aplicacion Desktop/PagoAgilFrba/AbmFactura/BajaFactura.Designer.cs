namespace PagoAgilFrba.AbmFactura
{
    partial class BajaFactura
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
            this.comboBoxNroFactura = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BajaLogicaFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elija una Factura a dar de baja, recuerde que no apareceran las facturas pagas co" +
    "mo tambien las rendidas";
            // 
            // comboBoxNroFactura
            // 
            this.comboBoxNroFactura.FormattingEnabled = true;
            this.comboBoxNroFactura.Location = new System.Drawing.Point(166, 78);
            this.comboBoxNroFactura.Name = "comboBoxNroFactura";
            this.comboBoxNroFactura.Size = new System.Drawing.Size(330, 21);
            this.comboBoxNroFactura.TabIndex = 13;
            this.comboBoxNroFactura.SelectedIndexChanged += new System.EventHandler(this.comboBoxNroFacturaBaja_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Numero de Factura";
            // 
            // BajaLogicaFactura
            // 
            this.BajaLogicaFactura.Location = new System.Drawing.Point(212, 152);
            this.BajaLogicaFactura.Name = "BajaLogicaFactura";
            this.BajaLogicaFactura.Size = new System.Drawing.Size(96, 38);
            this.BajaLogicaFactura.TabIndex = 29;
            this.BajaLogicaFactura.Text = "Baja Logica Factura";
            this.BajaLogicaFactura.UseVisualStyleBackColor = true;
            this.BajaLogicaFactura.Click += new System.EventHandler(this.BajaLogicaFactura_Click);
            // 
            // BajaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 220);
            this.Controls.Add(this.BajaLogicaFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNroFactura);
            this.Controls.Add(this.label1);
            this.Name = "BajaFactura";
            this.Text = "BajaFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNroFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BajaLogicaFactura;
    }
}