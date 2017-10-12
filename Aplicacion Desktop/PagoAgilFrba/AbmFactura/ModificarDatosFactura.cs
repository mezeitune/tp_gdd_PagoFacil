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
        int subtotal;
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
             Form formularioSiguiente = new AbmFactura.ModificarItemFactura(nroFactura,descripcion);
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
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


        private void FechaAltaFactura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaVencFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaVencFact.Value = fechaDeAhora.Value;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.ModificacionFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void ModificarDatosFactura_Load(object sender, EventArgs e)
        {
           totalFactura.Enabled = false;
           
            completarTextos();
        }

        private void completarTextos()
        {
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
            var cmd2 = new SqlCommand(
                "select  * from [SERVOMOTOR].ITEMS  i where i.NUMERO_FACTURA='" + nroFactura + "';",
                 Program.conexion()
             );
            totalFacturaDecimal = Convert.ToDecimal(totalFactura.Text);
            totalFacturaInt = Convert.ToInt32(totalFacturaDecimal);
            var dataReader2 = cmd2.ExecuteReader();
            while (dataReader2.Read())
            {
                comboBoxItemsDeFactura.Items.Add(dataReader2["DESCRIPCION"].ToString());

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.agregarItemFacturaModificada(nroFactura);
            this.cambiarVisibilidades(formularioSiguiente);
        }



    }
}
