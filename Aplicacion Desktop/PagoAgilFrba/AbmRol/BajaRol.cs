using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
        }

        private void BajaRol_Load(object sender, EventArgs e)
        {

        }

        private void rolParaDarDeBaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void darDeBajaRol_Click(object sender, EventArgs e)
        {
            //aca se updatea el estado del rol para que no pueda ser asignado a ningun usuario
            MessageBox.Show("Se ha inhabilitado el rol correctamente", "Todo bien", MessageBoxButtons.OK);
        }
    }
}
