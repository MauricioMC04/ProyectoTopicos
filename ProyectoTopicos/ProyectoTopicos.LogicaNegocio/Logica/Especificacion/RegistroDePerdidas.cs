using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class RegistroDePerdidas
	{
		public IList<Model.RegistroDePerdidas> ListarPorCodigoUsuario(string codigo)
		{
			var accion = new Accion.RegistroDePerdidas();
			var resultado = accion.ListarPorCodigoUsuario(codigo);
			return resultado;
		}

		public IList<Model.RegistroDePerdidas> ListarPorCategoria(string categoria)
		{
			var accion = new Accion.RegistroDePerdidas();
			var resultado = accion.ListarPorCategoria(categoria);
			return resultado;
		}

		public IList<Model.RegistroDePerdidas> ListarPorSubCategoria(string subCategoria)
		{
			var accion = new Accion.RegistroDePerdidas();
			var resultado = accion.ListarPorSubCategoria(subCategoria);
			return resultado;
		}

		public bool AddRegistroDePerdida(string codigoUsuario, string categoria, string subCategoria, string descripcion)
		{
			var accion = new Accion.RegistroDePerdidas();
			var resultado = accion.AddRegistroDePerdida(codigoUsuario, categoria, subCategoria, descripcion);
			return resultado;
		}
	}
}