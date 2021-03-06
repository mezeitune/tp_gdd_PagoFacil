﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PagoAgilFrba.AbmFactura
{
    public partial class ModificarItemFactura : Form
    {
        string nroFact;
        string descripcion;
        string montoAnterior;
        string cantidadAnterior;
        public ModificarItemFactura(string nroFactura, string desc)
        {
            nroFact = nroFactura;
            descripcion = desc;
            InitializeComponent();
        }


        private void botonModificarUnItem_Click(object sender, EventArgs e)
        {
            if (!todosLosCamposLLenos() && !validarTipos())
            {
                String monto = txtMontoItem.Text.ToString();
                var cmd = new SqlCommand(
                     "EXEC [SERVOMOTOR].insertOUpdateEnItems @TIPOOPERACION,@DESCRIPCION,@MONTO,@CANTIDAD,@NUMERO_FACTURA",
               Program.conexion()
                  );
                cmd.Parameters.AddWithValue("@TIPOOPERACION", 0);
                cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                cmd.Parameters.AddWithValue("@MONTO", monto);
                cmd.Parameters.AddWithValue("@CANTIDAD", Convert.ToInt16(txtCantidadItem.Text));
                cmd.Parameters.AddWithValue("@NUMERO_FACTURA", Convert.ToDecimal(nroFact));

                var dataReader = cmd.ExecuteReader();
                MessageBox.Show("Se ha modificado correctamente el item : " + descripcion, "", MessageBoxButtons.OK);
                int subtotalAnterior = (Convert.ToInt32(montoAnterior) * Convert.ToInt32(cantidadAnterior));
                int subtotalParametro = (Convert.ToInt32(txtMontoItem.Text.ToString()) * Convert.ToInt32(txtCantidadItem.Text.ToString())) - subtotalAnterior;
                Form formularioSiguiente = new AbmFactura.ModificarDatosFactura(nroFact, subtotalParametro);
                formularioSiguiente.Visible = true;
                this.Visible = false;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtMontoItem.Text = "";
            txtCantidadItem.Text = "";

        }

        private void ModificarItemFactura_Load(object sender, EventArgs e)
        {
            this.query_inicial();
        }

        private void query_inicial()
        {
            var cmd = new SqlCommand(
                    "select * from [SERVOMOTOR].ITEMS where NUMERO_FACTURA='" + nroFact + "' AND DESCRIPCION='" + descripcion + "';",
                     Program.conexion()
                 );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtCantidadItem.Text = dataReader["CANTIDAD"].ToString();
                txtMontoItem.Text = dataReader["MONTO"].ToString();
                montoAnterior = dataReader["MONTO"].ToString();
                cantidadAnterior = dataReader["CANTIDAD"].ToString();
            }


        }


        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.esVacio(txtMontoItem, "Monto", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtCantidadItem, "Cantidad", true) || huboErrores;


            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;

            huboErrores = !Validacion.esNumero(txtCantidadItem, "Cantidad", true) || huboErrores;

            huboErrores = !Validacion.esNumero(txtMontoItem, "Monto", true) || huboErrores;

            return huboErrores;
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

    }
}
