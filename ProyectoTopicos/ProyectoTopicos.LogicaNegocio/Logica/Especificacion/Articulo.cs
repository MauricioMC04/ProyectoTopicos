using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class Articulo
	{

		public IList<Model.Articulos> ListarPorCategoria(string categoria)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.ListarPorCategoria(categoria);
			return resultado;
		}
	}
}