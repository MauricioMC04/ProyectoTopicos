using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Accion
{
	public class Articulo
	{
		public IList<Model.Articulos> ListarPorCategoria(string categoria)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.ListarPorCategoria(categoria);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorSubCategoria(string subCategoria)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.ListarPorSubCategoria(subCategoria);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorEstado(string estado)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.ListarPorEstado(estado);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorFechaIngreso(string fechaIngreso)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.ListarPorFechaIngreso(fechaIngreso);
			return resultado;
		}

		public IList<Model.Articulos> ListarPorFechaEntrega(string fechaEntrega)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.ListarPorFechaEntrega(fechaEntrega);
			return resultado;
		}

		public Model.Articulos GetArticulo(string codigo)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.GetArticulo(codigo);
			return resultado;
		}

		public bool AddArticulo(string nombre, DateTime fechaIngreso, string estado, string categoria, string subCategoria, DateTime fechaEntrega, string descripcion)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.AddArticulo(nombre, fechaIngreso, estado, categoria, subCategoria, fechaEntrega, descripcion);
			return resultado;
		}

		public bool SetEstado(string codigo, string estado)
		{
			var repositorio = new Repositorio.Articulo();
			var resultado = repositorio.SetEstado(codigo, estado);
			return resultado;
		}
	}
}