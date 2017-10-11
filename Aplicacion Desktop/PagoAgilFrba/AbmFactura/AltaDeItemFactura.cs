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

    
    public partial class AltaDeItemFactura : Form
    {
       
        public AltaDeItemFactura()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadDeItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardarUnItem_Click(object sender, EventArgs e)
        {

            if (!todosLosCamposLLenos() && !validarTipos())
            {

                dataGridView1.Rows.Add(txtDescripcion.Text,txtMontoItem.Text,txtCantidadDeItems.Text);
               // repoItems.addToListaItems(txtCantidadDeItems.Text, txtMontoItem.Text, txtDescripcion.Text);
                MessageBox.Show("Se ha guardado un item correctamente en la factura", "Todo bien", MessageBoxButtons.OK);
                txtDescripcion.Text = "";
                txtCantidadDeItems.Text = "";
                txtMontoItem.Text = "";
                generarFactura.Enabled = true;
            }
            else
            {
                MessageBox.Show("Algun campo esta vacio o el formato es incorrecto.", "", MessageBoxButtons.OK);
            }
           
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
            txtDescripcion.Text = "";
            txtCantidadDeItems.Text = "";
            txtMontoItem.Text = "";
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void AltaDeItemFactura_Load(object sender, EventArgs e)
        {
            generarFactura.Enabled = false;
        }




        private void generarFactura_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.AltaFactura(dataGridView1);
            this.cambiarVisibilidades(formularioSiguiente);
            dataGridView1.ClearSelection();
        }

        
    }
}
