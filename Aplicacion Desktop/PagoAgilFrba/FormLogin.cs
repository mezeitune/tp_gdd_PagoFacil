using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Rol_Init();
        }

        private void Rol_Init()
        {
            using (var conexion = Program.conexion())
            {
                var cmd = new SqlCommand(
                    "SELECT NOMBRE AS ROL " +
                    "FROM [SERVOMOTOR].ROLES " +
                    "WHERE ESTADO = 1;",
                    conexion
                );

                using (var dataReader = cmd.ExecuteReader())
                    while (dataReader.Read())
                        Rol.Items.Add(dataReader["ROL"]);

                if (Rol.Items.Count > 0)
                    Rol.SelectedIndex = 0;
            }
        }

        private void SucursalesDisponibles_Init()
        {
            using (var conexion = Program.conexion())
            {
                var cmd = new SqlCommand(
                    "SELECT NOMBRE AS SUCURSAL " +
                    "FROM [SERVOMOTOR].SUCURSALES_USUARIOS su " +
                    "JOIN [SERVOMOTOR].USUARIOS u " +
                    "  ON USERNAME = @USERNAME " +
                    "JOIN [SERVOMOTOR].SUCURSALES s " +
                    "  ON s.COD_POSTAL = su.COD_POSTAL;",
                    conexion
                );

                cmd.Parameters.AddWithValue("@USERNAME", txtUsuario.Text);

                using (var dataReader = cmd.ExecuteReader())
                    while (dataReader.Read())
                        SucursalesDisponibles.Items.Add(dataReader["SUCURSAL"]);

                if (SucursalesDisponibles.Items.Count > 0)
                {
                    SucursalesDisponibles.SelectedIndex = 0;
                    IrAlMenu.Enabled = true;
                }

                botonIngresar.Visible = false;
                botonIngresar.Enabled = false;
                IrAlMenu.Visible = true;
            }
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            gbLogin.Enabled = false;

            if (!LoginUsuario())
            {
                gbLogin.Enabled = true;
                return;
            }

            if (!Rol.SelectedItem.ToString().Equals("Cobrador"))
                IrAlMenuPrincipal();

            using (var conexion = Program.conexion())
            {
                var cmd = new SqlCommand(
                    "SELECT NOMBRE AS SUCURSAL " +
                    "FROM [SERVOMOTOR].SUCURSALES_USUARIOS su " +
                    "JOIN [SERVOMOTOR].USUARIOS u " +
                    "  ON USERNAME = @USERNAME " +
                    "JOIN [SERVOMOTOR].SUCURSALES s " +
                    "  ON s.COD_POSTAL = su.COD_POSTAL;",
                    conexion
                );

                cmd.Parameters.AddWithValue("@USERNAME", txtUsuario.Text);
            }

            gbSucursal.Enabled = true;
        }

        private bool LoginUsuario()
        {
            using (var conexion = Program.conexion())
            using (var cmd = new SqlCommand("[SERVOMOTOR].LoginUsuario", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 20).Value = txtUsuario.Text;
                cmd.Parameters.Add("@ContraseniaIngresada", SqlDbType.VarChar, 70).Value =
                    Encriptador.encriptarSegunSHA256(txtPassword.Text);
                cmd.Parameters.Add("@NombreRol", SqlDbType.VarChar, 30).Value =
                    Rol.SelectedItem.ToString();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void gbSucursal_EnabledChanged(object sender, EventArgs e)
        {
            this.SucursalesDisponibles_Init();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            Regex alfaNumerico = new Regex("^[a-zA-Z0-9]+$");

            if (alfaNumerico.IsMatch(textbox.Text))
                textbox.BackColor = SystemColors.Window;
            else
            {
                textbox.BackColor = Color.LightPink;
            }
            botonIngresar_Refresh();
        }

        private void botonIngresar_Refresh()
        {
            botonIngresar.Enabled = (txtUsuario.BackColor.IsSystemColor &&
                                     txtPassword.BackColor.IsSystemColor &&
                                     Rol.BackColor.IsSystemColor);
            botonIngresar.Enabled &= (!String.IsNullOrEmpty(txtPassword.Text) &&
                                      !String.IsNullOrEmpty(txtPassword.Text));
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            textbox.BackColor = String.IsNullOrEmpty(textbox.Text) ? Color.LightPink
                                                                   : SystemColors.Window;
            botonIngresar_Refresh();
        }

        private void IrAlMenu_Click(object sender, EventArgs e)
        {
            gbSucursal.Enabled = false;
            IrAlMenuPrincipal();
        }

        private void IrAlMenuPrincipal()
        {
            using (MenuPrincipal menuPrincipal = new MenuPrincipal())
            {
                menuPrincipal.Usuario = txtUsuario.Text;
                menuPrincipal.Rol = Rol.SelectedItem.ToString();
                if (menuPrincipal.Rol.Equals("Cobrador"))
                    menuPrincipal.Sucursal = SucursalesDisponibles.SelectedItem.ToString();

                this.Hide();
                menuPrincipal.ShowDialog();
                this.Dispose();
            }
        }
    }
}
