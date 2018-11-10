using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProyectoTopicos.Model;

namespace ProyectoTopicos.LogicaNegocio
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LogicaNegocio" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select LogicaNegocio.svc or LogicaNegocio.svc.cs at the Solution Explorer and start debugging.
	public class LogicaNegocio : ILogicaNegocio
	{
		public void DoWork()
		{
		}

		public IList<Articulos> ListarPorCategoria(string categoria)
		{
			var especificacion = new Logica.Especificacion.Articulo();
			var resultado = especificacion.ListarPorCategoria(categoria);
			return resultado;
		}
	}
}
