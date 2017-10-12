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
            using (Form formularioAlta = new AltaRol())
            {
                this.Hide();
                formularioAlta.ShowDialog();
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form formularioBaja = new BajaRol())
            {
                this.Hide();
                formularioBaja.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form formularioModificacion = new ModificarRol())
            {
                this.Hide();
                formularioModificacion.ShowDialog();
                this.Show();
            }
        }
        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
