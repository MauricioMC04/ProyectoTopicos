using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Accion
{
	public class Perfil
	{
		public bool AddPerfil(string perfil)
		{
			var repositorio = new Repositorio.Perfil();
			return repositorio.AddPerfil(perfil);
		}
	}
}