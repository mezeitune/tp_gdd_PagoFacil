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
     //ESTRUCTURAS NECESARIAS PARA PODER LIMITAR EL MENU DEPENDIENDO EL ROL LOGEADO
        public List<int> FuncionalidadesDelRol = new List<int>();
        public List<int> idTodasLasFuncionalidades = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public Dictionary<int, Button> diccionarioTodasLasFunc = new Dictionary<int, Button>();
        int idRol;
        //ESTRUCTURAS NECESARIAS PARA PODER LIMITAR EL MENU DEPENDIENDO EL ROL LOGEADO
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
        //ACA VERIFICAMOS QUE TIPO DE ROL ES, SI COBRADOR O ADMINISTRADOR
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Rol == "Cobrador")
                idRol = 2;
            else
                idRol = 1;
              //CARGAMOS UN DICCIONARIO QUE VINCULA EL ID DE LA FUNCIONALIDAD EN LA BDD CON LOS BOTONES DE LA APLIACION
            this.cargarDiccionario();
            //CARGAMOS LAS FUNCIONALIDADES DEL ROL QUE SE LOGEO
            this.cagarListaFuncionalidadesRol();
           //REALIZAMOS LA RESTA DE ELEMENTOS DE LA LISTA DE TODAS LAS FUNCIONALIDADES EXISTENTES Y LAS QUE TIENE
            //ACTUALMENTE EL ROL
            List<int> botonesABajar= idTodasLasFuncionalidades.Except(FuncionalidadesDelRol).ToList();
            this.deshabilitarBotones(botonesABajar);

        }
        private void cargarDiccionario() {
            diccionarioTodasLasFunc.Add(1, botonABMRol);
            diccionarioTodasLasFunc.Add(2, botonABMCliente);
            diccionarioTodasLasFunc.Add(3, botonABMEmpresa);
            diccionarioTodasLasFunc.Add(4,botonABMFactura);
            diccionarioTodasLasFunc.Add(5, botonABMSucursal);
            diccionarioTodasLasFunc.Add(6, botonRegistrarPago);
            diccionarioTodasLasFunc.Add(7, button1);
            diccionarioTodasLasFunc.Add(8,botonRendicion);
            diccionarioTodasLasFunc.Add(9, botonListadoEstadistico);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioSiguiente = new Devolucion.DevolucionFactura();
            this.Hide();
            formularioSiguiente.ShowDialog();
            this.Show();
        }
        //DESHABLIITAMOS LOS BOTONES QUE QUEDARON EN LA LISTA DONDE HICIMOS LA RESTA
        private void deshabilitarBotones(List<int> botonesABajar)
        {
            for (int i = 0; i < botonesABajar.Count; i++)
            {

                if (diccionarioTodasLasFunc.ContainsKey(botonesABajar[i]))
                {
                    Button boton = diccionarioTodasLasFunc[botonesABajar[i]];
                    boton.Enabled = false;
                }
            }
        }
        //CARGO LA LISTA DE FUNCIONALIDADES DEL ROL LOGEADO
        private void cagarListaFuncionalidadesRol() {

            var cmd = new SqlCommand(
                       "select * from SERVOMOTOR.FUNCIONES_ROLES where ID_ROL="+idRol+";",
                        Program.conexion()
                    );

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.FuncionalidadesDelRol.Add(Convert.ToInt32(dataReader["ID_FUNC"]));
               
            } 
        }
        
    }
}
