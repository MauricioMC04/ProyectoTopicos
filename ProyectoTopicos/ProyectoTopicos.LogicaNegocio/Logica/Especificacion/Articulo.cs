using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Especificacion
{
	public class Articulo
	{

		public IList<Model.Articulos> ListarPorCategoria(string categoria)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.ListarPorCategoria(categoria);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorSubCategoria(string subCategoria)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.ListarPorSubCategoria(subCategoria);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorEstado(string estado)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.ListarPorEstado(estado);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorFechaIngreso(string fechaIngreso)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.ListarPorFechaIngreso(fechaIngreso);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorFechaEntrega(string fechaEntrega)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.ListarPorFechaEntrega(fechaEntrega);
			return resultado;
		}

		public Model.Articulos GetArticulo(string codigo)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.GetArticulo(codigo);
			return resultado;
		}

		public bool AddArticulo(string nombre, DateTime fechaIngreso, string estado, string categoria, string subCategoria, DateTime fechaEntrega, string descripcion)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.AddArticulo(nombre, fechaIngreso, estado, categoria, subCategoria, fechaEntrega, descripcion);
			return resultado;
		}

		public bool SetEstado(string codigo , string estado)
		{
			var accion = new Accion.Articulo();
			var resultado = accion.SetEstado(codigo, estado);
			return resultado;
		}
	}
}