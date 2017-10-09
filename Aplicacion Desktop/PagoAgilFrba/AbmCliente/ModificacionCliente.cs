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

        string queryinicial = "select * from [SERVOMOTOR].[CLIENTES] ";

       

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            string query = queryinicial;
            
            if(txtApellido.Text!=""){
                query += "where " + agregarLikeApellido() + ";";
                this.ejecutarQuery(query);

            }

            if(txtNombre.Text!=""){
                query += "where " + agregarLikeNombre() + ";";
                this.ejecutarQuery(query);

            }
            if(txtDniExacto.Text!="" && Validacion.esNumeroDe7u8(txtDniExacto)){
                query += "where " + agregarLikeDni() + ";";
                this.ejecutarQuery(query);

            }




           
        }
        private void ejecutarQuery(string Query)
        {

            var cmd = new SqlCommand(
                 Query,
                  Program.conexion()
              );


            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.dataGridView1.Rows.Clear();
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
        private string agregarLikeApellido() {
            return ( " APELLIDO LIKE '%" + txtApellido.Text + "%'");
           
        }
        private string agregarLikeNombre()
        {
            return ( " NOMBRE LIKE '%" + txtNombre.Text + "%'");

        }
        private string agregarLikeDni()
        {
            return (" DNI=" + txtDniExacto.Text + "");

        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDniExacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void query_inicial()
        {
            var cmd = new SqlCommand(
                 "select * from [SERVOMOTOR].CLIENTES",
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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("Se ha modificado correctamente", "Todo bien", MessageBoxButtons.OK);
           
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
            
            MessageBox.Show("Se ha seleccionado el cliente de DNI: "+DNICliente, "", MessageBoxButtons.OK);
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DNICliente!=null)
            {
                Form formularioSiguiente = new AbmCliente.ModificarDatosCliente(DNICliente);
                this.cambiarVisibilidades(formularioSiguiente);
            }
            else {
                MessageBox.Show("Seleccione un cliente a modificar clickeando en la tabla: ","", MessageBoxButtons.OK);
            }
        }
    }
}
