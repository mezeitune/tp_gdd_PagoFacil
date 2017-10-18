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
namespace PagoAgilFrba.RegistroPago
{
    public partial class PantallaPrincipalRegistroPagoFacturas : Form
    {
        public PantallaPrincipalRegistroPagoFacturas()
        {
            InitializeComponent();
        }
        decimal importePago;
        int numPago;
        DateTimePicker fechaDeAhora = new DateTimePicker();
        private void comboFacturasAPagar_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
         }
        

        

        

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTextos();
        }
        private void limpiarTextos() {
            ImporteFact.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();

            comboFacturasAPagar.SelectedItem = null;
            comboSucursal.SelectedItem = null;
            medioPago.SelectedItem = null;
            this.dataGridView1.Rows.Clear();
        
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new MenuPrincipal();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void registrarUnPago_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {

                this.insertarPago();
                this.actualizarEstadoEmpresa();

                this.dataGridView1.Rows.Clear();
                this.limpiarTextos();
                MessageBox.Show("Se ha registrado el pago correctamente", "Todo bien", MessageBoxButtons.OK);
                Form formularioSiguiente = new MenuPrincipal();
                this.cambiarVisibilidades(formularioSiguiente);
            }
            else {
                MessageBox.Show("Algun Campo no es correcto o se encuentra vacio", "Error daros de entrada", MessageBoxButtons.OK);
            }
        }
        private void actualizarEstadoEmpresa() {
           
            var cmdPago = new SqlCommand(
                         "select * from [SERVOMOTOR].[PAGOS] where DNI_CLIENTE='" + comboClientes.SelectedItem.ToString() + "' AND FECHA_COBRO='" + fechaDeAhora.Value+ "';",
                          Program.conexion()
                      );

            var dataReaderPagos = cmdPago.ExecuteReader();
            while(dataReaderPagos.Read()){

                numPago = Convert.ToInt32( dataReaderPagos["NUMERO_PAGO"]);
            }

            this.recorrerListaFacturas();
           
        
        }
        private void recorrerListaFacturas() {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {

                    var cmd = new SqlCommand(
                            "update [SERVOMOTOR].[FACTURAS] set  ESTADO='PAGA',NUMERO_PAGO=" + numPago + " where NUMERO_FACTURA='" +row.Cells[0].Value.ToString() + "';",
                             Program.conexion()
                         );

                    var dataReader = cmd.ExecuteReader();

                    

                }
            }


            
        
        }
        private void insertarPago() {
            var cmd = new SqlCommand(
                     "insert into [SERVOMOTOR].[PAGOS] (FECHA_COBRO,IMPORTE,COD_POSTAL,ID_MEDPAGO,DNI_CLIENTE)   values ('" + fechaDeAhora.Value + "','" + ImporteFact.Text + "','" + comboSucursal.SelectedItem.ToString() + "'," + (medioPago.SelectedIndex+1) + ",'" + comboClientes.SelectedItem.ToString() + "')",
                      Program.conexion()
                  );

            var dataReader = cmd.ExecuteReader();
        
        
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

          
          
            huboErrores = Validacion.estaCheckeadoComboBox(comboSucursal) || huboErrores;
            huboErrores = Validacion.esVacio(ImporteFact, "importeFactura", true) || huboErrores;
            


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            
            
            return huboErrores;
        }

        private void PantallaPrincipalRegistroPagoFacturas_Load(object sender, EventArgs e)
        {
            this.levantarFacturas(); 
            this.levantarSucursales();
            this.levantarMediosDePago();
            this.levantarClientes();
            registrarUnPago.Enabled = false;
            ImporteFact.Enabled = false;
        }

        private void levantarClientes()
        {
            var cmd = new SqlCommand(
                    "select * from [SERVOMOTOR].CLIENTES where ESTADO_HABILITACION=1 ; ",
                     Program.conexion()
                 );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.comboClientes.Items.Add(dataReader["DNI"]);
            }


        }

        private void levantarFacturas()
        {
            var cmd = new SqlCommand(
                    "select NUMERO_FACTURA from [SERVOMOTOR].FACTURAS f JOIN [SERVOMOTOR].EMPRESAS e ON e.CUIT=f.CUIT_EMPRESA  where ESTADO='NO PAGA' AND e.ESTADO_ACTIVACION=1 AND f.FECHA_VENCIMIENTO>='" + fechaDeAhora.Value + "' ",
                     Program.conexion()
                 );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.comboFacturasAPagar.Items.Add(dataReader["NUMERO_FACTURA"]);
            }


        }
        private void levantarSucursales() {

            var cmd = new SqlCommand(
                     "select * from [SERVOMOTOR].SUCURSALES where ESTADO_HABILITACION=1;",
                      Program.conexion()
                  );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
               comboSucursal.Items.Add(dataReader["COD_POSTAL"]);
            }
        
        }
        private void levantarMediosDePago()
        {

            var cmd = new SqlCommand(
                     "select * from [SERVOMOTOR].MEDIOS_DE_PAGO order by ID_MEDPAGO ;",
                      Program.conexion()
                  );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                medioPago.Items.Add(dataReader["TIPO_MEDPAGO"]);
            }

        }

        private void agregarFactura(object sender, EventArgs e)
        {
           
            var cmd = new SqlCommand(
                "SELECT * FROM [SERVOMOTOR].[FACTURAS] WHERE NUMERO_FACTURA= '"+comboFacturasAPagar.SelectedItem.ToString()+"';",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
            comboFacturasAPagar.Items.Remove(comboFacturasAPagar.SelectedItem);
            comboFacturasAPagar.SelectedItem = null;

            while (dataReader.Read())
            {
                
                this.dataGridView1.Rows.Add(
                    dataReader["NUMERO_FACTURA"],
                    dataReader["FECHA_VENCIMIENTO"],
                    dataReader["DNI_CLIENTE"],
                    dataReader["CUIT_EMPRESA"],
                    dataReader["TOTAL"]
                   
                );
                importePago += Convert.ToDecimal(dataReader["TOTAL"]);
            }
            
            ImporteFact.Text = Convert.ToString(importePago);
            registrarUnPago.Enabled = true;
        }

    }
}
