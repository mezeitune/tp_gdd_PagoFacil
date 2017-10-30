using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    // Clase que contiene todas las validaciones generales que se hacen en la aplicación
    static class Validacion
    {
        
        public static Boolean textNombre(TextBox txtBox , string nombreCampo)
        {
            Boolean huboErrores = false;

            if (Validacion.esVacio(txtBox , nombreCampo , true))
            {
                huboErrores = true;
            }
            else
            {//esta hecho asi porque si es vacio no tiene sentido que entre para validar que sea texto ya que no hay nada
                if(!Validacion.esTexto(txtBox))
                {
                    MessageBox.Show("El campo " + nombreCampo + " debe ser una cadena de caracteres", "Error en el nombre", MessageBoxButtons.OK);
                    huboErrores = true;
                }
            }
            
            return !huboErrores;
        }

        // Validación para campos de los filtros
        public static Boolean filtrosContengaEIgualdad(TextBox filtro1, TextBox filtro2)
        {
            Boolean huboErrores = false;

            if (!esSoloTexto(filtro1) && !esVacio(filtro1  , "No importa" , false))
            {
                MessageBox.Show("El filtro que contenga la palabra debe ser una cadena de caracteres", "Error en el nombre", MessageBoxButtons.OK);
                huboErrores = true;
            }

            if (!esSoloTexto(filtro2) && !esVacio(filtro2 , "No importa" , false))
            {
                MessageBox.Show("El filtro por igualdad de palabra debe ser una cadena de caracteres", "Error en el nombre", MessageBoxButtons.OK);
                huboErrores = true;
            }

            return !huboErrores;
        }
        

        //****** VALIDACIONES NUMERICAS *******//

        // Usado para validar números enteros
        public static Boolean esNumero(TextBox txtBox , string nombreCampo = "Opcional" , Boolean mostrarMensaje = false)
        {
            long numero;
            string cadena = txtBox.Text;

            if (cadena == "")
                return true;

            if (long.TryParse(cadena, out numero))
            {
                if (!cadena.Contains(" "))
                {
                    return true;
                }
            }
            if (mostrarMensaje)
            {
                MessageBox.Show("El valor del campo " + nombreCampo + " debe ser un número entero", "Error en los datos de entrada", MessageBoxButtons.OK);
            }
            return false;       
        }

        public static Boolean esNumeroMayorA0(TextBox txtBox, string nombreCampo = "Opcional", Boolean mostrarMensaje = false)
        {
            decimal numero = Convert.ToDecimal(txtBox.Text);
            if (numero > 0) {
                return true;
            }
            if (mostrarMensaje)
            {
                MessageBox.Show("El valor del campo " + nombreCampo + " debe ser mayor a 0", "Error en los datos de entrada", MessageBoxButtons.OK);
            }
            return false;
        }


        // Usado para validar números decimales
        public static Boolean esDecimal(TextBox txtBox, string nombreCampo = "Opcional", Boolean mostrarMensaje = false)
        {
            string cadena = txtBox.Text;
            decimal numero;

            if (cadena == "")
                return true;

            if(!comaYPuntoCorrectos(cadena))
            {
                if (mostrarMensaje)
                {
                    MessageBox.Show("El valor del campo " + nombreCampo + " debe ser un número", "Error en los datos de entrada", MessageBoxButtons.OK);
                }
                return false;
            }

            cadena.Replace('.', ',');

            if (Decimal.TryParse(cadena, out numero))
            {
                if (!cadena.Contains(" "))
                {
                    return true;
                }
            }
            if (mostrarMensaje)
            {
                MessageBox.Show("El valor del campo " + nombreCampo + " debe ser un número", "Error en los datos de entrada", MessageBoxButtons.OK);
            }
            return false;
        }

        private static bool comaYPuntoCorrectos(string cadena)
        {
            if (cantidadEnCadena(cadena, '.') > 1)
                return false;

            if (cantidadEnCadena(cadena, ',') > 1)
                return false;
            
            if (cadena.Contains('.') && cadena.Contains(','))
                return false;
            
            return true;
        }


        //********** VALIDACIONES DE TEXTO ******//

        // El texto contiene al menos una letra
        public static Boolean esTexto(TextBox txtBox , string nombreCampo = "Opcional" , Boolean mostrarMensaje = false)
        {
            String textPattern = "[A-Za-z]";
            System.Text.RegularExpressions.Regex regexTexto = new System.Text.RegularExpressions.Regex(textPattern);
            if (regexTexto.IsMatch(txtBox.Text))
            {
                return true;
            }
            else
            {
                if (mostrarMensaje && !esVacio(txtBox))
                {
                    MessageBox.Show("Para el campo " + nombreCampo + " el criterio debe ser alfanumerico", "Error en el nombre", MessageBoxButtons.OK);
                    return false;
                }
                if(!esVacio(txtBox))
                return false;
            }
            return true;
        }

        // Valida que todos los caracteres sean o letras o espacios
        public static Boolean esSoloTexto(TextBox txtBox, string nombreCampo = "Opcional", Boolean mostrarMensaje = false)
        {
            string cadena = txtBox.Text;

            if (cadena == "")
                return true;

            if (cadena.All((car)=>Char.IsLetter(car) || Char.IsWhiteSpace(car)))
            {
                if (Char.IsWhiteSpace(cadena[0]))
                {
                    MessageBox.Show("El campo " + nombreCampo + " debe comenzar con una letra.", "Error en los datos de entrada", MessageBoxButtons.OK);
                    return false;
                }
                
                return true;
            }
            else
            {
                if (mostrarMensaje)
                {
                    MessageBox.Show("El campo " + nombreCampo + " debe contener solo letras o espacios.", "Error en los datos de entrada", MessageBoxButtons.OK);
                    return false;
                }
                return false;
            }
          
        }
        //Valida que el texto tenga primero una letra y luego un numero
        public static Boolean esTextoAlfanumerico(TextBox txtBox, Boolean primeroLetra,string nombreCampo = "Opcional", Boolean mostrarMensaje = false)
        {
            string cadena = txtBox.Text;
            Boolean huboErrores = false;

            if (cadena == "")
                return true;

            if(primeroLetra)
            {
                if (huboErrores = !Char.IsLetter(cadena[0]))
                {
                    MessageBox.Show("El campo " + nombreCampo + " debe comenzar con una letra.", "Error en los datos de entrada", MessageBoxButtons.OK);
                }
            }
                
            if (!cadena.All((car) => Char.IsLetterOrDigit(car)))
            {
                if (mostrarMensaje)
                {
                    MessageBox.Show("El campo " + nombreCampo + " debe contener solo letras o números.", "Error en los datos de entrada", MessageBoxButtons.OK);
                    
                }
                huboErrores = true;
            }

            if (!cadena.Any((car) => Char.IsLetter(car)))
            {
                if (mostrarMensaje)
                {
                    MessageBox.Show("El campo " + nombreCampo + " debe contener al menos una letra", "Error en los datos de entrada", MessageBoxButtons.OK);

                }
                huboErrores = true;
            }

            return !huboErrores;
        }

        


        //******* VALIDACIONES DE CAMPOS VACIOS ******//

        public static Boolean esVacio(TextBox txtBox, string nombreCampo = "Opcional", bool mostrarMensaje = false)
        {
            Boolean vacio = false;
            if (txtBox.TextLength == 0)
            {
                vacio = true;
                if (mostrarMensaje)
                {
                    MessageBox.Show("El campo " + nombreCampo + " no puede estar vacío", "Error en los datos de entrada", MessageBoxButtons.OK);
                }
            }

            return vacio;
        }

        
      //Valida que un numero sea de solo 4 cifras 
        public static Boolean esNumeroDe4(TextBox txt,string campo)
        {

            if (txt.TextLength == 4)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El campo'"+campo+"' debe tener 4 digitos", "Error en los datos de entrada", MessageBoxButtons.OK);
                return false;
            }

        }
        //combo box seleccionado
        public static Boolean estaSeleccionado(ComboBox combo , Boolean mostrarMensaje = false , String opcional = "opciones")
        {
            
            if (combo.SelectedIndex == -1)
            {
                if (mostrarMensaje)
                {
                    MessageBox.Show("Debe seleccionar un campo en el desplegable de " + opcional, "Error en el campo", MessageBoxButtons.OK);
                }
                return false;
            }
            return true;
        } 

        public static Boolean estaCheckeadoCheck(CheckBox check)
        {
            return check.Checked;
        }
        public static Boolean estaCheckeadoComboBox(ComboBox combo)
        {
            if (combo.SelectedItem == null) { return true; }
            return false;
        }


        internal static bool estaCheckeadoOpt(RadioButton option)
        {
            return option.Checked;
        }


        public static Boolean fechaPosteriorALaDeHoy(DateTimePicker dateTimePicker1)
        {
            if (dateTimePicker1.Value.CompareTo(Program.fechaHoy()) < 0)
            {
                MessageBox.Show("La fecha ingresada debe ser posterior a la fecha de hoy", "Error en los datos de entrada", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static Boolean fechaAnteriorALaDeHoy(DateTimePicker dateTimePicker1)
        {
            if (dateTimePicker1.Value.CompareTo(Program.fechaHoy()) > 0)
            {
                MessageBox.Show("La fecha ingresada debe ser anterior a la fecha de hoy", "Error en los datos de entrada", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        //Eventos de validacion de tipos de campos

        private static int cantidadEnCadena(string cadena, char caracter)
        {
            return cadena.Count((car) => car == caracter);
        }

        public static void controlIngresoNumeroEntero(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Back))
                return;

            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //******* VALIDACION DE LIMITES NUMERICOS********//

        public static Boolean estaEntreLimites(TextBox txt, decimal limiteInferior, decimal limiteSuperior,Boolean numeroDecimal,string nombreCampo)
        {
            string cadena = txt.Text;

            if (cadena == "")
                return true;

            if (numeroDecimal)
            {
                if (!esDecimal(txt))
                    return true;
            }
            else
            {
                if (!esNumero(txt))
                    return true;
            }


            decimal numero = Convert.ToDecimal(txt.Text.Replace(".",","));

            if (numero < limiteInferior || numero > limiteSuperior)
            {
                MessageBox.Show("El valor del campo " + nombreCampo + " debe estar entre " + limiteInferior.ToString() + " y " + limiteSuperior.ToString(), "Error en los datos de entrada", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

    }
}
