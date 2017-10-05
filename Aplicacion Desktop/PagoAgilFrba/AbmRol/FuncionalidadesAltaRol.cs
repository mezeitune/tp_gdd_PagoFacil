using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class FuncionalidadesAltaRol : Form
    {
        public FuncionalidadesAltaRol()
        {
            InitializeComponent();
        }

        private void agregarFuncionalidadAlRol_Click(object sender, EventArgs e)
        {
            //muestra todas las funcionalidades disponibles
            MessageBox.Show("Se ha agregado la funcionalidad al rol correctamente", "Todo bien", MessageBoxButtons.OK);
        }

        private void funcionalidadesAMostar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aca hay que fijarse que la funcionalidad que se agrega no esta repetida en el rol que se esta dando de alta actualmente
           
        }
    }
}
