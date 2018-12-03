using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class Usuario
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public Model.Usuarios GetUsuario(string codigo)
		{
			var resultado = _miContexto.Usuarios.Where(a => a.codigoUsuario.Equals(codigo)).ToList();
			return resultado[0];
		}

		public bool AddUsuario(string nombre, string correo, string perfil)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into Usuarios values (@codigo, @nombre, @correo, @perfil)", new SqlParameter("@codigo", (GetMaxUsuario() + 1).ToString()), new SqlParameter("@nombre", nombre), new SqlParameter("@correo", correo), new SqlParameter("@perfil", perfil));
			return true;
		}

		public int GetMaxUsuario()
		{
			var resultado = _miContexto.Usuarios.Max(a => a.codigoUsuario);
			return Convert.ToInt32(resultado);
		}
	}
}