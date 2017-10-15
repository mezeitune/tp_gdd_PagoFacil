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

namespace PagoAgilFrba.Rendicion
{
    public partial class PantallaPrincipalRendicion : Form
    {
        decimal importeTotalARendir=0,importeComisionARendir=0;
        public PantallaPrincipalRendicion()
        {
            InitializeComponent();
        }

        private void PantallaPrincipalRendicion_Load(object sender, EventArgs e)
        {
            CantidadFacturasRendidas.Enabled = false;
           
            importeTotalRendicion.Enabled = false;
            this.levantarEmpresas();
        }

        private void levantarEmpresas() {
            var cmdEmpresa = new SqlCommand(
         "select CUIT from [SERVOMOTOR].[EMPRESAS] where ESTADO_ACTIVACION=1;",
          Program.conexion()
          );
            var dataReaderEmpresa = cmdEmpresa.ExecuteReader();

            while (dataReaderEmpresa.Read())
            {
                comboEmpresa.Items.Add(dataReaderEmpresa["CUIT"]);

            }
        
        
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
            comboEmpresa.Items.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaRendicion.Value = fechaDeAhora.Value;
           
        }

        private void registrarRendicion_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {
               decimal totalComision = Convert.ToDecimal(Convert.ToDecimal(porcentajeComision.Text) * Convert.ToDecimal(importeTotalRendicion.Text) / 100);

                var cmd = new SqlCommand(
               "INSERT INTO [SERVOMOTOR].[RENDICIONES] (FECHA_COBRO,PORCENTAJE_COMISION,CANTIDAD_FACTURAS_RENDIDAS,PRECIO_COMISION,TOTAL_RENDIDO,CUIT_EMPRESA) VALUES ( '" + FechaRendicion.Value + "'," + Convert.ToInt32(porcentajeComision.Text) + "," + Convert.ToInt32(CantidadFacturasRendidas.Text) + "," + totalComision + "," + Convert.ToDecimal(importeTotalRendicion.Text) + ",'"+comboEmpresa.SelectedItem.ToString()+"');",
               Program.conexion()
           );

                var dataReader = cmd.ExecuteReader();
                

                MessageBox.Show("Se ha rendido las facturas correctamente", "Todo bien", MessageBoxButtons.OK);

            }
            else {
                MessageBox.Show("Algun campo esta vacio o ha ingresado un dato de forma incorrecta", "Error en los datos de entrada", MessageBoxButtons.OK);
            }

        }

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

          
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresa) || huboErrores;
            huboErrores = Validacion.esVacio(porcentajeComision, "Porcentaje comision", true) || huboErrores;


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esNumero(porcentajeComision, "Porcentaje comision", true) || huboErrores;
            huboErrores = !Validacion.estaEntreLimites(porcentajeComision,0,100,false,porcentajeComision.Text);

            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaRendicion) || huboErrores;
            
            return huboErrores;
        }

        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                "SELECT * FROM [SERVOMOTOR].[FACTURAS] WHERE CUIT_EMPRESA= '" +comboEmpresa.SelectedItem.ToString() + "' AND ESTADO='PAGA';",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
           

            while (dataReader.Read())
            {

                this.dataGridView1.Rows.Add(
                    dataReader["NUMERO_FACTURA"],
                    dataReader["TOTAL"]

                );
                importeTotalARendir+= Convert.ToDecimal(dataReader["TOTAL"]);
            }
            CantidadFacturasRendidas.Text = (dataGridView1.Rows.Count-1).ToString();
            importeTotalRendicion.Text = importeTotalARendir.ToString();
        }

        private void porcentajeComision_TextChanged(object sender, EventArgs e)
        {
            

       }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       

       

    }
}
