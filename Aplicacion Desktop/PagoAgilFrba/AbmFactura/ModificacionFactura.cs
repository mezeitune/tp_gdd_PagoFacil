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
            Form formularioSiguiente = new AbmFactura.ModificarDatosFactura(numeroFactura);
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

        private void comboBoxNroFacturaModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroFactura = comboBoxNroFacturaModif.SelectedIndex.ToString(); 
            

            MessageBox.Show("Se ha seleccionado la factura NUM: " + numeroFactura, "", MessageBoxButtons.OK);
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }

        private void ModificacionFactura_Load(object sender, EventArgs e)
        {
            this.query_inicial();
        }

        private void query_inicial(){
            var cmd = new SqlCommand(
                    "select NUMERO_FACTURA from [SERVOMOTOR].FACTURAS ",
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
