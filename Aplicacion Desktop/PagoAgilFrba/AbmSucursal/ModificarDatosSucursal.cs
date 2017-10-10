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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificacionSucursal_Load(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                 "select * from [SERVOMOTOR].SUCURSALES where ESTADO_HABILITACION=1",
                  Program.conexion()
              );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.dataGridView1.Rows.Add(
                    dataReader["COD_POSTAL"],
                    dataReader["NOMBRE"],
                    dataReader["DIRECCION"],
                    dataReader["ESTADO_HABILITACION"]


                );
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtCodPostal_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void BajaLogicaSucursal_Click(object sender, EventArgs e)
        {

            if (CodPostalSucursal != null)
            {
                Form formularioSiguiente = new AbmSucursal.ModificarSucursal(CodPostalSucursal);
                this.cambiarVisibilidades(formularioSiguiente);
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal clickeando en la tabla: ", "", MessageBoxButtons.OK);
            }

        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void buscar_Click(object sender, EventArgs e)
       
        {

            var cmd = new SqlCommand(
                "SELECT * " +
                "FROM [SERVOMOTOR].[SUCURSALES] s " +

                "WHERE (NOMBRE LIKE @NOMBRE OR @NOMBRE = '') " +
                "  AND (DIRECCION LIKE @DIRECCION OR @DIRECCION = '') " +
                "  AND (COD_POSTAL= @COD_POSTAL OR @COD_POSTAL = '')" +
                "  AND (ESTADO_HABILITACION = 1 )",
                Program.conexion()
            );

            cmd.Parameters.AddWithValue("@NOMBRE", "%" + txtNombreSucursal.Text + "%");
            cmd.Parameters.AddWithValue("@DIRECCION", "%" + txtDireccionSucursal.Text + "%");
            cmd.Parameters.AddWithValue("@COD_POSTAL", txtCodPostalSucursal.Text);




            var dataReader = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

             while (dataReader.Read())
            {
                this.dataGridView1.Rows.Add(
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
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bajaLogica_Click(object sender, EventArgs e)
        {

            if (CodPostalSucursal != null)
            {
                var cmd = new SqlCommand(
                "update [SERVOMOTOR].[SUCURSALES] set ESTADO_HABILITACION=0 where COD_POSTAL=" + CodPostalSucursal + ";",
                 Program.conexion()
             );

                var dataReader = cmd.ExecuteReader();
                MessageBox.Show("Se ha dado de baja la sucursal de codigo postal: " + CodPostalSucursal, "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal clickeando en la tabla: ", "", MessageBoxButtons.OK);
            }
        }

        private void seleccionarSucursal(object sender, DataGridViewCellEventArgs e)
        {
            int indexSucursal = dataGridView1.CurrentRow.Index;
            CodPostalSucursal = dataGridView1[0, indexSucursal].Value.ToString();

            MessageBox.Show("Se ha seleccionado la sucursal de codigo postal : " + CodPostalSucursal, "", MessageBoxButtons.OK);


        }
    }
}
