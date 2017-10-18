using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

        private void CUITTipo_Validating(object sender, CancelEventArgs e)
        {
            int[] tiposValidos = { 20, 23, 24, 27, 30, 33, 34 };

            if (!tiposValidos.Contains(int.Parse(CUITTipo.Text)))
                errorProvider.SetError(CUITTipo, "Ingrese un CUIT valido.");
            else
                errorProvider.SetError(CUITTipo, String.Empty);
        }

        private void CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir ingresar numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
