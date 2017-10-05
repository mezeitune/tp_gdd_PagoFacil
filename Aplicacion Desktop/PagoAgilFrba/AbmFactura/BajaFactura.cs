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
    public partial class BajaFactura : Form
    {
        public BajaFactura()
        {
            InitializeComponent();
        }

        private void comboBoxNroFacturaBaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BajaLogicaFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha dado de baja correctamente", "Todo bien", MessageBoxButtons.OK);
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
    }
}
