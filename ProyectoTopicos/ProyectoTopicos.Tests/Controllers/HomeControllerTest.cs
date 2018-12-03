using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoTopicos;
using ProyectoTopicos.Controllers;

namespace ProyectoTopicos.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void About()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.About() as ViewResult;

			// Assert
			Assert.AreEqual("Your application description page.", result.ViewBag.Message);
		}

		[TestMethod]
		public void Contact()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Contact() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void ConsultarArticulosPorCategoria()
		{
			// prepare el escenario
			var categoria = "1";
			var especificacion = new LogicaNegocio.Logica.Especificacion.Articulo();
			var elResultadoEsperado = 1;

			// ejecute el método deseado
			var elResultadoReal = especificacion.ListarPorCategoria(categoria);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal.Count == elResultadoEsperado);
		}

		[TestMethod]
		public void ConsultarCategoria()
		{
			// prepare el escenario
			var categoria = "Electronicos";
			var especificacion = new LogicaNegocio.Logica.Especificacion.Categoria();
			var elResultadoEsperado = "1";

			// ejecute el método deseado
			var elResultadoReal = especificacion.GetCategoria(categoria);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal.codigoCategoria == elResultadoEsperado);
		}

		[TestMethod]
		public void ConsultarSubCategoria()
		{
			// prepare el escenario
			var subCategoria = "Celulares";
			var especificacion = new LogicaNegocio.Logica.Especificacion.SubCategoria();
			var elResultadoEsperado = "1";

			// ejecute el método deseado
			var elResultadoReal = especificacion.GetSubCategoria(subCategoria);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal.codigoSubCategoria == elResultadoEsperado);
		}

		[TestMethod]
		public void AddSubCategoria()
		{
			// prepare el escenario
			var subCategoria = "Test";
			var especificacion = new LogicaNegocio.Logica.Especificacion.SubCategoria();
			var elResultadoEsperado = true;

			// ejecute el método deseado
			var elResultadoReal = especificacion.AddSubCategoria(subCategoria);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal == elResultadoEsperado);
		}

		[TestMethod]
		public void AddCategoria()
		{
			// prepare el escenario
			var categoria = "Test";
			var especificacion = new LogicaNegocio.Logica.Especificacion.Categoria();
			var elResultadoEsperado = true;

			// ejecute el método deseado
			var elResultadoReal = especificacion.AddCategoria(categoria);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal == elResultadoEsperado);
		}

		[TestMethod]
		public void ConsultarArticulosPorSubCategoria()
		{
			// prepare el escenario
			var subCategoria = "1";
			var especificacion = new LogicaNegocio.Logica.Especificacion.Articulo();
			var elResultadoEsperado = 1;

			// ejecute el método deseado
			var elResultadoReal = especificacion.ListarPorCategoria(subCategoria);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal.Count == elResultadoEsperado);
		}

		[TestMethod]
		public void ConsultarArticulosPorFechaIngreso()
		{
			// prepare el escenario
			var fechaIngreso = "2018-07-11";
			var especificacion = new LogicaNegocio.Logica.Especificacion.Articulo();
			var elResultadoEsperado = 2;

			// ejecute el método deseado
			var elResultadoReal = especificacion.ListarPorFechaIngreso(fechaIngreso);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal.Count == elResultadoEsperado);
		}

		[TestMethod]
		public void AddArticulo()
		{
			// prepare el escenario
			string nombre = "Test";
			DateTime fechaIngreso = Convert.ToDateTime("2018-02-12");
			string estado = "Test";
			string categoria = "1";
			string subCategoria = "1";
			DateTime fechaEntrega = Convert.ToDateTime("2018-02-12");
			string descripcion = "Test"; 
			var especificacion = new LogicaNegocio.Logica.Especificacion.Articulo();
			var elResultadoEsperado = true;

			// ejecute el método deseado
			var elResultadoReal = especificacion.AddArticulo(nombre, fechaIngreso, estado, categoria, subCategoria, fechaEntrega, descripcion);

			// verifique
			Assert.IsNotNull(elResultadoReal);
			Assert.IsTrue(elResultadoReal == elResultadoEsperado);
		}
	}
}
