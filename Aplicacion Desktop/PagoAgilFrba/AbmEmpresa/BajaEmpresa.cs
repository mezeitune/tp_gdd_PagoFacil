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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class BajaEmpresa : Form
    {
        public BajaEmpresa()
        {
            InitializeComponent();
        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                "UPDATE [SERVOMOTOR].EMPRESAS " +
                "SET ESTADO_ACTIVACION = 0 " +
                "WHERE CUIT = @CUIT",
                Program.conexion()
            );

            cmd.Parameters.AddWithValue("@CUIT", textCUIT.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("La empresa " + textNombre.Text + " fue dada de baja.",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error al intentar dar de baja la empresa.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
