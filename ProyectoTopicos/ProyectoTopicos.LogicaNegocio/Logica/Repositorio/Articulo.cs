using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class Articulo
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public IList<Model.Articulos> ListarPorCategoria(string categoria)
		{
			var resultado = _miContexto.Articulos.Where(a => a.categoria.Equals(categoria)).ToList();
			return resultado;
		}
	}
}