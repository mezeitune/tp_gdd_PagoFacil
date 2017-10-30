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


namespace PagoAgilFrba.Devolucion
{
    public partial class DevolucionFactura : Form
    {
        
        public DevolucionFactura()
        {
            InitializeComponent();
        }

        private void DevolucionFactura_Load(object sender, EventArgs e)
        {
            levantarFacturas();
            levantarMotivosDevolucion();
            registrarDevolucion.Enabled = false;

        }
        //LEVANTAMOS LAS FACTURAS PAGAS Y CON EMPRESA ACTIVA
        private void levantarFacturas()
        {
            var cmd = new SqlCommand(
                    "select NUMERO_FACTURA from [SERVOMOTOR].FACTURAS f JOIN [SERVOMOTOR].EMPRESAS e ON e.CUIT=f.CUIT_EMPRESA  where ESTADO='PAGA' AND e.ESTADO_ACTIVACION=1 ",
                     Program.conexion()
                 );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.comboFacturasADevolver.Items.Add(dataReader["NUMERO_FACTURA"]);
            }


        }

        private void levantarMotivosDevolucion()
        {

            var cmd = new SqlCommand(
                     "select * from [SERVOMOTOR].DEVOLUCIONES order by ID_DEVOLUCION ;",
                      Program.conexion()
                  );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                motivosDevolucion.Items.Add(dataReader["MOTIVO_DEVOLUCION"]);
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTextos();
        }
        private void limpiarTextos()
        {
         
            this.dataGridView1.Rows.Clear();

        }
        //AGREGAMOS AL DATA GRID LA FACTURA A DEVOLVER YA CARGADA PREVIAMENTE EN EL COMBO 
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboFacturasADevolver.SelectedItem == null)
            {
                MessageBox.Show("No hay mas facturas para devolver", "Error daros de entrada", MessageBoxButtons.OK);
                return;
            }
            var cmd = new SqlCommand(
                "SELECT * FROM [SERVOMOTOR].[FACTURAS] WHERE NUMERO_FACTURA= '" + comboFacturasADevolver.SelectedItem.ToString() + "';",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
            comboFacturasADevolver.Items.Remove(comboFacturasADevolver.SelectedItem);
            comboFacturasADevolver.SelectedItem = null;

            while (dataReader.Read())
            {

                this.dataGridView1.Rows.Add(
                    dataReader["NUMERO_FACTURA"],
                    dataReader["FECHA_VENCIMIENTO"],
                    dataReader["DNI_CLIENTE"],
                    dataReader["CUIT_EMPRESA"],
                    dataReader["TOTAL"],
                    dataReader["NUMERO_PAGO"]

                );

            }


        }
        //CAMBIAMOS EL ESTADO DE LAS FACTURAS Y REGISTRAMOS UNA NUEVA DEVOLUCION
        private void registrarDevolucion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    this.cambiarEstadoFactura(row.Cells[0].Value.ToString());
                    this.registarDevolucionFactura(row.Cells[0].Value.ToString());

                }
            }

            
            this.dataGridView1.Rows.Clear();
            this.limpiarTextos();
            MessageBox.Show("Se ha registrado la devolucion correctamente", "Todo bien", MessageBoxButtons.OK);
            Form formularioSiguiente = new MenuPrincipal();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();


        }


        private void cambiarEstadoFactura(String nroFactura){

            var cmd = new SqlCommand(
                            "update [SERVOMOTOR].[FACTURAS] set  ESTADO='NO PAGA' where NUMERO_FACTURA='" + nroFactura + "';",
                             Program.conexion()
                         );

            var dataReader = cmd.ExecuteReader(); 
    
         }

        private void registarDevolucionFactura(String nroFactura)
        {
            var cmd = new SqlCommand(
                                "EXEC [SERVOMOTOR].insertFacturasDevoluciones @NUMERO_FACTURA,@ID_DEVOLUCION",
               Program.conexion()
                  );
            cmd.Parameters.AddWithValue("@NUMERO_FACTURA", Convert.ToInt32(nroFactura));
            cmd.Parameters.AddWithValue("@ID_DEVOLUCION", (motivosDevolucion.SelectedIndex + 1));

            var dataReader = cmd.ExecuteReader(); 
        
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //EL BOTON "REGISTRAR DEVOLUCION" SE HABILITA CUANDO AL MENOS SE HAYA SELECCIONADO UNA EMPRESA A DEVOLVER
        private void motivosDevolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0] != null)
            {
                registrarDevolucion.Enabled = true;
            }
            
        }

    

    }
}
