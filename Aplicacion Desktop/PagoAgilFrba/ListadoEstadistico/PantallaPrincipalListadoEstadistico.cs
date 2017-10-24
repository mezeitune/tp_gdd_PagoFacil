using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class PantallaPrincipalListadoEstadistico : Form
    {
        private const int CANTIDAD_LISTADOS = 4;
        private Dictionary<String, ListadoUserControl> ListadoUserControls;

        public PantallaPrincipalListadoEstadistico()
        {
            InitializeComponent();
        }

        private void PantallaPrincipalListadoEstadistico_Load(object sender, EventArgs e) {
            TipoListado_Init();

            /* No puede ingresar un año mayor que el año actual. */
            Anio.Maximum = DateTime.Now.Year;

            /* Seleccionar primer trimestre por defecto. */
            Trimestre.SelectedIndex = 0;
        }

        private void TipoListado_Init()
        {
            this.ListadoUserControls = new Dictionary<String, ListadoUserControl>(CANTIDAD_LISTADOS);

            this.ListadoUserControls.Add(
                "Porcentaje de facturas cobradas por empresa",
                new ListadoUserControl("[SERVOMOTOR].ListadoPorcentajeFacturasCobradas")
            );

            this.ListadoUserControls.Add(
                "Empresas con mayor monto rendido",
                new ListadoUserControl("[SERVOMOTOR].ListadoEmpresasMayorMontoRendido")
            );

            this.ListadoUserControls.Add(
                "Clientes con mas pagos",
                new ListadoUserControl("[SERVOMOTOR].ListadoClienteConMasPagos")
            );

            this.ListadoUserControls.Add(
                "Clientes con mayor porcentaje de facturas pagadas",
                new ListadoUserControl("[SERVOMOTOR].ListadoClientesCumplidores")
            );

            foreach (var tipo in ListadoUserControls)
                this.TipoListado.Items.Add(tipo.Key);

            /* Selecciona el primer item por defecto. */
            this.TipoListado.SelectedIndex = 0;
        }

        private void TipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelListado.Controls.Clear();
            this.PanelListado.Visible = true;

            var listado = ListadoUserControls[TipoListado.SelectedItem.ToString()];
            listado.Dock = DockStyle.Fill;

            listado.Show();
            PanelListado.Controls.Add(listado);
        }

        private void volverALaPaginaAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void GenerarListado_Click(object sender, EventArgs e)
        {
            ListadoUserControls[TipoListado.SelectedItem.ToString()]
                .ActualizarTabla(
                    Anio.Value.ToString(),
                    /* Sumarle 1 porque el indice comienza en 0. */
                    (Trimestre.SelectedIndex + 1).ToString()
                 );
        }
    }
}
