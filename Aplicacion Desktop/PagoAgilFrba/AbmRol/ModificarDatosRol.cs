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
    public partial class ModificarDatosRol : Form
    {
        private readonly String IDRol;
        private bool ListadoFuncionalidadesModificado;

        public ModificarDatosRol(String IDRol)
        {
            InitializeComponent();
            this.IDRol = IDRol;
        }

        private void ModificarDatosRol_Load(object sender, EventArgs e)
        {
            NombreEstadoRol_Init();
            Funcionalidad_Init();
            ListadoFuncionalidades_Init();
        }

        private void NombreEstadoRol_Init()
        {
            var cmd = new SqlCommand(
                "SELECT NOMBRE, ESTADO " +
                "FROM [SERVOMOTOR].ROLES " +
                "WHERE ID_ROL = @ID_ROL",
                Program.conexion()
            );

            cmd.Parameters.AddWithValue("@ID_ROL", this.IDRol);
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                nombreRol.Text = (String)dataReader["NOMBRE"];
                EstadoHabilitacion.Checked = (bool)dataReader["ESTADO"];
            }
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

        private void ListadoFuncionalidades_Init()
        {
            var cmd = new SqlCommand(
                "SELECT NOMBRE AS FUNCIONALIDAD " +
                "FROM [SERVOMOTOR].FUNCIONES_ROLES fr " +
                "JOIN [SERVOMOTOR].FUNCIONALIDADES f " +
                "  ON f.ID_FUNC = fr.ID_FUNC " +
                "WHERE fr.ID_ROL = @ID_ROL",
                Program.conexion()
            );

            cmd.Parameters.AddWithValue("@ID_ROL", this.IDRol);

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                String nombreFuncionalidad = (String)dataReader["FUNCIONALIDAD"];
                this.ListadoFuncionalidades.Rows.Add(nombreFuncionalidad);
            }
        }

        private void ListadoFuncionalidades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                this.ListadoFuncionalidadesModificado = true;

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

        private void Actualizar_Click(object sender, EventArgs e)
        {
            var transaccion = Program.conexion().BeginTransaction();

            try
            {
                var cmd = new SqlCommand(
                    "UPDATE [SERVOMOTOR].ROLES " +
                    "SET NOMBRE = @NOMBRE, ESTADO = @ESTADO " +
                    "WHERE ID_ROL = @ID_ROL",
                    transaccion.Connection
                );

                cmd.Transaction = transaccion;

                cmd.Parameters.AddWithValue("@ID_ROL", this.IDRol);
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 30).Value = nombreRol.Text;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Bit).Value = EstadoHabilitacion.Checked;

                cmd.ExecuteNonQuery();

                if (ListadoFuncionalidadesModificado)
                {
                    cmd = new SqlCommand(
                        "DELETE FROM [SERVOMOTOR].FUNCIONES_ROLES " +
                        "WHERE ID_ROL = @ID_ROL",
                        transaccion.Connection
                    );
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@ID_ROL", this.IDRol);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "INSERT INTO [SERVOMOTOR].FUNCIONES_ROLES (ID_ROL, ID_FUNC) " +
                        "  SELECT @ID_ROL, ID_FUNC " +
                        "  FROM [SERVOMOTOR].FUNCIONALIDADES " +
                        "  WHERE NOMBRE = @NOMBRE";

                    var paramNombre = cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 60);

                    foreach (DataGridViewRow filaFuncionalidad in ListadoFuncionalidades.Rows)
                    {
                        if (filaFuncionalidad.IsNewRow)
                            continue;
                        paramNombre.Value = filaFuncionalidad.Cells["Funcionalidad"].Value.ToString();
                        cmd.ExecuteNonQuery();
                    }
                }

                transaccion.Commit();
            }
            catch (Exception exception)
            {
                transaccion.Rollback();
                MessageBox.Show(
                    "No se pudo modificar el rol. " +
                    "Revisar que el nuevo nombre de rol no coincida con un rol ya existente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }

            MessageBox.Show("Se ha modificado el rol correctamente", "Todo bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
