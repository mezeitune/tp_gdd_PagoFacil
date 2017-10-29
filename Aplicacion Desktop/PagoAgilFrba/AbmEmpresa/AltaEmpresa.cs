using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class AltaEmpresa : Form
    {
        public AltaEmpresa()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nombre.Clear();
            CUITTipo.Clear();
            CUITNumero.Clear();
            CUITVerificador.Clear();
            Direccion.Clear();
            DarDeAlta.Refresh();
        }

        private void AltaEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void DarDeAlta_Click(object sender, EventArgs e)
        {
            // Deshabilitar todos los controles.
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
                    @"INSERT INTO [SERVOMOTOR].EMPRESAS
                        (CUIT, NOMBRE, DIRECCION, ID_RUBRO, ESTADO_ACTIVACION)
                      VALUES (
                        @CUIT,
                        @NOMBRE,
                        @DIRECCION,
                        (
                          SELECT ID_RUBRO
                            FROM [SERVOMOTOR].RUBROS
                           WHERE DESCRIPCION = @RUBRO
                        ),
                        1
                      );";
                cmd.Connection = conexion;

                cmd.Parameters.Add("@CUIT", SqlDbType.VarChar, 50).Value =
                    CUITTipo.Text + "-" + CUITNumero.Text + "-" + CUITVerificador.Text;

                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 255).Value =
                    Nombre.Text;

                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 255).Value =
                    Direccion.Text;

                cmd.Parameters.Add("@RUBRO", SqlDbType.VarChar, 20).Value =
                    Rubro.SelectedItem.ToString();

                try
                {
                    if (cmd.ExecuteNonQuery() != 1)
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo dar de alta la empresa.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GroupBoxDatos.Enabled = true;
                    return;
                }
            }

            MessageBox.Show("La empresa fue dada de alta.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir ingresar números.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {
            Rubro_Init();
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

            // Seleccionar por defecto el primer rubro que haya.
            if (Rubro.Items.Count > 0)
                Rubro.SelectedIndex = 0;
        }

        private void Nombre_Direccion_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
                textbox.BackColor = Color.LightPink;
            else
                textbox.BackColor = SystemColors.Window;

            DarDeAlta_Refresh();
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

            DarDeAlta_Refresh();
        }

        private void CUITNumero_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text) ||
                  textbox.Text.Length != 8)
                textbox.BackColor = Color.LightPink;
            else
                textbox.BackColor = SystemColors.Window;

            DarDeAlta_Refresh();
        }

        private void CUITVerificador_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text) ||
                  textbox.Text.Length != 1)
                textbox.BackColor = Color.LightPink;
            else
                textbox.BackColor = SystemColors.Window;

            DarDeAlta_Refresh();
        }

        // Actualizar estado del botón "Dar de alta" (Activado / Desactivado).
        private void DarDeAlta_Refresh()
        {
            // No hay rubros, por lo tanto no puede dar de alta nunguna empresa
            //   (en este caso se debe agregar un rubro desde la BD).
            if (Rubro.Items.Count <= 0)
                return;

            var campos = new List<Control>
            {
                Nombre, CUITTipo, CUITNumero, CUITVerificador, Direccion
            };

            // Misma validación para todos los textboxes.
            DarDeAlta.Enabled = campos.All(
                campo => !String.IsNullOrEmpty(campo.Text)

                         // Además de ver si los campos son vacíos, verifica que no estén
                         //   pintados de color rojo (validación fallida).
                         && campo.BackColor.IsSystemColor
            );
        }
    }
}
