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
    public partial class AltaFactura : Form
    {
        public AltaFactura()
        {
            InitializeComponent();
        }

        private void AltaFactura_Load(object sender, EventArgs e)
        {
           
        }

        private void DarAltaFactura_Click(object sender, EventArgs e)
        {
            int estadoHab = 1;

            if (!todosLosCamposLLenos() && !validarTipos())
            {
               // int a = Int32.Parse(txtDNICliente.Text);
                var cmdCliente = new SqlCommand(
               "select DNI from [SERVOMOTOR].[CLIENTES] ;",
                Program.conexion()
                );
                var dataReader = cmdCliente.ExecuteReader();

                while(dataReader.Read()){
                    comboCliente.Items.Add(dataReader["DNI"]);
                
                }


                var cmdEmpresa = new SqlCommand(
              "select CUIT from [SERVOMOTOR].[EMPRESAS] ;",
               Program.conexion()
               );
                var dataReaderEmpresa = cmdEmpresa.ExecuteReader();

                while (dataReaderEmpresa.Read())
                {
                    comboEmpresa.Items.Add(dataReaderEmpresa["CUIT"]);

                }



                var cmd = new SqlCommand(
               "insert into [SERVOMOTOR].[FACTURAS] values (" + txtNroFactura.Text + ",'" + FechaAltaFac.Value + "','" + FechaVencFact.Text + "','" + comboCliente.SelectedItem.ToString() +
               "','" + comboEmpresa.SelectedItem.ToString()+ "','" + txtTotalFactura.Text + "','NO PAGA',');",
                Program.conexion()
            );
                var dataReaderFactura = cmd.ExecuteReader();
                MessageBox.Show("Se ha dado de alta correctamente", "Todo bien", MessageBoxButtons.OK);
                this.limpiarTextos();
            }
            else
            {

            }
        }
        private bool todosLosCamposLLenos()
        {

            Boolean huboErrores = false;

            huboErrores = Validacion.estaCheckeadoComboBox(comboCliente) || huboErrores;
            huboErrores = Validacion.estaCheckeadoComboBox(comboEmpresa)|| huboErrores;
            huboErrores = Validacion.esVacio(txtNroFactura, "calle", true) || huboErrores;
            huboErrores = Validacion.esVacio(txtTotalFactura, "departamento", true) || huboErrores;
           

            return huboErrores;
        }

        private bool validarTipos()
        {
            Boolean huboErrores = false;
            huboErrores = !Validacion.esNumero(txtNroFactura, "numero factura", true) || huboErrores;
            huboErrores = !Validacion.esNumero(txtTotalFactura,"total factura", true) || huboErrores;
            
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaVencFact) || huboErrores;
            huboErrores = !Validacion.fechaPosteriorALaDeHoy(FechaAltaFac) || huboErrores;
            return huboErrores;
        }
        

        private void botonIngresarItem_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.AltaDeItemFactura();
            this.cambiarVisibilidades(formularioSiguiente);
        }
        private void cambiarVisibilidades(Form formularioSiguiente)
        {
            formularioSiguiente.Visible = true;
            this.Visible = false;
        }

       

        private void txtTotalFactura_TextChanged(object sender, EventArgs e)
        {
            int totalFactura;
                    //hay que controlar que ese total se vaya cambiando a medida que se agregan items y que el usuario no lo cambie

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
                    }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar los clientes dados de alta por el apellido y nombre
        }

        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar las empresas dadas de altas por el nombre
        }

        private void txtNroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void FechaAltaFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaVencFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTextos();
        }
        private void limpiarTextos() {
            txtNroFactura.Text = "";
            txtTotalFactura.Text = "";
            comboCliente.Items.Clear();
            comboEmpresa.Items.Clear();
            DateTimePicker fechaDeAhora = new DateTimePicker();
            FechaAltaFac.Value = fechaDeAhora.Value;
            FechaVencFact.Value = fechaDeAhora.Value;
        }
        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {

        Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
          this.cambiarVisibilidades(formularioSiguiente);
        }
       
    

    }
       
    }

