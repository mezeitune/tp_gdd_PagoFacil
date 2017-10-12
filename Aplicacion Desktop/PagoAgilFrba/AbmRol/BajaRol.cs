using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
        }

        private void BajaRol_Load(object sender, EventArgs e)
        {
            ListadoRol_Refresh();
        }

        private void ListadoRol_Refresh()
        {
            var cmd = new SqlCommand(
                "SELECT NOMBRE AS ROL " +
                "FROM [SERVOMOTOR].ROLES " +
                "WHERE ESTADO = 1",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
            this.ListadoRol.Rows.Clear();

            while (dataReader.Read())
            {
                this.ListadoRol.Rows.Add(dataReader["ROL"]);
            }
        }

        private void darDeBajaRol_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                "UPDATE [SERVOMOTOR].ROLES " +
                "SET ESTADO = 0 " +
                "WHERE NOMBRE = @NOMBRE",
                Program.conexion()
            );

            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value =
                ListadoRol.SelectedRows[0].Cells["NombreRol"].Value.ToString();

            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Se ha inhabilitado el rol correctamente.", "Todo bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al intentar inhabilitar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ListadoRol_Refresh();
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
