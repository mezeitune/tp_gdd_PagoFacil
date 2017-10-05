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
    public partial class PantallaPrincipalABMEmpresa : Form
    {
        public PantallaPrincipalABMEmpresa()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            using (Form formAlta = new AltaEmpresa())
            {
                formAlta.ShowDialog();
            }
        }

        private void PantallaPrincipalABMEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            using (var formListado = new ListadoEmpresas())
            {
                var result = formListado.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var values = formListado.Listado.SelectedRows[0].Cells;
                    using (var formBaja = new BajaEmpresa())
                    {
                        formBaja.textNombre.Text    = values["ColNombre"].Value.ToString();
                        formBaja.textCUIT.Text      = values["ColCUIT"].Value.ToString();
                        formBaja.textRubro.Text     = values["ColRubro"].Value.ToString();
                        formBaja.textDireccion.Text = values["ColDireccion"].Value.ToString();

                        formBaja.ShowDialog();
                    }
                }
            }
        }
    }
}
