using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{

    //PRIMERO CARGAMOS LOS ITEMS Y LOS PASAMOS POR CONSTRUCTOR A "ALTA FACTURA" YA QUE ESOS ITEMS 
    //NO SE PUEDEN VINCULAR A UNA FACTURA QUE TODAVIA NO FUE DADA DE ALTA
    
    public partial class AltaDeItemFactura : Form
    {
       
        public AltaDeItemFactura()
        {
            InitializeComponent();
        }


        private void botonGuardarUnItem_Click(object sender, EventArgs e)
        {

            if (!todosLosCamposLLenos() && !validarTipos())
            {

                dataGridView1.Rows.Add(txtDescripcion.Text,txtMontoItem.Text,txtCantidadDeItems.Text);
               
                MessageBox.Show("Se ha guardado un item correctamente en la factura", "Todo bien", MessageBoxButtons.OK);

                this.limpiarTextos();
            }
            else
            {
                MessageBox.Show("Algun campo esta vacio o el formato es incorrecto.", "", MessageBoxButtons.OK);
            }
           
        }
        private void limpiarTextos(){
         txtDescripcion.Text = "";
         txtCantidadDeItems.Text = "";
         txtMontoItem.Text = "";
         generarFactura.Enabled = true;
        }

        

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtCantidadDeItems, "cantidad", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtMontoItem, "monto", true) || huboErrores;
           

            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            
            huboErrores = !Validacion.esNumero(txtMontoItem, "monto", true) || huboErrores;

            huboErrores = !Validacion.esNumero(txtCantidadDeItems, "cantidad", true) || huboErrores;
          

            return huboErrores;
        }


        private void limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTextos();
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AltaDeItemFactura_Load(object sender, EventArgs e)
        {
            generarFactura.Enabled = false;
        }

        private void generarFactura_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.AltaFactura(dataGridView1);
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
            dataGridView1.ClearSelection();
        }

    }
}
