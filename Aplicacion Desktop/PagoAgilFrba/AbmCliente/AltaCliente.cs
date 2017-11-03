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
            
            
            if (!todosLosCamposLLenos() && !validarTipos() && existenDatosDuplicados())
            {
                try
                {
                    var cmd = new SqlCommand(
                   "EXEC [SERVOMOTOR].insertOUpdateEnClientes @TIPOOPERACION,@DNI,@NOMBRE,@APELLIDO,@MAIL,@TELEFONO,@CALLE,@PISO,@DEPTO,@LOCALIDAD,@FECHANAC,@COD_POSTAL,@ESTADO",
               Program.conexion()
                  );
                    cmd.Parameters.AddWithValue("@TIPOOPERACION", 1);
                    cmd.Parameters.AddWithValue("@DNI", txtDNICliente.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@APELLIDO", txtApellidoCliente.Text);
                    cmd.Parameters.AddWithValue("@MAIL", txtMailCliente.Text);
                    cmd.Parameters.AddWithValue("@TELEFONO", txtTelCliente.Text);
                    cmd.Parameters.AddWithValue("@CALLE", txtCalleCliente.Text);
                    cmd.Parameters.AddWithValue("@PISO", txtNroPisoCliente.Text);
                    cmd.Parameters.AddWithValue("@DEPTO", txtDptoCliente.Text);
                    cmd.Parameters.AddWithValue("@LOCALIDAD", txtLocalidadCliente.Text);
                    cmd.Parameters.AddWithValue("@FECHANAC", FechaNacCliente.Value);
                    cmd.Parameters.AddWithValue("@COD_POSTAL", txtCodPostalCliente.Text);
                    cmd.Parameters.AddWithValue("@ESTADO", 1);

                    var dataReader = cmd.ExecuteReader();
                }
                catch (System.Data.SqlClient.SqlException)
                {//catcheamos la excepcion por alta duplicada

                    MessageBox.Show("El campo nombre o mail estan duplicados, vuelva a ingresar otro","", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Se ha dado de alta correctamente al cliente", "", MessageBoxButtons.OK);
                Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();

                formularioSiguiente.Visible = true;
                this.Visible = false;
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
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();

                formularioSiguiente.Visible = true;
                this.Visible = false;
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
