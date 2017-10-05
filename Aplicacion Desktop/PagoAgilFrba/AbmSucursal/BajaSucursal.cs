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
    public partial class BajaSucursal : Form
    {
        public BajaSucursal()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPostal_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void BajaLogicaCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha dado de baja correctamente", "Todo bien", MessageBoxButtons.OK);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCodPostalSucursal.Text = "";
            txtDireccionSucursal.Text = "";
            txtNombreSucursal.Text = "";
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
