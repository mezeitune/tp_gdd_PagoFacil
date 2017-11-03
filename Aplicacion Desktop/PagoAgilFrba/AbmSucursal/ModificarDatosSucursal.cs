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
    public partial class ModificarDatosSucursal : Form
    {
        String CodPostalSucursal;
        public ModificarDatosSucursal()
        {
            InitializeComponent();
        }
        //CONSIDERMOS LA MISMA PANTALLA PARA BAJA Y MODIFICACION, REUTILIZANDO EL DATA GRID
       

        private void ModificacionSucursal_Load(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                 "select * from [SERVOMOTOR].SUCURSALES ;",
                  Program.conexion()
              );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.dataGridItems.Rows.Add(
                    dataReader["COD_POSTAL"],
                    dataReader["NOMBRE"],
                    dataReader["DIRECCION"],
                    dataReader["ESTADO_HABILITACION"]


                );
            }
            bajaLogica.Enabled = false;
            botonModificarSucursal.Enabled = false;
        }

        

        private void BajaLogicaSucursal_Click(object sender, EventArgs e)
        {

            if (CodPostalSucursal != null)
            {//PASO EL CODIGO POSTAL PARA ASI PODER MODIFICAR LOS DATOS DE UNA SUCURSAL
                Form formularioSiguiente = new AbmSucursal.ModificarSucursal(CodPostalSucursal);
                formularioSiguiente.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal clickeando en la tabla: ", "", MessageBoxButtons.OK);
            }

        }

        private void buscar_Click(object sender, EventArgs e)
       
        {

            this.listadoRefresh();
            
        }
        private void listadoRefresh() {
            var cmd = new SqlCommand(
                   "SELECT * " +
                   "FROM [SERVOMOTOR].[SUCURSALES] s " +

                   "WHERE (NOMBRE LIKE @NOMBRE OR @NOMBRE = '') " +
                   "  AND (DIRECCION LIKE @DIRECCION OR @DIRECCION = '') " +
                   "  AND (COD_POSTAL= @COD_POSTAL OR @COD_POSTAL = '')",
                   Program.conexion()
               );

            cmd.Parameters.AddWithValue("@NOMBRE", "%" + txtNombreSucursal.Text + "%");
            cmd.Parameters.AddWithValue("@DIRECCION", "%" + txtDireccionSucursal.Text + "%");
            cmd.Parameters.AddWithValue("@COD_POSTAL", txtCodPostalSucursal.Text);

            var dataReader = cmd.ExecuteReader();

            this.dataGridItems.Rows.Clear();

            while (dataReader.Read())
            {
                this.dataGridItems.Rows.Add(
                    dataReader["COD_POSTAL"],
                    dataReader["NOMBRE"],
                    dataReader["DIRECCION"],
                    dataReader["ESTADO_HABILITACION"]


                );
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCodPostalSucursal.Text = "";
            txtDireccionSucursal.Text = "";
            txtNombreSucursal.Text = "";
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmSucursal.Form1();

            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void bajaLogica_Click(object sender, EventArgs e)
        {

            if (CodPostalSucursal != null)
            {
                var cmd = new SqlCommand(
                 "update SERVOMOTOR.SUCURSALES set ESTADO_HABILITACION=0 WHERE COD_POSTAL='"+CodPostalSucursal+"'",
               Program.conexion()
                  );
               


                var dataReader = cmd.ExecuteReader();
                
                MessageBox.Show("Se ha dado de baja la sucursal de codigo postal: " + CodPostalSucursal, "", MessageBoxButtons.OK);
                txtCodPostalSucursal.Text = "";
                txtDireccionSucursal.Text = "";
                txtNombreSucursal.Text = "";
                this.listadoRefresh();
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal clickeando en la tabla: ", "", MessageBoxButtons.OK);
            }
        }

        private void seleccionarSucursal(object sender, DataGridViewCellEventArgs e)
        {
            int indexSucursal = dataGridItems.CurrentRow.Index;
            CodPostalSucursal = dataGridItems[0, indexSucursal].Value.ToString();

            MessageBox.Show("Se ha seleccionado la sucursal de codigo postal : " + CodPostalSucursal, "", MessageBoxButtons.OK);
            bajaLogica.Enabled = true;
            botonModificarSucursal.Enabled =true;

        }

    }
}
