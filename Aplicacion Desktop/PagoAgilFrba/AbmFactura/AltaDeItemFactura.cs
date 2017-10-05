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
    public partial class AltaDeItemFactura : Form
    {
        public AltaDeItemFactura()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadDeItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardarUnItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha guardado un item correctamente en la factura", "Todo bien", MessageBoxButtons.OK);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCantidadDeItems.Text = "";
            txtMontoItem.Text = "";
        }
    }
}
