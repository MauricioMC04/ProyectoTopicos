using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class RegistroDevolucion
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public IList<Model.RegistroDevoluciones1> ListarPorCodigoUsuario(string codigo)
		{
			var resultado = _miContexto.RegistroDevoluciones1Set.Where(a => a.codigoUsuario.Equals(codigo)).ToList();
			return resultado;
		}

		public bool AddRegistroDevolucion(string codigoUsuario, string codigoArticulo)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into RegistrosDevoluciones values (@codigo, @codigoUsuario, @codigoArticulo)", new SqlParameter("@codigo", (GetMaxRegistroDevolucion() + 1).ToString()), new SqlParameter("@codigoUsuario", codigoUsuario), new SqlParameter("@codigoArticulo", codigoArticulo));
			return true;
		}

		public int GetMaxRegistroDevolucion()
		{
			var resultado = _miContexto.RegistroDevoluciones1Set.Max(a => a.codigoDevolucion);
			return Convert.ToInt32(resultado);
		}
	}
}