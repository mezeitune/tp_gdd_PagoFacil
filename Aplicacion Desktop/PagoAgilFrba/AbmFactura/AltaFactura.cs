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
    public partial class AltaFactura : Form
    {
        public AltaFactura()
        {
            InitializeComponent();
        }

        private void AltaFactura_Load(object sender, EventArgs e)
        {
           
        }

        private void DarAltaFactura_Click(object sender, EventArgs e)
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
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresa)|| huboErrores;
            huboErrores = Validacion.esVacio(txtNroFactura, "calle", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtTotalFactura, "departamento", true) || huboErrores;
           

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
            int totalFactura;
                    //hay que controlar que ese total se vaya cambiando a medida que se agregan items y que el usuario no lo cambie

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
                    }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar los clientes dados de alta por el apellido y nombre
        }

        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar las empresas dadas de altas por el nombre
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

       
       
    }
}
