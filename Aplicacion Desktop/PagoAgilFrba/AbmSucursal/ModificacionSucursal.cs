using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class ModificacionSucursal : Form
    {
        public ModificacionSucursal()
        {
            InitializeComponent();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificacionSucursal_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtCodPostal_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void BajaLogicaSucursal_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmSucursal.ModificarSucursal();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCodPostalSucursal.Text = "";
            txtDireccionSucursal.Text = "";
            txtNombreSucursal.Text = "";
        }
    }
}
