using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class AltaEmpresa : Form
    {
        public AltaEmpresa()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nombre.Clear();
            CUIT.Clear();
            Direccion.Clear();
            DarDeAlta.Refresh();
        }

        private void AltaEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Rubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DarDeAlta_Click(object sender, EventArgs e)
        {

        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
