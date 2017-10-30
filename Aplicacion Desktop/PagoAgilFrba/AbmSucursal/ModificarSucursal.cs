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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class ModificarSucursal : Form
    {
        String codigoPostal;
        public ModificarSucursal(String codigoPostall)
        {
            codigoPostal = codigoPostall;
            InitializeComponent();
        }

      //NO MOSTRAMOS EL CODIGO POSTAL PORQUE YA SE INGRESO PREVIAMENTE Y ADEMAS NO SE PUEDE MODIFICAR
        private void ModificarSucursal_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {

                var cmd = new SqlCommand(
                 "EXEC [SERVOMOTOR].insertOUpdateEnSucursales @TIPOOPERACION,@COD_POSTAL,@NOMBRE,@DIRECCION,@ESTADO_HABILITACION",
               Program.conexion()
                  );
                cmd.Parameters.AddWithValue("@TIPOOPERACION", 0);
                cmd.Parameters.AddWithValue("@COD_POSTAL", codigoPostal);
                cmd.Parameters.AddWithValue("@NOMBRE", txtNombreSucursal.Text);
                cmd.Parameters.AddWithValue("@DIRECCION", txtDireccionSucursal.Text);
                cmd.Parameters.AddWithValue("@ESTADO_HABILITACION", 1);


                var dataReader = cmd.ExecuteReader();
                MessageBox.Show("Se ha modificado correctamente la sucursal de Cod Postal: " +  codigoPostal, "", MessageBoxButtons.OK);
               
                
                Form formularioSiguiente = new AbmSucursal.ModificarDatosSucursal();
                this.Hide();
                formularioSiguiente.ShowDialog();
                this.Show();
            }
           
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            
            huboErrores = Validacion.esVacio(txtDireccionSucursal, "direccion", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtNombreSucursal, "nombre", true) || huboErrores;


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
          
           

            return huboErrores;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ModificarSucursal_Load(object sender, EventArgs e)
        {
            completarTextos();
            Habilitar.Checked = true;
        }


        private void completarTextos()
        {
            var cmd = new SqlCommand(
                "select * from [SERVOMOTOR].SUCURSALES where COD_POSTAL=" + codigoPostal + ";",
                 Program.conexion()
             );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtNombreSucursal.Text = dataReader["NOMBRE"].ToString();
                txtDireccionSucursal.Text = dataReader["DIRECCION"].ToString();
               
            }


        }

     

    }
}
