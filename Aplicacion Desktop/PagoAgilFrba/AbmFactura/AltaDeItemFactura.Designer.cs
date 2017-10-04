namespace PagoAgilFrba.AbmFactura
{
    partial class AltaDeItemFactura
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
            this.botonGuardarUnItem = new System.Windows.Forms.Button();
            this.txtCantidadDeItems = new System.Windows.Forms.TextBox();
            this.txtMontoItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonGuardarUnItem
            // 
            this.botonGuardarUnItem.Location = new System.Drawing.Point(158, 132);
            this.botonGuardarUnItem.Name = "botonGuardarUnItem";
            this.botonGuardarUnItem.Size = new System.Drawing.Size(109, 34);
            this.botonGuardarUnItem.TabIndex = 60;
            this.botonGuardarUnItem.Text = "Guardar Item";
            this.botonGuardarUnItem.UseVisualStyleBackColor = true;
            this.botonGuardarUnItem.Click += new System.EventHandler(this.botonGuardarUnItem_Click);
            // 
            // txtCantidadDeItems
            // 
            this.txtCantidadDeItems.Location = new System.Drawing.Point(219, 65);
            this.txtCantidadDeItems.Name = "txtCantidadDeItems";
            this.txtCantidadDeItems.Size = new System.Drawing.Size(193, 20);
            this.txtCantidadDeItems.TabIndex = 56;
            this.txtCantidadDeItems.TextChanged += new System.EventHandler(this.txtCantidadDeItems_TextChanged);
            // 
            // txtMontoItem
            // 
            this.txtMontoItem.Location = new System.Drawing.Point(219, 34);
            this.txtMontoItem.Name = "txtMontoItem";
            this.txtMontoItem.Size = new System.Drawing.Size(193, 20);
            this.txtMontoItem.TabIndex = 55;
            this.txtMontoItem.TextChanged += new System.EventHandler(this.txtMontoItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Monto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 49;
            // 
            // AltaDeItemFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 186);
            this.Controls.Add(this.botonGuardarUnItem);
            this.Controls.Add(this.txtCantidadDeItems);
            this.Controls.Add(this.txtMontoItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaDeItemFactura";
            this.Text = "AltaDeItemFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonGuardarUnItem;
        private System.Windows.Forms.TextBox txtCantidadDeItems;
        private System.Windows.Forms.TextBox txtMontoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}