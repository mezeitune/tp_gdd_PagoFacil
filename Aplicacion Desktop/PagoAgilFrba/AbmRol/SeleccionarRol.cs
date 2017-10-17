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
    public partial class SeleccionarRol : Form
    {
        public SeleccionarRol()
        {
            InitializeComponent();
        }

        private void SeleccionarRol_Load(object sender, EventArgs e)
        {
            ListadoRol_Refresh();
        }

        private void ListadoRol_Refresh()
        {
            var cmd = new SqlCommand(
                "SELECT ID_ROL AS ID, NOMBRE " +
                "FROM [SERVOMOTOR].ROLES",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
            this.ListadoRol.Rows.Clear();

            while (dataReader.Read())
            {
                this.ListadoRol.Rows.Add(
                    dataReader["ID"],
                    dataReader["NOMBRE"]
                );
            }
        }

        private String IDSeleccionado()
        {
            return this.ListadoRol.SelectedRows[0].Cells["IDRol"].Value.ToString();
        }

        private void ModificarRol_Click(object sender, EventArgs e)
        {
            using (Form formularioModificar = new ModificarDatosRol(this.IDSeleccionado()))
            {
                this.Hide();
                formularioModificar.ShowDialog();
                this.Show();
            }
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
