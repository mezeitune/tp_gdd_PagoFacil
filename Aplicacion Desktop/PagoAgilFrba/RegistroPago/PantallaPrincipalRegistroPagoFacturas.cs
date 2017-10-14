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

        

        private void comboFacturasAPagar_SelectedIndexChanged(object sender, EventArgs e)
        {
          

                var cmd = new SqlCommand(
                "select * from [SERVOMOTOR].[FACTURAS]  where NUMERO_FACTURA='" + comboFacturasAPagar.SelectedItem.ToString() + "';",
                 Program.conexion()
             );

                var dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    FechaVencFact.Value= Convert.ToDateTime(dataReader["FECHA_VENCIMIENTO"]);
                    ImporteFact.Text = dataReader["TOTAL"].ToString();
                }
         }
        

        

        

        private void limpiar_Click(object sender, EventArgs e)
        {
            ImporteFact.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaVencFact.Value = fechaDeAhora.Value;
            comboCliente.Items.Clear();
            comboEmpresas.Items.Clear();
            comboFacturasAPagar.Items.Clear();
            comboSucursal.Items.Clear();
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
            if (todosLosCamposLLenos() && validarTipos())
            {

                var cmd = new SqlCommand(
                     "insert into [SERVOMOTOR].[PAGOS] values ('"+FechaCobro.Value+"','"+FechaVencFact.Value+"','"+ImporteFact.Text+"','"+comboSucursal.SelectedItem.ToString()+"',"+medioPago.SelectedIndex+",'"+comboCliente.SelectedItem.ToString()+"')",
                      Program.conexion()
                  );

                var dataReader = cmd.ExecuteReader();



                MessageBox.Show("Se ha dado de alta el pago correctamente", "Todo bien", MessageBoxButtons.OK);

            }
            else {
                MessageBox.Show("Algun Campo no es correcto o se encuentra vacio", "Error daros de entrada", MessageBoxButtons.OK);
            }
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.estaCheckeadoComboBox(comboCliente) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresas) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboFacturasAPagar) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboSucursal) || huboErrores;
            huboErrores = Validacion.esVacio(ImporteFact, "importeFactura", true) || huboErrores;
            


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esNumero(ImporteFact, "numero factura", true) || huboErrores;
           

            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaVencFact) || huboErrores;
           
            return huboErrores;
        }

        private void PantallaPrincipalRegistroPagoFacturas_Load(object sender, EventArgs e)
        {
            this.levantarFacturas();
            this.levantarEmpresas();
            this.levantarClientes();
            this.levantarSucursales();
            this.levantarMediosDePago();
            FechaCobro.Enabled = false;
            FechaVencFact.Enabled = false;
            ImporteFact.Enabled = false;
        }

        private void levantarFacturas()
        {
            var cmd = new SqlCommand(
                    "select NUMERO_FACTURA from [SERVOMOTOR].FACTURAS where ESTADO='NO PAGA' ",
                     Program.conexion()
                 );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.comboFacturasAPagar.Items.Add(dataReader["NUMERO_FACTURA"]);
            }


        }

        private void levantarClientes() {
            var cmdCliente = new SqlCommand(
                   "select DNI from [SERVOMOTOR].[CLIENTES] where ESTADO_HABILITACION=1;",
                    Program.conexion()
                    );
            var dataReader = cmdCliente.ExecuteReader();

            while (dataReader.Read())
            {
                comboCliente.Items.Add(dataReader["DNI"]);

            }
        }

        private void levantarEmpresas() {

            var cmdEmpresa = new SqlCommand(
             "select * from [SERVOMOTOR].[EMPRESAS] where ESTADO_ACTIVACION=1;",
              Program.conexion()
              );
            var dataReaderEmpresa = cmdEmpresa.ExecuteReader();

            while (dataReaderEmpresa.Read())
            {
                comboEmpresas.Items.Add(dataReaderEmpresa["CUIT"]);
                
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
               comboSucursal.Items.Add(dataReader["DIRECCION"]);

             
            }
        
        }
        private void levantarMediosDePago()
        {

            var cmd = new SqlCommand(
                     "select * from [SERVOMOTOR].MEDIOS_DE_PAGO ;",
                      Program.conexion()
                  );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                medioPago.Items.Add(dataReader["TIPO_MEDPAGO"]);


            }

        }

    }
}
