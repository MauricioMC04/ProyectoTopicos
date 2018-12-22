using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.ViewModel
{
    public class ParametroAdmViewModel
    {
        public List<Dtos.ParametroDTO> ListaParametro { get; set; }
        
        public string codigoParametro { get; set; }
    }
}