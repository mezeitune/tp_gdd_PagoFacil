﻿using System;
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
            MessageBox.Show("Se ha dado de alta correctamente", "Todo bien",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
