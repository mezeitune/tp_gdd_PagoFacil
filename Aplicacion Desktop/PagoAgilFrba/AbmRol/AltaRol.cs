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
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void nombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void irAPantallaDeFuncionalidades_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.FuncionalidadesAltaRol();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //mostrar las funcionalidades que se fueron agregando (sin repetidos pero se valida en la pantalla de funcionalidadesAltaRol)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha dado de alta correctamente", "Todo bien", MessageBoxButtons.OK);
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.PantallaPrincipalABMRol(); 
            this.cambiarVisibilidades(formularioSiguiente);
        }

    }
}
