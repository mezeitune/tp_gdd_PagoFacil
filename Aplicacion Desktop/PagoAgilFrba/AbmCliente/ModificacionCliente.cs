using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class Baja_Modificacion_Cliente : Form
    {
        public Baja_Modificacion_Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ModificacionCliente_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.ModificarDatosCliente();
            this.cambiarVisibilidades(formularioSiguiente);

        }

        private void buscaPorDniExacto_Click(object sender, EventArgs e)
        {

        }

        private void buscaPorApellido_Click(object sender, EventArgs e)
        {

        }

        private void buscaPorNombre_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
    }
}
