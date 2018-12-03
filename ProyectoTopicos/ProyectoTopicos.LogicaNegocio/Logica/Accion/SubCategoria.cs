using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Accion
{
	public class SubCategoria
	{
		public Model.SubCategoriasArticulos GetSubCategoria(string subCategoria)
		{
			var repositorio = new Repositorio.SubCategoria();
			var resultado = repositorio.GetSubCategoria(subCategoria);
			return resultado;
		}

		public bool AddSubCategoria(string subCategoria)
		{
			var repositorio = new Repositorio.SubCategoria();
			return repositorio.AddSubCategoria(subCategoria);
		}
	}
}