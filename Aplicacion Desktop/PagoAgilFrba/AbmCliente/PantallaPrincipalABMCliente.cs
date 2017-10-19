using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class PantallaPrincipalABMCliente : Form
    {
        public PantallaPrincipalABMCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.AltaCliente();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.ModificacionClienteee();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
