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
            txtMailCliente.Clear();
            txtTelCliente.Text = " ";
            txtCalleCliente.Text = " ";
            txtNroPisoCliente.Text = " ";
            txtDptoCliente.Text = " ";
            txtLocalidadCliente.Text = " ";
            txtCodPostalCliente.Clear();
            DateTimePicker fechaDeAhora= new DateTimePicker ();
            FechaNacCliente.Value = fechaDeAhora.Value;

        }

        
        private void DarAltaCliente_Click(object sender, EventArgs e)
        {
            int estadoHab = 1;
            
            if (!todosLosCamposLLenos() && !validarTipos() && existenDatosDuplicados())
            {
                try
                {
                    var cmd = new SqlCommand(
                   "insert into [SERVOMOTOR].[CLIENTES] values (" + txtDNICliente.Text + ",'" + txtNombreCliente.Text + "','" + txtApellidoCliente.Text + "','" + txtMailCliente.Text +
                   "','" + txtCodPostalCliente.Text + "','" + txtCalleCliente.Text + "','" + txtNroPisoCliente.Text + "','" + txtDptoCliente.Text + "','" + txtLocalidadCliente.Text + "','" + FechaNacCliente.Value + "','" + txtCodPostalCliente.Text + "','" + estadoHab + "');",
                    Program.conexion()
                );
                    var dataReader = cmd.ExecuteReader();
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    MessageBox.Show("El campo nombre o mail estan duplicados, vuelva a ingresar otro","", MessageBoxButtons.OK);
                    return;
                }
                this.vaciarTextos();
            }
            
            
        }
        private Boolean existenDatosDuplicados() {
            return true;
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
            huboErrores = !Validacion.estaEntreLimites(txtDNICliente, 999999, 99999999, false, "DNI") || huboErrores;
            huboErrores = !Validacion.esNumeroDe4(txtCodPostalCliente,"Cod Postal") || huboErrores;
            huboErrores = !Validacion.esNumero(txtTelCliente, "Telefono", true) || huboErrores;
            huboErrores = !Validacion.fechaAnteriorALaDeHoy(FechaNacCliente) || huboErrores;
            huboErrores = !Validacion.esNumero(txtNroPisoCliente, "Numero Piso", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtDptoCliente, "Departamento", true) || huboErrores;
          
            huboErrores = !Validacion.esNumero(txtCodPostalCliente, "Codigo Postal", true) || huboErrores;
            
            return huboErrores;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            this.vaciarTextos();
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
