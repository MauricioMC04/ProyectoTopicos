using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class Perfil
	{
		public bool AddPerfil(string perfil)
		{
			var accion = new Accion.Perfil();
			return accion.AddPerfil(perfil);
		}
	}
}