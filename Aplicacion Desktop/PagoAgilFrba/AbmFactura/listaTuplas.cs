using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.AbmFactura
{
    public class ListaTuplasItems<T1, T2, T3> : List<Tuple<T1, T2, T3>>
    {
        public void Add(T1 cantidad, T2 monto, T3 descripcion)
        {
            Add(new Tuple<T1, T2, T3>(cantidad, monto, descripcion));
        }
    }
}
