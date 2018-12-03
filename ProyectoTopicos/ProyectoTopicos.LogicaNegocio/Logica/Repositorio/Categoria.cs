using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class Categoria
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public Model.CategoriasArticulos GetCategoria(string categoria)
		{
			var resultado = _miContexto.CategoriasArticulos.Where(a => a.categoria.Equals(categoria)).ToList();
			return resultado[0];
		}

		public bool AddCategoria(string categoria)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into CategoriasArticulos values (@codigo, @categoria)", new SqlParameter("@codigo", (GetMaxCategoria() + 1).ToString()), new SqlParameter("@categoria", categoria));
			return true;
		}

		public int GetMaxCategoria()
		{
			var resultado = _miContexto.CategoriasArticulos.Max(a => a.codigoCategoria);
			return Convert.ToInt32(resultado);
		}
	}
}