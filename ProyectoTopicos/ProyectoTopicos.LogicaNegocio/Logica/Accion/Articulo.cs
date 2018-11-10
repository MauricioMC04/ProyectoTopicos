using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Accion
{
	public class Articulo
	{

		public IList<Model.Articulos> ListarPorCategoria(string categoria)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.ListarPorCategoria(categoria);
			return resultado;
		}
	}
}