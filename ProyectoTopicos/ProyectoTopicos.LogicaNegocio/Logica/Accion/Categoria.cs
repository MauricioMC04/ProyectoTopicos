using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Accion
{
	public class Categoria
	{
		public Model.CategoriasArticulos GetCategoria(string categoria)
		{
			var repositorio = new Repositorio.Categoria();
			var resultado = repositorio.GetCategoria(categoria);
			return resultado;
		}

		public bool AddCategoria(string categoria)
		{
			var repositorio = new Repositorio.Categoria();
			return repositorio.AddCategoria(categoria);
		}
	}
}