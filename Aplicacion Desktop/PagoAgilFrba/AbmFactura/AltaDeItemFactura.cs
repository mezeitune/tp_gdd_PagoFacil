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
        int indexItem;

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
            Form formularioSiguiente = new MenuPrincipal();
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void AltaDeItemFactura_Load(object sender, EventArgs e)
        {
            generarFactura.Enabled = false;
            eliminarUnItem.Enabled = false;
        }

        private void generarFactura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) {
                MessageBox.Show("Debe registrar al menos un item ", "error", MessageBoxButtons.OK);
                return;
            }
            Form formularioSiguiente = new AbmFactura.AltaFactura(dataGridView1); 
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void eliminarUnItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void seleccionarItem(object sender, DataGridViewCellEventArgs e)
        {
            indexItem= dataGridView1.CurrentRow.Index;

            MessageBox.Show("Se ha seleccionado un item a eliminar: ", "", MessageBoxButtons.OK);
            eliminarUnItem.Enabled = true;
        }

    }
}
