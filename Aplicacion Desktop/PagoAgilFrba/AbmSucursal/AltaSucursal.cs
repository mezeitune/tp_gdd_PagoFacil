using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class AltaSucursal : Form
    {
        public AltaSucursal()
        {
            InitializeComponent();
        }

        private void txtNombreSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPostalSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void DarAltaSucursal_Click(object sender, EventArgs e)
        {
            if (todosLosCamposLLenos() && validarTipos())
            {
               
                    //aca se da de alta la sucursal en la BDD
                MessageBox.Show("Se ha dado de alta correctamente", "Todo bien", MessageBoxButtons.OK);
            }
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtCodPostalSucursal, "codigo postal", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtDireccionSucursal, "direccion", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNombreSucursal, "nombre", true) || huboErrores;
            

            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esDecimal(txtCodPostalSucursal,"apellido", true ) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtDireccionSucursal, true, "direccion", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtNombreSucursal, true, "nombre", true) || huboErrores;
           
            return huboErrores;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCodPostalSucursal.Text = "";
            txtDireccionSucursal.Text = "";
            txtNombreSucursal.Text = "";
        }

        private void AltaSucursal_Load(object sender, EventArgs e)
        {

        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmSucursal.Form1();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

    }
}
