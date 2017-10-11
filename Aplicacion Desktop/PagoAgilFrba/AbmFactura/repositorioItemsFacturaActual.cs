using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.AbmFactura
{
    public class repositorioItemsFacturaActual
    {

        private ListaTuplasItems<String, String, String> listaItems = new ListaTuplasItems<String, String, String>();

        private static repositorioItemsFacturaActual instance;

        public repositorioItemsFacturaActual() {}

        public static repositorioItemsFacturaActual Instance
        {
            get 
            {
              if (instance == null)
              {
                 instance = new repositorioItemsFacturaActual();
              }
              return instance;
            }
        }

        public ListaTuplasItems<String, String, String> getListaItems(){
        
            return this.listaItems;
        }

        public void addToListaItems(String cantidad , String monto , String descripcion){
            
             this.listaItems.Add(cantidad ,monto,descripcion);
        }

        
    }
}
