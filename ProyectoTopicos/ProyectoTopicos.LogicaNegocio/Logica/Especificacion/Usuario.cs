using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class Usuario
	{
		public bool AddUsuario(string nombre, string correo, string perfil)
		{
			var accion = new Accion.Usuario();
			return accion.AddUsuario(nombre, correo, perfil);
		}

		public Model.Usuarios GetUsuario(string codigo)
		{
			var accion = new Accion.Usuario();
			return accion.GetUsuario(codigo);
		}
	}
}