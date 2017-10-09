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
    public partial class ListadoEmpresas : Form
    {
        public bool MostrarEmpresasInactivas = true;

        public ListadoEmpresas()
        {
            InitializeComponent();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            // Hubo un dato seleccionado por el usuario.
            if (Listado.SelectedRows.Count > 0)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Debe seleccionar una empresa!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ListadoEmpresas_Load(object sender, EventArgs e)
        {
            ColEstado.Visible = this.MostrarEmpresasInactivas;
            Listado_Refresh();
            Rubro_Init();
        }

        private void Listado_Refresh()
        {
            var cmd = new SqlCommand(
                "SELECT NOMBRE, CUIT, DIRECCION, DESCRIPCION AS RUBRO, ESTADO_ACTIVACION " +
                "FROM [SERVOMOTOR].EMPRESAS e " +
                "LEFT JOIN [SERVOMOTOR].RUBROS r ON e.ID_RUBRO = r.ID_RUBRO " +
                "WHERE (NOMBRE LIKE @NOMBRE OR @NOMBRE = '') " +
                "  AND (CUIT LIKE @CUIT OR @CUIT = '') " +
                "  AND (DESCRIPCION = @RUBRO OR @RUBRO = '') " +
                "  AND (ESTADO_ACTIVACION = 1 OR @MOSTRAR_INACTIVAS = 1)",
                Program.conexion()
            );

            cmd.Parameters.AddWithValue("@NOMBRE", "%" + Nombre.Text + "%");
            cmd.Parameters.AddWithValue("@CUIT", "%" + CUIT.Text + "%");
            cmd.Parameters.AddWithValue("@RUBRO", Rubro.Text);
            cmd.Parameters.AddWithValue("@MOSTRAR_INACTIVAS", this.MostrarEmpresasInactivas ? 1 : 0);

            var dataReader = cmd.ExecuteReader();

            this.Listado.Rows.Clear();

            while (dataReader.Read())
            {
                this.Listado.Rows.Add(
                    dataReader["NOMBRE"],
                    dataReader["CUIT"],
                    dataReader["RUBRO"],
                    dataReader["DIRECCION"],
                    (bool)dataReader["ESTADO_ACTIVACION"] ? "Activa" : "Inactiva"
                );
            }
        }

        private void Rubro_Init()
        {
            var cmd = new SqlCommand(
                "SELECT DESCRIPCION AS RUBRO " +
                "FROM [SERVOMOTOR].RUBROS",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
                this.Rubro.Items.Add(dataReader["RUBRO"]);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Listado_Refresh();
        }
    }
}
