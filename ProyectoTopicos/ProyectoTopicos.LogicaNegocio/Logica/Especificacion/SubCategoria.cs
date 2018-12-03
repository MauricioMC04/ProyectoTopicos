using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class SubCategoria
	{
		public Model.SubCategoriasArticulos GetSubCategoria(string subCategoria)
		{
			var accion = new Accion.SubCategoria();
			var resultado = accion.GetSubCategoria(subCategoria);
			return resultado;
		}

		public bool AddSubCategoria(string subCategoria)
		{
			var accion = new Accion.SubCategoria();
			return accion.AddSubCategoria(subCategoria);
		}
	}
}