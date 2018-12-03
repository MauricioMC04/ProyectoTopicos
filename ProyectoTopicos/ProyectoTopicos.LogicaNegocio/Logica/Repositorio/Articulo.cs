using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
	public class Articulo
	{
		Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

		public IList<Model.Articulos> ListarPorCategoria(string categoria)
		{
			var resultado = _miContexto.Articulos.Where(a => a.categoria.Equals(categoria)).ToList();
			return resultado;
		}

		public IList<Model.Articulos> ListarPorSubCategoria(string subCategoria)
		{
			var resultado = _miContexto.Articulos.Where(a => a.subCategoria.Equals(subCategoria)).ToList();
			return resultado;
		}

		public IList<Model.Articulos> ListarPorEstado(string estado)
		{
			var resultado = _miContexto.Articulos.Where(a => a.estado.Equals(estado)).ToList();
			return resultado;
		}

		public IList<Model.Articulos> ListarPorFechaIngreso(string fechaIngreso)
		{
			DateTime date = Convert.ToDateTime(fechaIngreso);
			var resultado = _miContexto.Articulos.Where(a => a.fechaIngreso.Equals(date.Date)).ToList();
			return resultado;
		}

		public IList<Model.Articulos> ListarPorFechaEntrega(string fechaEntrega)
		{
			DateTime date = Convert.ToDateTime(fechaEntrega);
			var resultado = _miContexto.Articulos.Where(a => a.fechaEntrega.Equals(date.Date)).ToList();
			return resultado;
		}

		public Model.Articulos GetArticulo(string codigo)
		{
			var resultado = _miContexto.Articulos.Where(a => a.codigoArticulo.Equals(codigo)).ToList();
			return resultado[0];
		}

		public bool AddArticulo(string nombre, DateTime fechaIngreso, string estado, string categoria, string subCategoria, DateTime fechaEntrega, string descripcion)
		{
			_miContexto.Database.ExecuteSqlCommand("insert into Articulos values (@codigo, @nombre, @fechaIngreso, @estado, @categoria, @subCategoria, @fechaEntrega, @descripcion)", new SqlParameter("@codigo", (GetMaxArticulo() + 1).ToString()), new SqlParameter("@nombre", nombre), new SqlParameter("@fechaIngreso", fechaIngreso), new SqlParameter("@estado", estado), new SqlParameter("@categoria", categoria), new SqlParameter("@subCategoria", subCategoria), new SqlParameter("@fechaEntrega", fechaEntrega), new SqlParameter("@descripcion", descripcion));
			return true;
		}

		public int GetMaxArticulo()
		{
			var resultado = _miContexto.Articulos.Max(a => a.codigoArticulo);
			return Convert.ToInt32(resultado);
		}

		public bool SetEstado(string codigo, string estado)
		{
			_miContexto.Database.ExecuteSqlCommand("Update Articulos set estado = @estado where codigoArticulo = @codigo", new SqlParameter("@estado", estado), new SqlParameter("@codigo", codigo));
			return true;
		}
	}
}