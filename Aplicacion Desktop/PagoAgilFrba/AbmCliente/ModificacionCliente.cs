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

       



        private void ModificacionCliente_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.ModificarDatosCliente();
            this.cambiarVisibilidades(formularioSiguiente);

        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDniExacto.Text = "";
            txtNombre.Text = "";

        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDniExacto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
