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
    public partial class ModificarDatosRol : Form
    {
        public ModificarDatosRol()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //mostrar las funcionalidades del rol elegido con un boton en cada una para que se pueda eliminar de a una
        }

        private void ModificarRol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha modificado el  rol correctamente", "Todo bien", MessageBoxButtons.OK);
        }

        private void irAAgregarFuncionalidades_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.AltaFuncionalidadesParaRolModificado() ;
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void nombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.ModificarRol();
            this.cambiarVisibilidades(formularioSiguiente);
        }
    }
}
