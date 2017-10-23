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



        private void darDeAltaRendicion() {

            totalComision = Convert.ToDecimal(Convert.ToDecimal(porcentajeComision.Text) * Convert.ToDecimal(importeTotalRendicion.Text) / 100);

            var cmd = new SqlCommand(
           "INSERT INTO [SERVOMOTOR].[RENDICIONES] (FECHA_COBRO,PORCENTAJE_COMISION,CANTIDAD_FACTURAS_RENDIDAS,PRECIO_COMISION,TOTAL_RENDIDO,CUIT_EMPRESA) VALUES (@fecha,@porc_com,@cant_fact,@precio_comision,@total_rendido,@cuit_empresa);",
           Program.conexion()
       );
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime, 13).Value = FechaRendicion.Value;
            cmd.Parameters.Add("@porc_com", SqlDbType.Int, 20).Value = Convert.ToInt32(porcentajeComision.Text);
            cmd.Parameters.Add("@cant_fact", SqlDbType.Int, 20).Value = Convert.ToInt32(CantidadFacturasRendidas.Text);
            cmd.Parameters.Add("@precio_comision", SqlDbType.Decimal, 20).Value = totalComision;
            cmd.Parameters.Add("@total_rendido", SqlDbType.Decimal).Value = Convert.ToDecimal(importeTotalRendicion.Text);
            cmd.Parameters.Add("@cuit_empresa", SqlDbType.VarChar, 13).Value = comboEmpresa.SelectedItem.ToString();

            var dataReader = cmd.ExecuteReader();
                
        
        }

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
           // huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresa) || huboErrores;
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
            if (!empresaRendida())
            {
                var cmd = new SqlCommand(
                    "SELECT * FROM [SERVOMOTOR].[FACTURAS] f JOIN SERVOMOTOR.PAGOS p ON f.NUMERO_PAGO=p.NUMERO_PAGO WHERE CUIT_EMPRESA= '" + comboEmpresa.SelectedItem.ToString() + "' AND ESTADO='PAGA' AND FECHA_COBRO BETWEEN ('1/" + FechaRendicion.Value.Month + "/" + FechaRendicion.Value.Year + "') AND ('31/" + FechaRendicion.Value.Month + "/" + FechaRendicion.Value.Year + "');",
                    Program.conexion()
                );

                var dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    this.dataGridView1.Rows.Add(
                        dataReader["NUMERO_FACTURA"],
                        dataReader["TOTAL"]

                    );
                    importeTotalARendir += Convert.ToDecimal(dataReader["TOTAL"]);



                }
                CantidadFacturasRendidas.Text = (dataGridView1.Rows.Count).ToString();
                importeTotalRendicion.Text = importeTotalARendir.ToString();
            }
            else {
                MessageBox.Show("Empresa ya rendida en este mes", "Todo bien", MessageBoxButtons.OK);
            }
            
        }

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
                if (FechaRendicion.Value.Month == fechaRendicionAVer.Month && FechaRendicion.Value.Year == fechaRendicionAVer.Year)
                {
                    return true;
                }

            }
            return false;

        }

    }
}
