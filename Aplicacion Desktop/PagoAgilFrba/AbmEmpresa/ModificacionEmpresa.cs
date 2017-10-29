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
    public partial class ModificacionEmpresa : Form
    {
        public DataGridViewCellCollection Values;
        
        public ModificacionEmpresa()
        {
            InitializeComponent();
        }

        private void ModificacionEmpresa_Load(object sender, EventArgs e)
        {
            Rubro_Init();
            Values_Load();
        }

        private void Rubro_Init()
        {
            using (var conexion = Program.conexion())
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT DESCRIPCION AS Rubro " +
                                  "FROM [SERVOMOTOR].RUBROS";
                cmd.Connection = conexion;

                using (var dataReader = cmd.ExecuteReader())
                    while (dataReader.Read())
                        Rubro.Items.Add(dataReader["Rubro"]);
            }
        }

        private void Values_Load()
        {
            this.Nombre.Text       = Values["ColNombre"].Value.ToString();
            this.Rubro.Text        = Values["ColRubro"].Value.ToString();
            this.Direccion.Text    = Values["ColDireccion"].Value.ToString();
            this.Habilitar.Checked = Values["ColEstado"].Value.ToString().Equals("Activa");

            // Dividir CUIT en 3 campos.
            var camposCUIT = Values["ColCUIT"].Value.ToString().Split('-');
            this.CUITTipo.Text = camposCUIT[0];
            this.CUITNumero.Text = camposCUIT[1];
            this.CUITVerificador.Text = camposCUIT[2];
        }

        private void Deshacer_Click(object sender, EventArgs e)
        {
            Values_Load();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            // Deshabilitar los controles hasta que finalice la operación.
            GroupBoxDatos.Enabled = false;

            // Verificar el CUIT ingresado con el algoritmo de validación.
            if (!ValidacionCUIT.Validar(CUITTipo.Text + CUITNumero.Text + CUITVerificador.Text))
            {
                MessageBox.Show("El CUIT ingresado no es valido!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                GroupBoxDatos.Enabled = true;
                return;
            }

            using (var conexion = Program.conexion())
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText =
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
                    "WHERE CUIT = @CUIT_ORIG";
                cmd.Connection = conexion;

                cmd.Parameters.Add("@CUIT", SqlDbType.VarChar, 50).Value =
                    CUITTipo.Text + "-" + CUITNumero.Text + "-" + CUITVerificador.Text;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 255).Value = Nombre.Text;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 255).Value = Direccion.Text;
                cmd.Parameters.AddWithValue("@RUBRO", Rubro.Text);
                cmd.Parameters.Add("@ESTADO_ACTIVACION", SqlDbType.Bit).Value = Habilitar.Checked ? 1 : 0;
                cmd.Parameters.Add("@CUIT_ORIG", SqlDbType.VarChar, 50).Value =
                    Values["ColCUIT"].Value.ToString();

                try
                {
                    // ExecuteNonQuery() de por sí podría lanzar otras excepciones.
                    if (cmd.ExecuteNonQuery() != 1)
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar modificar la empresa.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GroupBoxDatos.Enabled = true;
                    return;
                }
            }

            MessageBox.Show("Los datos de la empresa " + Nombre.Text + " fueron actualizados.",
                "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        // Prevenir que el usuario ingrese como CUIT caracteres no numéricos.
        private void CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Nombre_Direccion_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
                textbox.BackColor = Color.LightPink;
            else
                textbox.BackColor = SystemColors.Window;

            Actualizar_Refresh();
        }

        private void CUITTipo_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            String[] tiposValidos = { "30", "33", "34" };

            if (tiposValidos.Contains(textbox.Text))
            {
                // Eliminar tooltip error.
                errorProvider.SetError(CUITTipo, String.Empty);
                textbox.BackColor = SystemColors.Window;
            }
            else
            {
                // Mostrar error.
                errorProvider.SetError(CUITTipo, "Ingrese un CUIT valido.\n" +
                    "Los 2 primeros dígitos deben ser 30, 33 o 34.");
                textbox.BackColor = Color.LightPink;
            }

            Actualizar_Refresh();
        }

        private void CUITNumero_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text) ||
                  textbox.Text.Length != 8)
                textbox.BackColor = Color.LightPink;
            else
                textbox.BackColor = SystemColors.Window;

            Actualizar_Refresh();
        }

        private void CUITVerificador_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text) ||
                  textbox.Text.Length != 1)
                textbox.BackColor = Color.LightPink;
            else
                textbox.BackColor = SystemColors.Window;

            Actualizar_Refresh();
        }

        // Actualizar estado del botón "Dar de alta" (Activado / Desactivado).
        private void Actualizar_Refresh()
        {
            var campos = new List<Control>
            {
                Nombre, CUITTipo, CUITNumero, CUITVerificador, Direccion
            };

            // Misma validación para todos los textboxes.
            Actualizar.Enabled = campos.All(
                // Verificar que tengan color normal (validación exitosa).
                campo => campo.BackColor.IsSystemColor
            );
        }
    }
}
