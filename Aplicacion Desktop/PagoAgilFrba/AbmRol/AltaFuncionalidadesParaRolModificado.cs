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
    public partial class AltaFuncionalidadesParaRolModificado : Form
    {
        public AltaFuncionalidadesParaRolModificado()
        {
            InitializeComponent();
        }

        private void FuncionalidadesAMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar o todas las funcionalidades que le falta a ese rol, o todas y validar lo de abajo
        }

        private void agregarFuncionalidadAlRol_Click(object sender, EventArgs e)
        {
            //no agregar una funcionalidad si ya la tiene ese rol, verificar eso
        }
    }
}
