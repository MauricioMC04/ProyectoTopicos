using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class RegistroDevolucion
	{
		public IList<Model.RegistroDevoluciones1> ListarPorCodigoUsuario(string codigo)
		{
			var accion = new Accion.RegistroDevolucion();
			var resultado = accion.ListarPorCodigoUsuario(codigo);
			return resultado;
		}

		public bool AddRegistroDevolucion(string codigoUsuario, string codigoArticulo)
		{
			var accion = new Accion.RegistroDevolucion();
			var resultado = accion.AddRegistroDevolucion(codigoUsuario, codigoArticulo);
			return resultado;
		}
	}
}