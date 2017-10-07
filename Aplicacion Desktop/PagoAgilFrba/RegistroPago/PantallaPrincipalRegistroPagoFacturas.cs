using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.RegistroPago
{
    public partial class PantallaPrincipalRegistroPagoFacturas : Form
    {
        public PantallaPrincipalRegistroPagoFacturas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboFacturasAPagar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //facturas que se encuentren no pagas
        }

        private void FechaCobro_ValueChanged(object sender, EventArgs e)
        {
            FechaCobro.Enabled = false;
        }

        private void comboEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tienen que ser clientes habilitados
        }

        private void FechaVencFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ImporteFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sucursales habliitadas o la que ingreso el cobrador???
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

                //aca se da de alta la factura en la BDD

                MessageBox.Show("Se ha dado de alta correctamente", "Todo bien", MessageBoxButtons.OK);

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



    }
}
