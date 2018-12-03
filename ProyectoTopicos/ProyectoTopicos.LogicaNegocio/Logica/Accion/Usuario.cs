using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Accion
{
	public class Usuario
	{
		public bool AddUsuario(string nombre, string correo, string perfil)
		{
			var repositorio = new Repositorio.Usuario();
			return repositorio.AddUsuario(nombre, correo , perfil);
		}

		public Model.Usuarios GetUsuario(string codigo)
		{
			var repositorio = new Repositorio.Usuario();
			return repositorio.GetUsuario(codigo);
		}
	}
}