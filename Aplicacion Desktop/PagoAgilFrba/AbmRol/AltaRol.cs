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
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            Funcionalidad_Init();
        }

        private void Funcionalidad_Init()
        {
            var cmd = new SqlCommand(
                "SELECT NOMBRE AS FUNCIONALIDAD " +
                "FROM [SERVOMOTOR].FUNCIONALIDADES",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
                this.Funcionalidad.Items.Add(dataReader["FUNCIONALIDAD"]);
        }

        private void DarDeAlta_Click(object sender, EventArgs e)
        {
            this.GroupBoxDatos.Enabled = false;

            var transaccion = Program.conexion().BeginTransaction();

            try
            {
                var cmd = new SqlCommand(
                    "INSERT INTO [SERVOMOTOR].ROLES (NOMBRE)" +
                    "VALUES (@NOMBRE);" +
                    "SELECT SCOPE_IDENTITY();",
                    transaccion.Connection
                );

                cmd.Transaction = transaccion;

                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 30).Value = nombreRol.Text;

                var idRol = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand(
                    "INSERT INTO [SERVOMOTOR].FUNCIONES_ROLES (ID_ROL, ID_FUNC) " +
                    "  SELECT @ID_ROL, ID_FUNC " +
                    "  FROM [SERVOMOTOR].FUNCIONALIDADES " +
                    "  WHERE NOMBRE = @NOMBRE",
                    transaccion.Connection
                );

                cmd.Transaction = transaccion;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ID_ROL", SqlDbType.TinyInt).Value = idRol;
                var paramNombre = cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 60);

                foreach (DataGridViewRow fila in this.ListadoFuncionalidades.Rows)
                {
                    if (fila.IsNewRow)
                        continue;
                    paramNombre.Value = fila.Cells["Funcionalidad"].Value.ToString();
                    cmd.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
        
            catch (Exception exception)
            {
                transaccion.Rollback();
                MessageBox.Show(
                    "No se pudo dar de alta el rol." +
                    "Revisar que el nuevo nombre de rol no coincida con un rol ya existente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                this.GroupBoxDatos.Enabled = true;
                return;
            }

            MessageBox.Show("Se ha dado de alta correctamente", "Todo bien",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ListadoFuncionalidades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || ListadoFuncionalidades.Rows[e.RowIndex]
                .Cells["Funcionalidad"].Value == null)
                return;

            var celdaActualizada = ListadoFuncionalidades.Rows[e.RowIndex].Cells["Funcionalidad"];
            var itemSeleccionado = celdaActualizada.Value.ToString();

            foreach (DataGridViewRow funcionalidad in ListadoFuncionalidades.Rows)
            {
                if (funcionalidad.Index == e.RowIndex)
                    continue;

                if (funcionalidad.Cells["Funcionalidad"].Value == null)
                    continue;

                var itemActual = funcionalidad.Cells["Funcionalidad"].Value.ToString();
                if (itemActual.Equals(itemSeleccionado))
                {
                    MessageBox.Show("No se puede agregar dos veces la misma funcionalidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ListadoFuncionalidades.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void nombreRol_Leave(object sender, EventArgs e)
        {
            if (nombreRol.Text.Length == 0)
            {
                MessageBox.Show("El nombre de rol no puede ser vacio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nombreRol.Focus();
            }
        }

        private void EliminarFuncionalidad_Click(object sender, EventArgs e)
        {
            if (ListadoFuncionalidades.SelectedRows.Count > 0 &&
                !ListadoFuncionalidades.SelectedRows[0].IsNewRow)
                ListadoFuncionalidades.Rows.Remove(ListadoFuncionalidades.SelectedRows[0]);
        }
    }
}
