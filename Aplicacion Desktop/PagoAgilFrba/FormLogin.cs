using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        public void iniciar()
        {
            vaciarTextos();

            radioAdministrador.Checked = true;
            radioCobrador.Checked = false;

            gbAdministrador.Enabled = true;
            gbInvitado.Enabled = false;

            cargarSucursalesDisponibles();
        }

        private void radioAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            Boolean tildadoAdministrador = radioAdministrador.Checked;
            
            gbAdministrador.Enabled = tildadoAdministrador;
            gbInvitado.Enabled = !tildadoAdministrador;

            vaciarTextos();
        }

        private void vaciarTextos()
        {
            
            txtPassword.Text = "";
            txtUsuario.Text = "";
            SucursalesDisponibles.SelectedIndex = -1;
        }

        private void cargarSucursalesDisponibles()
        {
            SucursalesDisponibles.Items.Clear();

            SqlDataReader reader;
            SqlCommand consultaRoles = new SqlCommand();
            consultaRoles.CommandType = CommandType.Text;
            consultaRoles.CommandText = "SELECT * FROM [SERVOMOTOR].SUCURSALES";
            consultaRoles.Connection = Program.conexion();

            reader = consultaRoles.ExecuteReader();//CONSULTASUCURSALES

            while (reader.Read())
                SucursalesDisponibles.Items.Add(reader.GetValue(0));

            reader.Close();
        }


        // Se ejcuta al clickear en ingresar. Realiza las validaciones de acuerdo al tipo de usuario 
        // y pasa al menú principal si todo está bien
        private void botonIngresar_Click(object sender, EventArgs e)
        {
            if (radioAdministrador.Checked)
            {
                if (txtUsuario.Text.ToLower().Equals("invitado"))
                {
                    MessageBox.Show("El nombre de usuario ingresado no existe.", "Error", MessageBoxButtons.OK);
                    return;
                }
                ingresarComoAdministrador();
            }
            else
            {
                ingresarComoInvitado();
            }
        }

        

        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void ingresarComoAdministrador()
        {
            if (datosCorrectos())
            {
                intentarLoguearse();
            }
        }

        private bool datosCorrectos()
        {
            Boolean huboErrores = false;

            huboErrores = validarTipos() || huboErrores;
            huboErrores = validarLongitudes() || huboErrores;

            return !huboErrores;
        }

        // Verifica la contraseña con la base de datos (y los posibles ingresos erroneos de las mismas
        private void intentarLoguearse()
        {
            SQLManager manager = new SQLManager().generarSP("LoginAdministrador")
                                                 .agregarStringSP("@Usuario", txtUsuario)
                                                 .agregarStringSP("@ContraseniaIngresada", Encriptador.encriptarSegunSHA256(txtPassword.Text));

            try
            {
                manager.ejecutarSP();
                Form formularioSiguiente = new MenuPrincipal();
                this.cambiarVisibilidades(formularioSiguiente);
                //cambiarVisibilidades(new Principal("Administrador", txtUsuario.Text, this));
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }

            
        }
        

        private void ingresarComoInvitado()
        {
            if (Validacion.esVacio(SucursalesDisponibles, "rol", true))
                return;

         
        }

        private bool validarLongitudes()
        {
            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtUsuario, "usuario", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtPassword, "contraseña", true) || huboErrores;

            return huboErrores;
        }

        private bool validarTipos()
        {
            return !Validacion.esTextoAlfanumerico(txtUsuario,true, "usuario", true);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void radioCobrador_CheckedChanged(object sender, EventArgs e)
        {
            gbAdministrador.Enabled = true;
            gbInvitado.Enabled = true;
            //aca hay que verificar que el usuario cobrador se loguee piola y mostrar sus sucursales habilitadas, sino tirar error
        }

        private void SucursalesDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbInvitado_Enter(object sender, EventArgs e)
        {

        }

       

    }
}
