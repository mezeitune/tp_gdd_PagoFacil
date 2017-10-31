using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class ListadoUserControl : UserControl
    {
        private readonly String PROCEDURE_NAME;

        public ListadoUserControl(String nombreProcedure)
        {
            InitializeComponent();
            this.PROCEDURE_NAME = nombreProcedure;
        }

        public void ActualizarTabla(String anio, String trimestre)
        {
            using (var conexion = Program.conexion())
            using (var cmd = new SqlCommand(PROCEDURE_NAME, conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ANIO", SqlDbType.Int).Value = anio;
                cmd.Parameters.Add("@TRIMESTRE", SqlDbType.Int).Value = trimestre;

                SqlDataReader dataReader;

                try
                {
                    dataReader = cmd.ExecuteReader();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                /* Inicializar columnas */
                if (this.Tabla.Columns.Count == 0)
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        int numCol =
                            this.Tabla.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));
                        var colAgregada = this.Tabla.Columns[numCol];

                        /* Ajustar ancho de columnas automaticamente. */
                        if (i == dataReader.FieldCount)
                            colAgregada.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        else
                            colAgregada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        /* Celdas de solo lectura. */
                        colAgregada.ReadOnly = true;
                    }

                /* Agregar contenidos del listado. */
                this.Tabla.Rows.Clear();

                /* Si devolvió alguna fila. */
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        var celdas = new Object[this.Tabla.Columns.Count];
                        dataReader.GetValues(celdas);

                        this.Tabla.Rows.Add(celdas);
                    }
                }
                else
                    MessageBox.Show("No se encontraron resultados para esta consulta.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
