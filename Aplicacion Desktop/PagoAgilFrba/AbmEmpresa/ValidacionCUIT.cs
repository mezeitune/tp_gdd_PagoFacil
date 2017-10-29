using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.AbmEmpresa
{
    sealed class ValidacionCUIT
    {
        // Algoritmo de validacion de CUIT.
        public static bool Validar(String cuit)
        {
            if (cuit.Length != 11)
                return false;

            int[] serie = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

            int verificador = 0;

            for (int i = 0; i < serie.Length; i++)
                verificador += (int)Char.GetNumericValue(cuit[i]) * serie[i];

            verificador = 11 - (verificador % 11);
            verificador %= 11;

            return Char.GetNumericValue(cuit[10]).Equals(verificador);
        }
    }
}
