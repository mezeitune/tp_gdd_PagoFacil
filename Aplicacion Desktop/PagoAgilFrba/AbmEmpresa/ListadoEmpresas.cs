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
        public ListadoEmpresas()
        {
            InitializeComponent();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            // Hubo un dato seleccionado por el usuario.
            this.DialogResult = DialogResult.OK;
        }

        private void ListadoEmpresas_Load(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(
                "SELECT NOMBRE, CUIT, DIRECCION, DESCRIPCION AS RUBRO " +
                "FROM [SERVOMOTOR].EMPRESAS e " +
                "LEFT JOIN [SERVOMOTOR].RUBROS r ON e.ID_RUBRO = r.ID_RUBRO",
                Program.conexion()
            );

            var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                this.Listado.Rows.Add(
                    dataReader["NOMBRE"],
                    dataReader["CUIT"],
                    dataReader["RUBRO"],
                    dataReader["DIRECCION"]
                );
            }
        }
    }
}
