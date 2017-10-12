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
    public partial class agregarItemFacturaModificada : Form
    {
        String nroFactura;
        int subtotal=0;
        public agregarItemFacturaModificada(string nrofact)
        {
            nroFactura = nrofact;
            InitializeComponent();
        }

        private void agregarItemFacturaModificada_Load(object sender, EventArgs e)
        {
            agregarItems.Enabled = false;
        }

        private void botonGuardarUnItem_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {

                dataGridView1.Rows.Add(txtDescripcion.Text, txtMontoItem.Text, txtCantidadDeItems.Text);

                MessageBox.Show("Se ha guardado un item correctamente en la factura", "Todo bien", MessageBoxButtons.OK);
                txtDescripcion.Text = "";
                txtCantidadDeItems.Text = "";
                txtMontoItem.Text = "";
                agregarItems.Enabled = true;
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

        private void agregarItems_Click(object sender, EventArgs e)
        {

            this.recorrerListaItems();
            Form formularioSiguiente = new AbmFactura.ModificarDatosFactura(nroFactura,subtotal);
            this.cambiarVisibilidades(formularioSiguiente);
            dataGridView1.ClearSelection();
        }

        private void recorrerListaItems()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    String descripcion = row.Cells[0].Value.ToString();
                    String monto = row.Cells[1].Value.ToString();
                    String cantidad = row.Cells[2].Value.ToString();
                    this.insertarItem(monto, descripcion, cantidad);
                    int subTotalItem = (Int32.Parse(monto)*Int32.Parse(cantidad));
                    subtotal += subTotalItem;
                }
            }

        }
        private void insertarItem(String m, String d, String c)
        {


            var cmd = new SqlCommand(
              "insert into [SERVOMOTOR].[ITEMS] (DESCRIPCION,MONTO,CANTIDAD,NUMERO_FACTURA) values ('" + d + "','" + m + "','" + c +
              "','" + nroFactura + "');",
               Program.conexion()
           );
            var dataReaderFactura = cmd.ExecuteReader();

        }


        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }
    }
}
