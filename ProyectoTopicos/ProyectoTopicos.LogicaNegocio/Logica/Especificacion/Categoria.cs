using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class Categoria
	{
		public Model.CategoriasArticulos GetCategoria(string categoria)
		{
			var accion = new Accion.Categoria();
			var resultado = accion.GetCategoria(categoria);
			return resultado;
		}

		public bool AddCategoria(string categoria)
		{
			var accion = new Accion.Categoria();
			return accion.AddCategoria(categoria);
		}
	}
}