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
    public partial class ModificarDatosFactura : Form
    {
        string nroFactura;
        string descripcion;
        int subtotal=0;
        decimal totalFacturaDecimal;
        int totalFacturaInt;
        public ModificarDatosFactura(string nroFact,int subtot)
       {
            subtotal = subtot;
            nroFactura = nroFact;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.ModificarItemFactura(nroFactura, descripcion);
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void txtTotalFactura_TextChanged(object sender, EventArgs e)
        {
            totalFactura.Visible = false;
        }

        private void comboBoxItemsDeFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcion = comboBoxItemsDeFactura.SelectedItem.ToString();


            MessageBox.Show("Se ha seleccionado el item: " + descripcion, "", MessageBoxButtons.OK);
        }

        private void ModificarUnaFactura_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && 
                !validarTipos())
            {
                var cmd = new SqlCommand(
                "update [SERVOMOTOR].[FACTURAS] set FECHA_VENCIMIENTO='" + FechaVencFact.Value + "',TOTAL=" + (totalFacturaInt+subtotal) + "where NUMERO_FACTURA='" + nroFactura + "';",
                 Program.conexion()
             );
                var dataReader = cmd.ExecuteReader();
                

                MessageBox.Show("Se ha dado modificado correctamente", "Todo bien", MessageBoxButtons.OK);

            }
            
        }

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;
            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaVencFact) || huboErrores;
            
            return huboErrores;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaVencFact.Value = fechaDeAhora.Value;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ModificarDatosFactura_Load(object sender, EventArgs e)
        {
           totalFactura.Enabled = false;
            completarTextos();
            updatearTotalFactura();//esto es para no levantar el total anterior de la base cuando se modifica un item mas de una vez
        }
        private void updatearTotalFactura() {
            var cmd = new SqlCommand(
                    "update [SERVOMOTOR].[FACTURAS] set TOTAL=" + (totalFacturaInt + subtotal) + "where NUMERO_FACTURA='" + nroFactura + "';",
                     Program.conexion()
                 );
            var dataReader = cmd.ExecuteReader();
        
        }

        private void completarTextos()
        {
            this.levantarFacturas();
            this.levantarItemsFactura();
            this.actualizarTotalFactura();
        }

        private void actualizarTotalFactura() {
            totalFacturaDecimal = Convert.ToDecimal(totalFactura.Text);
            totalFacturaInt = Convert.ToInt32(totalFacturaDecimal);
          
            totalFactura.Text = (totalFacturaInt + subtotal).ToString();
        
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.agregarItemFacturaModificada(nroFactura);
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void levantarFacturas() {
            var cmd = new SqlCommand(
                   "select * from [SERVOMOTOR].FACTURAS where NUMERO_FACTURA='" + nroFactura + "';",
                    Program.conexion()
                );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                FechaVencFact.Value = Convert.ToDateTime(dataReader["FECHA_VENCIMIENTO"]);
                totalFactura.Text = dataReader["TOTAL"].ToString();
            }
        }
        private void levantarItemsFactura() {
            var cmd2 = new SqlCommand(
                   "select  * from [SERVOMOTOR].ITEMS  i where i.NUMERO_FACTURA='" + nroFactura + "';",
                    Program.conexion()
                );


            var dataReader2 = cmd2.ExecuteReader();
            while (dataReader2.Read())
            {
                comboBoxItemsDeFactura.Items.Add(dataReader2["DESCRIPCION"].ToString());

            }
        
        
        }


    }
}
