using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTopicos.Tests
{
	[TestClass]
	class UnitTest
	{
		[TestMethod]
		public void ConsultarArticulosPorCategoria()
		{
			// prepare el escenario
			var categoria = "Electronicos";
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
