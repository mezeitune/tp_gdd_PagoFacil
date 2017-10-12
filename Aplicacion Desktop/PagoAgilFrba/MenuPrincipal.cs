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
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
        private void botonABMCliente_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void botonABMSucursal_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmSucursal.Form1();
            this.cambiarVisibilidades(formularioSiguiente);
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
            this.cambiarVisibilidades(formularioSiguiente);
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
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void botonRegistrarPago_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new RegistroPago.PantallaPrincipalRegistroPagoFacturas(); //falta hacer esto
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void botonRendicion_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Rendicion.PantallaPrincipalRendicion();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }



        
    }
}
