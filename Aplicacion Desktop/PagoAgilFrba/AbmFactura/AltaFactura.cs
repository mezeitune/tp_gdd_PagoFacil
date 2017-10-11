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
            var cmdCliente = new SqlCommand(
               "select DNI from [SERVOMOTOR].[CLIENTES] where ESTADO_HABILITACION=1;",
                Program.conexion()
                );
            var dataReader = cmdCliente.ExecuteReader();

            while (dataReader.Read())
            {
                comboCliente.Items.Add(dataReader["DNI"]);

            }


            var cmdEmpresa = new SqlCommand(
          "select CUIT from [SERVOMOTOR].[EMPRESAS] where ESTADO_ACTIVACION=1;",
           Program.conexion()
           );
            var dataReaderEmpresa = cmdEmpresa.ExecuteReader();

            while (dataReaderEmpresa.Read())
            {
                comboEmpresa.Items.Add(dataReaderEmpresa["CUIT"]);

            }
            txtTotalFactura.Enabled = false;
            

            this.calcularTotalFactura();
            txtTotalFactura.Text = totalFactura.ToString();
        }

        private void calcularTotalFactura() {

            foreach (DataGridViewRow row in dataGridItems.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                   
                    String monto = row.Cells[1].Value.ToString();
                    String cantidad = row.Cells[2].Value.ToString();

                    int cantidadTotal = Int32.Parse(cantidad);
                    int montoTotal = Int32.Parse(monto);
                    totalFactura += montoTotal * cantidadTotal;
                    
                }
            }
        
        }

        private void DarAltaFactura_Click(object sender, EventArgs e)
        {
           
            if (!todosLosCamposLLenos() && !validarTipos())
            {
             
                var cmd = new SqlCommand(
               "insert into [SERVOMOTOR].[FACTURAS] values ('" + txtNroFactura.Text + "','" + FechaAltaFac.Value + "','" + FechaVencFact.Value + "','" + comboCliente.SelectedItem.ToString() +
               "','" + comboEmpresa.SelectedItem.ToString()+ "','" + totalFactura + "','NO PAGA',NULL,NULL,NULL);",
                Program.conexion()   
                  );
                var dataReaderFactura = cmd.ExecuteReader();

                this.recorrerListaItems();
                
               MessageBox.Show("Se ha dado de alta correctamente la factura", "Correcto", MessageBoxButtons.OK);
                this.limpiarTextos();
                dataGridItems.ClearSelection();
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

        private void insertarItem(String m,String d, String c) {
            

            var cmd = new SqlCommand(
              "insert into [SERVOMOTOR].[ITEMS] (DESCRIPCION,MONTO,CANTIDAD,NUMERO_FACTURA) values ('" + d + "','" + m + "','" + m + "','" + c +
              "','" + txtNroFactura.Text + "');",
               Program.conexion()
           );
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
            
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaVencFact) || huboErrores;
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaAltaFac) || huboErrores;
            return huboErrores;
        }
        

        private void botonIngresarItem_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.AltaDeItemFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

       

        private void txtTotalFactura_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
                    }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void FechaAltaFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaVencFact_ValueChanged(object sender, EventArgs e)
        {

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

        Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
          this.cambiarVisibilidades(formularioSiguiente);
        }
       
    

    }
       
    }

