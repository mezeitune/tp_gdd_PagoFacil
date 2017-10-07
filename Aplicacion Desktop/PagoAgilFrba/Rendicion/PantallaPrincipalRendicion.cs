using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Rendicion
{
    public partial class PantallaPrincipalRendicion : Form
    {
        public PantallaPrincipalRendicion()
        {
            InitializeComponent();
        }

        private void PantallaPrincipalRendicion_Load(object sender, EventArgs e)
        {
            CantidadFacturasRendidas.Enabled = false;
            comisionTotal.Enabled = false;
            importeTotalTodasLasRendiciones.Enabled = false;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aca hay que mostrar las facturas que se fueron agregando (creo q hay que hacer una lista en la otra pantalla y pasarsela por parametro aca pero ni idea)
        }

        private void irAPaginaAgregarFacturaARendir_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Rendicion.AgregarEmpresaARendir();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new MenuPrincipal();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            porcentajeComision.Clear();
            comboEmpresas.Items.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaRendicion.Value = fechaDeAhora.Value;
           
        }

        private void registrarRendicion_Click(object sender, EventArgs e)
        {
            if (todosLosCamposLLenos() && validarTipos())
            {

                //aca se da de alta la factura en la BDD

                MessageBox.Show("Se ha rendido las facturas correctamente", "Todo bien", MessageBoxButtons.OK);

            }
            else {
                MessageBox.Show("Algun campo esta vacio o ha ingresado un dato de forma incorrecta", "Error en los datos de entrada", MessageBoxButtons.OK);
            }

        }

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

          
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresas) || huboErrores;
            huboErrores = Validacion.esVacio(porcentajeComision, "Porcentaje comision", true) || huboErrores;


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esNumero(porcentajeComision, "Porcentaje comision", true) || huboErrores;
            

            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaRendicion) || huboErrores;
            
            return huboErrores;
        }

        private void CantidadFacturasRendidas_TextChanged(object sender, EventArgs e)
        {
            //hacer un count de la lista de facturas que selecciono para rendir
        }

        private void comisionTotal_TextChanged(object sender, EventArgs e)
        {
            //del importe a cobrar poner el dinero correspondiente a la comision
        }

        private void importeTotalTodasLasRendiciones_TextChanged(object sender, EventArgs e)
        {
            //sumar el importe la comision con el total a cobrar
        }

    }
}
