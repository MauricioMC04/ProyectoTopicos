using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTopicos.ViewModel
{
    public class UsuarioAdmViewModel
    {
        public List<Dtos.UsuarioDTO> ListaUsuarios { get; set; }
        public List<SelectListItem> ListaPerfiles { get; set; }

        public string codigoUsuario { get; set; }
        public string codigoPerfil { get; set; }
        //public string nombreUsuario { get; set; }
        //public string nombrePerfil { get; set; }


        
    }
}