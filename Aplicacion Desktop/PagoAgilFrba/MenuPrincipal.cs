using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonABMCliente_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonABMSucursal_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmSucursal.Form1();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonABMEmpresa_Click(object sender, EventArgs e)
        {
            Form formularioEmpresa = new AbmEmpresa.PantallaPrincipalABMEmpresa();
            this.Hide();
            formularioEmpresa.ShowDialog();
            this.Show();
        }

        private void botonABMFactura_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonABMRol_Click(object sender, EventArgs e)
        {
            Form formularioABMRol = new AbmRol.PantallaPrincipalABMRol();
            this.Hide();
            formularioABMRol.ShowDialog();
            this.Show();
        }

        private void botonListadoEstadistico_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new ListadoEstadistico.PantallaPrincipalListadoEstadistico();//falta hacer esto
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonRegistrarPago_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new RegistroPago.PantallaPrincipalRegistroPagoFacturas(); //falta hacer esto
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonRendicion_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Rendicion.PantallaPrincipalRendicion();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Devolucion.DevolucionFactura();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }



        
    }
}
