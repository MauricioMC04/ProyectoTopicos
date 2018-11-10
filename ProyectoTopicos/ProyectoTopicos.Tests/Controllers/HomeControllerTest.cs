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
	}
}
