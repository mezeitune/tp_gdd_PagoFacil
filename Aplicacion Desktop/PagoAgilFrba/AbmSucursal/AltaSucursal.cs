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
    public partial class AltaSucursal : Form
    {
        public AltaSucursal()
        {
            InitializeComponent();
        }

        
        private void DarAltaSucursal_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {
                try
                {
                    var cmd = new SqlCommand(
                "EXEC [SERVOMOTOR].insertOUpdateEnSucursales @TIPOOPERACION,@COD_POSTAL,@NOMBRE,@DIRECCION,@ESTADO_HABILITACION", 
               Program.conexion()
                  );
                    cmd.Parameters.AddWithValue("@TIPOOPERACION", 1);
                    cmd.Parameters.AddWithValue("@COD_POSTAL", txtCodPostalSucursal.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txtNombreSucursal.Text);
                    cmd.Parameters.AddWithValue("@DIRECCION", txtDireccionSucursal.Text);
                    cmd.Parameters.AddWithValue("@ESTADO_HABILITACION", 1);
           
                    var dataReaderFactura = cmd.ExecuteReader();
                     }
                      catch (System.Data.SqlClient.SqlException)
                      {

                          MessageBox.Show("El campo codigo postal esta duplicado, vuelva a ingresar otro", "", MessageBoxButtons.OK);
                          return;
                      }
                MessageBox.Show("Se ha dado de alta correctamente", "Todo bien", MessageBoxButtons.OK);
                Form formularioSiguiente = new AbmSucursal.Form1();
                this.Hide();
                formularioSiguiente.ShowDialog();
                this.Show();
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
            huboErrores = !Validacion.esDecimal(txtCodPostalSucursal,"Codigo Postal", true ) || huboErrores;
         
           
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
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
