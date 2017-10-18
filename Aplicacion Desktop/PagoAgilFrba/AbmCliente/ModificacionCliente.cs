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
    public partial class ModificacionClienteee : Form
    {
        private int indexCliente;
        
        private String DNICliente;
        

        public ModificacionClienteee()
        {
            InitializeComponent();
        }

        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDniExacto.Text = "";
            txtNombre.Text = "";

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if(  !Validacion.estaEntreLimites(txtDniExacto, 999999, 99999999, false, "DNI")){
                this.query_inicial();
            }else{
            Listado_Refresh();
            }
        }

        private void Listado_Refresh()
        {
 
           
            var cmd = new SqlCommand(
                "SELECT * " +
                "FROM [SERVOMOTOR].[CLIENTES] " +
                
                "WHERE (NOMBRE LIKE @NOMBRE OR @NOMBRE = '') " +
                "  AND (APELLIDO LIKE @APELLIDO OR @APELLIDO = '') " +
                "  AND (DNI = @DNI OR @DNI = '');" ,
                Program.conexion()
            );
           
            cmd.Parameters.AddWithValue("@NOMBRE", "%" + txtNombre.Text+ "%");
            cmd.Parameters.AddWithValue("@APELLIDO", "%" + txtApellido.Text + "%");
            cmd.Parameters.AddWithValue("@DNI", txtDniExacto.Text);


            var dataReader = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

            while (dataReader.Read())
            {
               
                this.dataGridView1.Rows.Add(
                    dataReader["DNI"],
                    dataReader["NOMBRE"],
                    dataReader["APELLIDO"],
                    dataReader["MAIL"],
                    dataReader["TELEFONO"],
                    dataReader["CALLE"],
                    dataReader["PISO"],
                    dataReader["DEPTO"],
                    dataReader["LOCALIDAD"],
                    dataReader["FECHA_NACIMIENTO"],
                    dataReader["COD_POSTAL_CLIENTE"],
                    dataReader["ESTADO_HABILITACION"]

                );
            } 
          
        }



        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void query_inicial()
        {
            var cmd = new SqlCommand(
                 "select * from [SERVOMOTOR].CLIENTES ",
                  Program.conexion()
              );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.dataGridView1.Rows.Add(
                    dataReader["DNI"],
                    dataReader["NOMBRE"],
                    dataReader["APELLIDO"],
                    dataReader["MAIL"],
                    dataReader["TELEFONO"],
                    dataReader["CALLE"],
                    dataReader["PISO"],
                    dataReader["DEPTO"],
                    dataReader["LOCALIDAD"],
                    dataReader["FECHA_NACIMIENTO"],
                    dataReader["COD_POSTAL_CLIENTE"],
                    dataReader["ESTADO_HABILITACION"]

                );
            }
        }
        private void Baja_Modificacion_Cliente_Load(object sender, EventArgs e)
        {
            this.query_inicial();
            button1.Enabled = false;
            bajaLogica.Enabled = false;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                "update [SERVOMOTOR].[CLIENTES] set ESTADO_HABILITACION=0 where DNI="+DNICliente+";",
                 Program.conexion()
             );

            var dataReader = cmd.ExecuteReader();
            MessageBox.Show("Se ha dado de baja el cliente de DNI: " + DNICliente, "", MessageBoxButtons.OK);
        }

        private void seleccionarCliente(object sender, DataGridViewCellEventArgs e)
        {
            indexCliente = dataGridView1.CurrentRow.Index;
            DNICliente = dataGridView1[0, indexCliente].Value.ToString();
            bajaLogica.Enabled = true;
            button1.Enabled = true;
            MessageBox.Show("Se ha seleccionado el cliente de DNI: "+DNICliente, "", MessageBoxButtons.OK);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.ModificarDatosCliente(DNICliente);
            this.cambiarVisibilidades(formularioSiguiente);
        }
      

    }
}
