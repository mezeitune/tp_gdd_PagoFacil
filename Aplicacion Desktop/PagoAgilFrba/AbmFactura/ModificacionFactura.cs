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
    public partial class ModificacionFactura : Form
    {
        public ModificacionFactura()
        {
            InitializeComponent();
        }
        string numeroFactura;
        
        private void ModificarFactura_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.ModificarDatosFactura(numeroFactura,0);
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void comboBoxNroFacturaModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroFactura = comboBoxNroFacturaModif.SelectedItem.ToString(); 
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new MenuPrincipal();
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void ModificacionFactura_Load(object sender, EventArgs e)
        {
            this.query_inicial();
        }
        //BATCH LEVANTAR FACTURAS, DECIDIMOS SOLO MOSTRAR EL NUMERO DE FACTURA PARA SELECCIONAR
        private void query_inicial(){
            var cmd = new SqlCommand(
                    "select * from [SERVOMOTOR].FACTURAS F where ISNULL(F.NUMERO_PAGO,0)=0 AND ISNULL(F.ID_RENDICION,0)=0 ",
                     Program.conexion()
                 );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.comboBoxNroFacturaModif.Items.Add(dataReader["NUMERO_FACTURA"]);
            }
        }

       
    }
}
