using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class RegistroDePerdidas
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public IList<Model.RegistroDePerdidas> ListarPorCodigoUsuario(string codigo)
		{
			var resultado = _miContexto.RegistroDePerdidas.Where(a => a.codigoUsuario.Equals(codigo)).ToList();
			return resultado;
		}

		public IList<Model.RegistroDePerdidas> ListarPorCategoria(string categoria)
		{
			var resultado = _miContexto.RegistroDePerdidas.Where(a => a.categoria.Equals(categoria)).ToList();
			return resultado;
		}

		public IList<Model.RegistroDePerdidas> ListarPorSubCategoria(string subCategoria)
		{
			var resultado = _miContexto.RegistroDePerdidas.Where(a => a.subCategoria.Equals(subCategoria)).ToList();
			return resultado;
		}

		public bool AddRegistroDePerdida(string codigoUsuario, string categoria, string subCategoria, string descripcion)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into RegistrosDePerdidas values (@codigo, @categoria, @subCategoria, @descripcion)", new SqlParameter("@codigo", codigoUsuario), new SqlParameter("@categoria", categoria), new SqlParameter("@subCategoria", subCategoria), new SqlParameter("@descripcion", descripcion));
			return true;
		}
	}
}