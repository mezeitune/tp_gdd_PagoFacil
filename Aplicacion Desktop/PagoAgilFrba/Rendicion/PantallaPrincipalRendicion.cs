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
        decimal importeTotalARendir=0,totalComision=0;
        int idRendicion;
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
        
        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                this.darDeAltaRendicion();
                this.buscarRendicion();
                this.cambiarEstadoFacturas();
              

                MessageBox.Show("Se ha rendido las facturas correctamente", "Todo bien", MessageBoxButtons.OK);
                Form formularioSiguiente = new MenuPrincipal();
                this.Hide();
                formularioSiguiente.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("Algun campo esta vacio o ha ingresado un dato de forma incorrecta", "Error en los datos de entrada", MessageBoxButtons.OK);
            }

        }


        //SE DA DE ALTA LA RENDICION CALCULANDO EL TOTAL A RENDIR Y EL TOTAL DE COMISION A NUESTRA ORGANIZACION
        private void darDeAltaRendicion() {

            totalComision = Convert.ToDecimal(Convert.ToDecimal(porcentajeComision.Text) * Convert.ToDecimal(importeTotalRendicion.Text) / 100);

            var cmd = new SqlCommand(
           "EXEC [SERVOMOTOR].insertRendiciones @FECHA_COBRO,@PORCENTAJE_COMISION,@CANTIDAD_FACTURAS_RENDIDAS,@PRECIO_COMISION,@TOTAL_RENDIDO,@CUIT_EMPRESA;",
           Program.conexion()
       );
            cmd.Parameters.AddWithValue("@FECHA_COBRO", FechaRendicion.Value);
            cmd.Parameters.AddWithValue("@PORCENTAJE_COMISION", Convert.ToInt32(porcentajeComision.Text));
            cmd.Parameters.AddWithValue("@CANTIDAD_FACTURAS_RENDIDAS", Convert.ToInt32(CantidadFacturasRendidas.Text));
            cmd.Parameters.AddWithValue("@PRECIO_COMISION", totalComision);
            cmd.Parameters.AddWithValue("@TOTAL_RENDIDO", Convert.ToDecimal(importeTotalRendicion.Text));
            cmd.Parameters.AddWithValue("@CUIT_EMPRESA", comboEmpresa.SelectedItem.ToString());

            var dataReader = cmd.ExecuteReader();
                
        
        }
        //CAMBIAMOS EL ESTADO DE LAS FACTURAS A "REMDIDA" Y LAS LIGAMOS A UNA RENDICION EN PARTICULAR (LA QUE RECIEN DIMOS DE ALTA)
        private void cambiarEstadoFacturas() {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {

                    var cmd = new SqlCommand(
                            "update [SERVOMOTOR].[FACTURAS] set  ESTADO='RENDIDA',ID_RENDICION="+ idRendicion +" where NUMERO_FACTURA=" + Convert.ToDecimal(row.Cells[0].Value) + ";",
                             Program.conexion()
                         );

                    var dataReader = cmd.ExecuteReader();

                }
            }
        
        }
        //BUSCO EL ID DE LA RENDICION QUE RECIEN INGRESE PARA PODER LIGAR LAS FACTURAS A DICHA OPERACION
        private void buscarRendicion(){
        var cmd = new SqlCommand(
                            "select TOP 1 * from SERVOMOTOR.RENDICIONES ORDER BY ID_RENDICION DESC;",
                             Program.conexion()
                         );

                    var dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        idRendicion = Convert.ToInt32(dataReader["ID_RENDICION"]);
                    
               }
                    
        }

        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;
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
            // ACA VERIFICAMOS QUE LA EMPRESA ELEGIDA NO HAYA SIDO YA RENDIDA EN UN DIA DENTRO DEL MES Y ANIO ELEGIDO
            if (!empresaRendida())
            {
                var cmd = new SqlCommand(
                    "SELECT * FROM [SERVOMOTOR].[FACTURAS] f JOIN SERVOMOTOR.PAGOS p ON f.NUMERO_PAGO=p.NUMERO_PAGO WHERE CUIT_EMPRESA= '" + comboEmpresa.SelectedItem.ToString() + "' AND ESTADO LIKE 'PAGA' AND p.FECHA_COBRO BETWEEN ('1/" + FechaRendicion.Value.Month + "/" + FechaRendicion.Value.Year + "') AND ('" + DateTime.DaysInMonth(FechaRendicion.Value.Year, FechaRendicion.Value.Month) + "/" + FechaRendicion.Value.Month + "/" + FechaRendicion.Value.Year + "');",
                    Program.conexion()
                );

                var dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    this.dataGridView1.Rows.Add(
                        dataReader["NUMERO_FACTURA"],
                        dataReader["TOTAL"]

                    );
                    //CALCULAMOS EL IMPORTE TOTAL A RENDIR
                    importeTotalARendir += Convert.ToDecimal(dataReader["TOTAL"]);



                }
                //CALCULAMOS LA CANTIDAD DE FACTURAS A RENDIR
                CantidadFacturasRendidas.Text = (dataGridView1.Rows.Count).ToString();
                importeTotalRendicion.Text = importeTotalARendir.ToString();
            }
            else {
                MessageBox.Show("Empresa ya rendida en este mes", "", MessageBoxButtons.OK);
            }
            
        }
        // ACA VERIFICAMOS QUE LA EMPRESA ELEGIDA NO HAYA SIDO YA RENDIDA EN UN DIA DENTRO DEL MES Y ANIO ELEGIDO
        private Boolean empresaRendida() {
            DateTime fechaRendicionAVer;
            var cmd = new SqlCommand(
                   "select FECHA_COBRO from SERVOMOTOR.RENDICIONES where CUIT_EMPRESA like '"+comboEmpresa.SelectedItem.ToString()+"'",
                   Program.conexion()
               );

            var dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {

               
                fechaRendicionAVer = Convert.ToDateTime(dataReader["FECHA_COBRO"]);
                // ACA VERIFICAMOS QUE LA EMPRESA ELEGIDA NO HAYA SIDO YA RENDIDA EN UN DIA DENTRO DEL MES Y ANIO ELEGIDO
                if (FechaRendicion.Value.Month == fechaRendicionAVer.Month && FechaRendicion.Value.Year == fechaRendicionAVer.Year)
                {
                    return true;
                }

            }
            return false;

        }

    }
}
