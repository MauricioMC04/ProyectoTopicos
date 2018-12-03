using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class Perfil
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public bool AddPerfil(string perfil)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into Perfiles values (@codigo, @perfil)", new SqlParameter("@codigo", (GetMaxPerfil() + 1).ToString()), new SqlParameter("@perfil", perfil));
			return true;
		}

		public int GetMaxPerfil()
		{
			var resultado = _miContexto.Perfiles.Max(a => a.codigoPerfil);
			return Convert.ToInt32(resultado);
		}
	}
}