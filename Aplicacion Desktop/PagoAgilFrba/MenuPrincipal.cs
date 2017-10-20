using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PagoAgilFrba
{
    public partial class MenuPrincipal : Form
    {
        public String Usuario { get; set; }
        public String Rol { get; set; }
        public String Sucursal { get; set; }
        public List<int> Funcionalidades = new List<int>();
        public Dictionary<int, Button> diccionarioFunc = new Dictionary<int, Button>();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonABMCliente_Click(object sender, EventArgs e)
        {
            
            Form formularioSiguiente = new AbmCliente.PantallaPrincipalABMCliente();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonABMSucursal_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmSucursal.Form1();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonABMEmpresa_Click(object sender, EventArgs e)
        {
            Form formularioEmpresa = new AbmEmpresa.PantallaPrincipalABMEmpresa();
            this.Hide();
            formularioEmpresa.ShowDialog();
            this.Show();
        }

        private void botonABMFactura_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new AbmFactura.PantallaPrincipalABMFactura();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonABMRol_Click(object sender, EventArgs e)
        {
            Form formularioABMRol = new AbmRol.PantallaPrincipalABMRol();
            this.Hide();
            formularioABMRol.ShowDialog();
            this.Show();
        }

        private void botonListadoEstadistico_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new ListadoEstadistico.PantallaPrincipalListadoEstadistico();//falta hacer esto
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void botonRegistrarPago_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new RegistroPago.PantallaPrincipalRegistroPagoFacturas(); //falta hacer esto
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
            
        }

        private void botonRendicion_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Rendicion.PantallaPrincipalRendicion();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.cargarDiccionario();
            
            this.obtenerFuncionalidadesRol();
            var FuncionalidadesTodas = new List<int>{ 1,2,3,4,5,6,7,8,9};
            List<int> botonesABajar= FuncionalidadesTodas.Except(Funcionalidades).ToList();
            
            for (int i = 0; i < botonesABajar.Count;i++ )
            {
               
                if (diccionarioFunc.ContainsKey(botonesABajar[i]))
                {
                    Button boton = diccionarioFunc[botonesABajar[i]];
                    boton.Enabled = false;
                }
            }

        }
        private void cargarDiccionario() {
         
            diccionarioFunc.Add(1, botonABMRol);
            diccionarioFunc.Add(2, botonABMCliente);
            diccionarioFunc.Add(3, botonABMEmpresa);
            diccionarioFunc.Add(4,botonABMFactura);
            diccionarioFunc.Add(5, botonABMSucursal);
            diccionarioFunc.Add(6, botonRegistrarPago);
            diccionarioFunc.Add(7, button1);
            diccionarioFunc.Add(8,botonRendicion);
            diccionarioFunc.Add(9, botonListadoEstadistico);
        
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Devolucion.DevolucionFactura();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }
        private void obtenerFuncionalidadesRol() {
            int idRol;
            if (Rol == "Cobrador")
            { idRol = 2; }
            else
            { idRol = 1; }

            var cmd = new SqlCommand(
                       "select * from SERVOMOTOR.FUNCIONES_ROLES where ID_ROL="+idRol+";",
                        Program.conexion()
                    );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.Funcionalidades.Add(Convert.ToInt32(dataReader["ID_FUNC"]));
               
            }
           
             
            
        }




        
    }
}
