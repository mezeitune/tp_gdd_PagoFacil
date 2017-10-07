using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Rendicion
{
    public partial class AgregarEmpresaARendir : Form
    {
        public AgregarEmpresaARendir()
        {
            InitializeComponent();
        }

        private void comboBoxNroFacturaModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar las facturas que no fueron rendidas
        }

        private void AgregarFacturaARendir_Click(object sender, EventArgs e)
        {
            if(todosLosCamposLLenos()){
                //esa factura que se agrego hay que mostrarla en la tabla de la pagina anterior
                MessageBox.Show("Algun campo se encuentra vacio o es erroneo", "Error en los datos de entrada", MessageBoxButtons.OK);
              
            }
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.estaCheckeadoComboBox(comboBoxNroFactura) || huboErrores;

            return huboErrores;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Rendicion.PantallaPrincipalRendicion();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
    }
}
