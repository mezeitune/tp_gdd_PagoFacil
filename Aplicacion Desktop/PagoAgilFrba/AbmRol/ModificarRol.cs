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
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
        }

        private void ModificarRol_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.ModificarDatosRol();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void rolParaModificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
