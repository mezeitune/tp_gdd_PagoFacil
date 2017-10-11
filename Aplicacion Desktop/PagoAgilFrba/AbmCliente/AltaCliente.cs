using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PagoAgilFrba.AbmCliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {
            iniciar();
        }
        public void iniciar()
        {
            vaciarTextos();

        }
        private void vaciarTextos()
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = " ";
            txtDNICliente.Text = " ";
            txtMailCliente.Text = " ";
            txtTelCliente.Text = " ";
            txtCalleCliente.Text = " ";
            txtNroPisoCliente.Text = " ";
            txtDptoCliente.Text = " ";
            txtLocalidadCliente.Text = " ";
            txtCodPostalCliente.Clear();
            DateTimePicker fechaDeAhora= new DateTimePicker ();
            FechaNacCliente.Value = fechaDeAhora.Value;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNICliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroPisoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDptoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalidadCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtFechaNacCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPosCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DarAltaCliente_Click(object sender, EventArgs e)
        {
            int estadoHab = 1;
            
            if (!todosLosCamposLLenos() && !validarTipos())
            {
                
                var cmd = new SqlCommand(
               "insert into [SERVOMOTOR].[CLIENTES] values ("+txtDNICliente.Text+",'" + txtNombreCliente.Text + "','" + txtApellidoCliente.Text + "','" + txtMailCliente.Text  +
               "','" + txtCodPostalCliente.Text + "','" + txtCalleCliente.Text + "','" + txtNroPisoCliente.Text + "','" + txtDptoCliente.Text + "','" + txtLocalidadCliente.Text + "','" + FechaNacCliente.Value + "','" + txtCodPostalCliente.Text +"','"+estadoHab+ "');",
                Program.conexion()
            );
                var dataReader = cmd.ExecuteReader();
                MessageBox.Show("Se ha dado de alta correctamente", "Todo bien", MessageBoxButtons.OK);
                this.vaciarTextos();
            }
            else { 

            }
            
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtApellidoCliente, "apellido", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNombreCliente, "nombre", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtCalleCliente, "calle", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtDptoCliente, "departamento", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtMailCliente, "mail", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtDNICliente, "DNI", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtCodPostalCliente, "Cod Postal", true) || huboErrores;
            
            huboErrores = Validacion.esVacio(txtLocalidadCliente, "Localidad", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNroPisoCliente, "Numero Piso", true) || huboErrores;

            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esTextoAlfanumerico(txtApellidoCliente, true, "apellido", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtNombreCliente, true, "nombre", true) || huboErrores;
            huboErrores = !Validacion.esNumeroDe7u8(txtDNICliente) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtMailCliente, true, "Mail", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtTelCliente, "Telefono", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtCalleCliente, true, "Calle", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtNroPisoCliente, "Numero Piso", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtDptoCliente, "Departamento", true) || huboErrores;
            huboErrores = !Validacion.esTextoAlfanumerico(txtLocalidadCliente, true, "Localidad", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtCodPostalCliente, "Codigo Postal", true) || huboErrores;
            
            return huboErrores;
        }

        private void FechaNacCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.vaciarTextos();
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.cambiarVisibilidades(formularioSiguiente);
        }
    }
}
