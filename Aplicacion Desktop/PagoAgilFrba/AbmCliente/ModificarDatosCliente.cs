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
    public partial class ModificarDatosCliente : Form
    {
        public ModificarDatosCliente()
        {
            InitializeComponent();
        }

        private void ModificarCliente_Click(object sender, EventArgs e)
        {
            if (todosLosCamposLLenos())
            {
                if (validarTipos())
                {
                    //update de todos los datos juntos
                }

            }
           
            MessageBox.Show("Se modifico correctamente al cliente", "Todo piola", MessageBoxButtons.OK);
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtApellidoCliente, "apellido", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNombreCliente, "nombre", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtCalleCliente, "calle", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtDptoCliente, "departamento", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtMailCliente, "mail", true) || huboErrores;
            
            huboErrores = Validacion.esVacio(txtCodPostalCliente, "Cod Postal", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtFechaNacCliente, "Fecha Nacimiento", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtLocalidadCliente, "Localidad", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNroPisoCliente, "Numero Piso", true) || huboErrores;

            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esTextoAlfanumerico(txtApellidoCliente, true, "apellido", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtNombreCliente, true, "nombre", true) || huboErrores;
            
            huboErrores = !Validacion.esTextoAlfanumerico(txtMailCliente, true, "Mail", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtTelCliente, true, "Telefono", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtCalleCliente, true, "Calle", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtNroPisoCliente, true, "Numero Piso", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtDptoCliente, true, "Departamento", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtLocalidadCliente, true, "Localidad", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtCodPostalCliente, "Codigo Postal", true) || huboErrores;
            huboErrores = !Validacion.esFormatoDeFecha(txtFechaNacCliente, "Fecha Nacimiento") || huboErrores;
            return huboErrores;
        }
       
        private void txtFechaNacCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPostalCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalidadCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDptoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroPisoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
