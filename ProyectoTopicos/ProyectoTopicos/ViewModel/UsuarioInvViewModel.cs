using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ProyectoTopicos.Model;
namespace ProyectoTopicos.ViewModel
{
    public class UsuarioInvViewModel
    {
        public List<ArticulosDTO> ListaArticulos { get; set; }
        public List<SelectListItem> listaCategorias { get; set; }
        public List<SelectListItem> listaSubCategorias { get; set; }

        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public string estado { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public Nullable<System.DateTime> fechaEntrega { get; set; }
        public string descripcion { get; set; }

    }
}