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
    public partial class PantallaPrincipalABMRol : Form
    {
        public PantallaPrincipalABMRol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.AltaRol();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.BajaRol();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmRol.ModificarRol();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
    }
}
