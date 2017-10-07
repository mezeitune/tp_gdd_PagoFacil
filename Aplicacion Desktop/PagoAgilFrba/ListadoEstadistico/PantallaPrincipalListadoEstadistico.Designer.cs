namespace PagoAgilFrba.ListadoEstadistico
{
    partial class PantallaPrincipalListadoEstadistico
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
            this.tiposDeListados = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.volverALaPaginaAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.anioDeConsulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTrimestre = new System.Windows.Forms.ComboBox();
            this.consultaTOP5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de consulta";
            // 
            // tiposDeListados
            // 
            this.tiposDeListados.FormattingEnabled = true;
            this.tiposDeListados.Items.AddRange(new object[] {
            "Porcentaje de facturas cobradas por empresa",
            "Empresas con mayor monto recibido",
            "Clientes con mas pagos",
            "Clientes mas cumplidores (Mayor % de facturas pagadas)"});
            this.tiposDeListados.Location = new System.Drawing.Point(202, 22);
            this.tiposDeListados.Name = "tiposDeListados";
            this.tiposDeListados.Size = new System.Drawing.Size(305, 21);
            this.tiposDeListados.TabIndex = 1;
            this.tiposDeListados.SelectedIndexChanged += new System.EventHandler(this.tiposDeListados_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 209);
            this.dataGridView1.TabIndex = 2;
            // 
            // volverALaPaginaAnterior
            // 
            this.volverALaPaginaAnterior.Location = new System.Drawing.Point(479, 381);
            this.volverALaPaginaAnterior.Name = "volverALaPaginaAnterior";
            this.volverALaPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.volverALaPaginaAnterior.TabIndex = 68;
            this.volverALaPaginaAnterior.Text = "Volver";
            this.volverALaPaginaAnterior.UseVisualStyleBackColor = true;
            this.volverALaPaginaAnterior.Click += new System.EventHandler(this.volverALaPaginaAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 254);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOP 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Año:";
            // 
            // anioDeConsulta
            // 
            this.anioDeConsulta.Location = new System.Drawing.Point(88, 59);
            this.anioDeConsulta.Name = "anioDeConsulta";
            this.anioDeConsulta.Size = new System.Drawing.Size(100, 20);
            this.anioDeConsulta.TabIndex = 71;
            this.anioDeConsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Trimestre:";
            // 
            // comboTrimestre
            // 
            this.comboTrimestre.FormattingEnabled = true;
            this.comboTrimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.comboTrimestre.Location = new System.Drawing.Point(312, 59);
            this.comboTrimestre.Name = "comboTrimestre";
            this.comboTrimestre.Size = new System.Drawing.Size(99, 21);
            this.comboTrimestre.TabIndex = 73;
            // 
            // consultaTOP5
            // 
            this.consultaTOP5.Location = new System.Drawing.Point(443, 59);
            this.consultaTOP5.Name = "consultaTOP5";
            this.consultaTOP5.Size = new System.Drawing.Size(111, 23);
            this.consultaTOP5.TabIndex = 74;
            this.consultaTOP5.Text = "Ejecutar Consulta";
            this.consultaTOP5.UseVisualStyleBackColor = true;
            this.consultaTOP5.Click += new System.EventHandler(this.consultaTOP5_Click);
            // 
            // PantallaPrincipalListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 416);
            this.Controls.Add(this.consultaTOP5);
            this.Controls.Add(this.comboTrimestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anioDeConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.volverALaPaginaAnterior);
            this.Controls.Add(this.tiposDeListados);
            this.Controls.Add(this.label1);
            this.Name = "PantallaPrincipalListadoEstadistico";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tiposDeListados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button volverALaPaginaAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox anioDeConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTrimestre;
        private System.Windows.Forms.Button consultaTOP5;
    }
}