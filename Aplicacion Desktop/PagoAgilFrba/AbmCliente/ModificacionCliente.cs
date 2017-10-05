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
    public partial class ModificacionClienteee : Form
    {
        public ModificacionClienteee()
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

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void Baja_Modificacion_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
