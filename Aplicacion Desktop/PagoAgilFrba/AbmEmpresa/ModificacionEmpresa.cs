using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ModificacionEmpresa : Form
    {
        public DataGridViewCellCollection values;
        
        public ModificacionEmpresa()
        {
            InitializeComponent();
        }

        private void ModificacionEmpresa_Load(object sender, EventArgs e)
        {
            Values_Load();
        }

        private void Values_Load()
        {
            this.Nombre.Text       = values["ColNombre"].Value.ToString();
            this.CUIT.Text         = values["ColCUIT"].Value.ToString();
            this.Rubro.Text        = values["ColRubro"].Value.ToString();
            this.Direccion.Text    = values["ColDireccion"].Value.ToString();
            this.Habilitar.Checked = values["ColEstado"].Value.ToString().Equals("Activa");
        }

        private void Deshacer_Click(object sender, EventArgs e)
        {
            Values_Load();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                "UPDATE [SERVOMOTOR].EMPRESAS " +
                "SET CUIT = @CUIT, " +
                "    NOMBRE = @NOMBRE, " +
                "    DIRECCION = @DIRECCION, " +
                "    ID_RUBRO = ( " +
                "                SELECT ID_RUBRO " +
                "                FROM [SERVOMOTOR].RUBROS " +
                "                WHERE DESCRIPCION = @RUBRO" +
                "               ), " +
                "    ESTADO_ACTIVACION = @ESTADO_ACTIVACION " +
                "WHERE CUIT = @CUIT_ORIG",
                Program.conexion()
            );

            cmd.Parameters.Add("@CUIT", SqlDbType.VarChar, 13).Value = CUIT.Text;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 20).Value = Nombre.Text;
            cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 20).Value = Direccion.Text;
            cmd.Parameters.Add("@RUBRO", SqlDbType.VarChar, 20).Value = Rubro.Text;
            cmd.Parameters.Add("@ESTADO_ACTIVACION", SqlDbType.Bit).Value = Habilitar.Checked ? 1 : 0;
            cmd.Parameters.Add("@CUIT_ORIG", SqlDbType.VarChar, 13).Value =
                values["ColCUIT"].Value.ToString();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Los datos de la empresa " + Nombre.Text + " fueron actualizados.",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error al intentar modificar la empresa.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Habilitar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
