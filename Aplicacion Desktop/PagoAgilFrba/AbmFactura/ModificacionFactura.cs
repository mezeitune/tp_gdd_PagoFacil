using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class ModificacionFactura : Form
    {
        public ModificacionFactura()
        {
            InitializeComponent();
        }

        private void ModificarFactura_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.ModificarDatosFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void comboBoxNroFacturaModif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }
    }
}
