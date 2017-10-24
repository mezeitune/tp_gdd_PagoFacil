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
    public partial class ModificarDatosCliente : Form
    {
        private String DNICliente;


        //PASAMOS POR CONSTRUCTOR EL DNI DEL CLIENTE PARA PODER CONSULTAR SUS DATOS PARA MODIFICARLOS
        //NO MOSTRAMOS EL DNI YA QUE PREVIAMENTE SE ELIGIO Y TAMPOCO SE PUEDE MODIFICAR EN EL SISTEMA
        public ModificarDatosCliente(String DNIClientee)
        {
            DNICliente = DNIClientee;
            InitializeComponent();
        }
        
        
        private void completarTextos()
        {
            var cmd = new SqlCommand(
                "select * from [SERVOMOTOR].CLIENTES where DNI="+DNICliente+";",
                 Program.conexion()
             );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtNombre.Text = dataReader["NOMBRE"].ToString();
                txtApellidoCliente.Text = dataReader["APELLIDO"].ToString();
                txtCodPostalCliente.Text = dataReader["COD_POSTAL_CLIENTE"].ToString();
                txtMailCliente.Text = dataReader["MAIL"].ToString();
                txtTelCliente.Text = dataReader["TELEFONO"].ToString();
                txtCalleCliente.Text = dataReader["CALLE"].ToString();
                txtNroPisoCliente.Text = dataReader["PISO"].ToString();
                txtDptoCliente.Text = dataReader["DEPTO"].ToString();
                txtLocalidadCliente.Text = dataReader["LOCALIDAD"].ToString();
                FechaNacCliente.Value = Convert.ToDateTime(dataReader["FECHA_NACIMIENTO"]);
            }
           
          
        }
        private void ModificarCliente_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {

                var cmd = new SqlCommand(
                "update [SERVOMOTOR].[CLIENTES] set NOMBRE='" + txtNombre.Text + "',APELLIDO='" + txtApellidoCliente.Text + "',COD_POSTAL_CLIENTE='" + txtCodPostalCliente.Text +
                "',MAIL='" + txtMailCliente.Text + "',TELEFONO=" + txtTelCliente.Text + ",CALLE='" + txtCalleCliente.Text + "',PISO='" + txtNroPisoCliente.Text + "',DEPTO='" + txtDptoCliente.Text + "',LOCALIDAD='" + txtLocalidadCliente.Text + "',FECHA_NACIMIENTO='" + FechaNacCliente.Value + "',ESTADO_HABILITACION="+( Habilitar.Checked ? 1 : 0)+" where DNI='" + DNICliente + "';",
                 Program.conexion()
             );
                var dataReader = cmd.ExecuteReader();
                MessageBox.Show("Se ha modificado correctamente el cliente de DNI: " + DNICliente, "", MessageBoxButtons.OK);
                Form formularioSiguiente = new AbmCliente.ModificacionClienteee();
                this.Hide();
                formularioSiguiente.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("Algun campo esta vacio o el formato es incorrecto.", "", MessageBoxButtons.OK);
            }
           
           
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtApellidoCliente, "apellido", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNombre, "nombre", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtCalleCliente, "calle", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtDptoCliente, "departamento", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtMailCliente, "mail", true) || huboErrores;
            
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
     
            huboErrores = !Validacion.esNumeroDe4(txtCodPostalCliente, "Cod Postal") || huboErrores;
            huboErrores = !Validacion.esNumero(txtTelCliente, "Telefono", true) || huboErrores;
            huboErrores = !Validacion.fechaAnteriorALaDeHoy(FechaNacCliente) || huboErrores;
            huboErrores = !Validacion.esNumero(txtNroPisoCliente, "Numero Piso", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtDptoCliente, "Departamento", true) || huboErrores;

            huboErrores = !Validacion.esNumero(txtCodPostalCliente, "Codigo Postal", true) || huboErrores;
           
            return huboErrores;
        }
       
        
        private void limpiar_Click(object sender, EventArgs e)
        {
            this.completarTextos();
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    
        private void ModificarDatosCliente_Load(object sender, EventArgs e)
        {
            Habilitar.Checked = true;
            completarTextos();
        }

      
    }
}
