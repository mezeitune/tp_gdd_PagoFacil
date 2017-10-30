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
namespace PagoAgilFrba.AbmFactura
{
    //PRIMERO CARGAMOS LOS ITEMS Y LOS PASAMOS POR CONSTRUCTOR A "ALTA FACTURA" YA QUE ESOS ITEMS 
    //NO SE PUEDEN VINCULAR A UNA FACTURA QUE TODAVIA NO FUE DADA DE ALTA
    public partial class AltaFactura : Form
    {
        int totalFactura;
        DataGridView dataGridItems;
        public AltaFactura(DataGridView dataGridItem)
        {
            dataGridItems = dataGridItem;
            InitializeComponent();
        }


        private void AltaFactura_Load(object sender, EventArgs e)
        {
            this.levantarClientes();
            this.levantarEmpresas();
            this.calcularTotalFactura();

            txtTotalFactura.Enabled = false;
            txtTotalFactura.Text = totalFactura.ToString();
        }
        //CALCULAMOS EL TOTAL DE LA FACTURA A DAR DE ALTA
        private void calcularTotalFactura() {

            foreach (DataGridViewRow row in dataGridItems.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                   
                    String monto = row.Cells[1].Value.ToString();
                    String cantidad = row.Cells[2].Value.ToString();

                    int cantidadTotal = Int32.Parse(cantidad);
                    int montoTotal = Int32.Parse(monto);
                    totalFactura += (montoTotal * cantidadTotal);
                    
                }
            }
        
        }

        private void DarAltaFactura_Click(object sender, EventArgs e)
        {
           
            if (!todosLosCamposLLenos() && !validarTipos())
            {
                try
                {
                var cmd = new SqlCommand(
                    "EXEC [SERVOMOTOR].insertFacturas @NUMERO_FACTURA,@FECHA_ALTA,@FECHA_VENCIMIENTO,@DNI_CLIENTE,@CUIT_EMPRESA,@TOTAL,@ESTADO",
               Program.conexion()
                  );
                cmd.Parameters.AddWithValue("@NUMERO_FACTURA", txtNroFactura.Text);
                cmd.Parameters.AddWithValue("@FECHA_ALTA",  FechaAltaFac.Value);
                cmd.Parameters.AddWithValue("@FECHA_VENCIMIENTO", FechaVencFact.Value);
                cmd.Parameters.AddWithValue("@DNI_CLIENTE", comboCliente.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@CUIT_EMPRESA", comboEmpresa.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TOTAL", totalFactura);
                cmd.Parameters.AddWithValue("@ESTADO", "no paga");
                var dataReaderFactura = cmd.ExecuteReader();
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    MessageBox.Show("El campo numero de factura esta duplicado, vuelva a ingresar otro", "", MessageBoxButtons.OK);
                    return;
                }
                this.recorrerListaItems();
                
               MessageBox.Show("Se ha dado de alta correctamente la factura", "Correcto", MessageBoxButtons.OK);
                this.limpiarTextos();
                dataGridItems.ClearSelection();

                Form formularioSiguiente = new MenuPrincipal();
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
                formularioSiguiente.ShowDialog();
                this.Show();
            }
            else
            {
               
               
            }
        }
        private void recorrerListaItems() {

            foreach(DataGridViewRow row in dataGridItems.Rows){
                if (row.Cells[0].Value != null)
                {
                    String descripcion = row.Cells[0].Value.ToString();
                    String monto = row.Cells[1].Value.ToString();
                    String cantidad = row.Cells[2].Value.ToString();
                    this.insertarItem(monto, descripcion, cantidad);
                }
            }

        }
        //RECORREMOS CADA ITEMS Y LO VAMOS INGRESANDO A PARTIR DE LA FACTURA YA DEDA DE ALTA
        private void insertarItem(String m,String d, String c) {
            var cmd = new SqlCommand(
              "EXEC [SERVOMOTOR].insertOUpdateEnItems @TIPOOPERACION,@DESCRIPCION,@MONTO,@CANTIDAD,@NUMERO_FACTURA",
               Program.conexion()
                  );
            cmd.Parameters.AddWithValue("@TIPOOPERACION", 1);
            cmd.Parameters.AddWithValue("@DESCRIPCION", d);
            cmd.Parameters.AddWithValue("@MONTO", m);
            cmd.Parameters.AddWithValue("@CANTIDAD", c);
            cmd.Parameters.AddWithValue("@NUMERO_FACTURA", Convert.ToInt32(txtNroFactura.Text));
           
              
            var dataReaderFactura = cmd.ExecuteReader();

        }

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.estaCheckeadoComboBox(comboCliente) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresa)|| huboErrores;
            huboErrores = Validacion.esVacio(txtNroFactura, "Numero factura", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtTotalFactura, "Total", true) || huboErrores;
           

            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esNumero(txtNroFactura, "numero factura", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtTotalFactura,"total factura", true) || huboErrores;
            huboErrores = !Validacion.esNumeroMayorA0(txtTotalFactura, "total factura", true) || huboErrores;
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaVencFact)|| huboErrores;
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaAltaFac) || huboErrores;
            return huboErrores;
        }
        

        private void botonIngresarItem_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.AltaDeItemFactura();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }


        //BATCHS PARA LEVANTAR DATOS
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
          "select CUIT from [SERVOMOTOR].[EMPRESAS] where ESTADO_ACTIVACION=1;",
           Program.conexion()
           );
            var dataReaderEmpresa = cmdEmpresa.ExecuteReader();

            while (dataReaderEmpresa.Read())
            {
                comboEmpresa.Items.Add(dataReaderEmpresa["CUIT"]);

            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTextos();
        }
        private void limpiarTextos() {
            txtNroFactura.Text = "";
            txtTotalFactura.Text = "";
            comboCliente.Items.Clear();
            comboEmpresa.Items.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaAltaFac.Value = fechaDeAhora.Value;
            FechaVencFact.Value = fechaDeAhora.Value;
        }
        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
       
 }

