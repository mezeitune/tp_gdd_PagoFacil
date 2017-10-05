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
    public partial class ModificarDatosFactura : Form
    {
        public ModificarDatosFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form formularioSiguiente = new AbmFactura.ModificarItemFactura();
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
           
        }

        private void comboBoxItemsDeFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificarUnaFactura_Click(object sender, EventArgs e)
        {
            if (todosLosCamposLLenos() && validarTipos())
            {

                ///aca va el update de todos los campos

                MessageBox.Show("Se ha dado modificado correctamente", "Todo bien", MessageBoxButtons.OK);

            }
            
        }

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.estaCheckeadoComboBox(comboCliente) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresa) || huboErrores;
            huboErrores = Validacion.esVacio(txtNroFactura, "calle", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtTotalFactura, "departamento", true) || huboErrores;


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esNumero(txtNroFactura, "numero factura", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtTotalFactura, "total factura", true) || huboErrores;

            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaVencFact) || huboErrores;
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaAltaFac) || huboErrores;
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
            txtNroFactura.Text = "";
            txtTotalFactura.Text = "";
            comboCliente.Items.Clear();
            comboEmpresa.Items.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaAltaFac.Value = fechaDeAhora.Value;
            FechaVencFact.Value = fechaDeAhora.Value;
        }
        
    }
}
