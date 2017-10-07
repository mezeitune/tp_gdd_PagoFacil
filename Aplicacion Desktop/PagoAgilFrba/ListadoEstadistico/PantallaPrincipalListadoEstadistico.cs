using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class PantallaPrincipalListadoEstadistico : Form
    {
        public PantallaPrincipalListadoEstadistico()
        {
            InitializeComponent();
        }
        private void PantallaPrincipalListadoEstadistico_Load(object sender, EventArgs e) {
            this.inicio();
        }

        private void inicio()
        {
        }
        private void tiposDeListados_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultaTOP5_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposCorrectos())
            {
               //SQLManager.ejecutarQuery("select * from " + this.estadisticaSeleccionada() + "(" + this.trimestreSeleccionado() + ", '" + anioDeConsulta.Text + "')", dg);
                      

            }
            else
            {
                MessageBox.Show("Algun Campo no es correcto o se encuentra vacio", "Error daros de entrada", MessageBoxButtons.OK);
            }
        }


        //este metodo le manda a la consulta el tipo 
        private string estadisticaSeleccionada()
        {
            //respetar el nombre de los procedures plis
            if (tiposDeListados.SelectedIndex == 0)
            {
                return "[SERVOMOTOR].porcentajeFacturasCobradasPorEmpresa";
            }
            if (tiposDeListados.SelectedIndex == 1)
            {
                return "[SERVOMOTOR].empresasConMayorMontoRecibido";
            }
            if (tiposDeListados.SelectedIndex == 2)
            {
                return "[SERVOMOTOR].clientesConMasPagos";
            }
            
            else
            return "[SERVOMOTOR].clientesMasCumplidores";
        }
        //este selecciona el trimestre
        private string trimestreSeleccionado()
        {
            if (comboTrimestre.SelectedIndex == 0)
                return "1";
            else if (comboTrimestre.SelectedIndex == 1)
                return "2";
            else
                return "3";
        }
        private bool todosLosCamposCorrectos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.estaCheckeadoComboBox(tiposDeListados) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboTrimestre) || huboErrores;
            huboErrores = !Validacion.esNumero(anioDeConsulta) || huboErrores;
            huboErrores = !Validacion.estaEntreLimites(anioDeConsulta, 1990, 2050, false, "Año") || huboErrores;
            return huboErrores;
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
       
    }
}
