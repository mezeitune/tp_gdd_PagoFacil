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
            using (var conexion = Program.conexion())
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE [SERVOMOTOR].EMPRESAS " +
                                  "SET ESTADO_ACTIVACION = 0 " +
                                  "WHERE CUIT = @CUIT";
                cmd.Connection = conexion;

                cmd.Parameters.AddWithValue("@CUIT", textCUIT.Text);

                try
                {
                    if (cmd.ExecuteNonQuery() != 1)
                        throw new Exception();
                }
                // Código de error = 3
                // Error al intentar dar de baja una empresa con rendiciones pendientes.
                catch (SqlException ex) 
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar dar de baja la empresa.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("La empresa " + textNombre.Text + " fue dada de baja.",
                "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
