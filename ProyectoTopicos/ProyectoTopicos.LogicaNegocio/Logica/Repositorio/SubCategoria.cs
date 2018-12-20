using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class SubCategoria
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public Model.SubCategoriasArticulos GetSubCategoria(string subCategoria)
		{
			var resultado = _miContexto.SubCategoriasArticulos.Where(a => a.subCategoria.Equals(subCategoria)).ToList();
			return resultado[0];
		}

        public List<Model.SubCategoriasArticulos> getAll()
        {
            return _miContexto.SubCategoriasArticulos.ToList();
        }

        public bool AddSubCategoria(string subCategoria)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into SubCategoriasArticulos values (@codigo, @subCategoria)", new SqlParameter("@codigo", (GetMaxSubCategoria() + 1).ToString()), new SqlParameter("@subCategoria", subCategoria));
			return true;
		}

		public int GetMaxSubCategoria()
		{
			var resultado = _miContexto.SubCategoriasArticulos.Max(a => a.codigoSubCategoria);
			return Convert.ToInt32(resultado);
		}
	}
}