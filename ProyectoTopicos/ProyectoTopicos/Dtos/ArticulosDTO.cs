using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos
{
    public class ArticulosDTO
    {
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }

        public string subCategoria { get; set; }

        public string descripcion { get; set; }
    
    }
}