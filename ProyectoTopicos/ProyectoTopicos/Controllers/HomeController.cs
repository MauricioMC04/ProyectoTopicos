using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTopicos.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Bienvenidos a la Ulatina";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Información de Contacto";

			return View();
		}

        public ActionResult Login()
        {
            ViewBag.Message = "Inicio de Sesión";

            return View();
        }

        public ActionResult UsuarioAdm()
        {
            ViewBag.Message = "Usuario Administrador";

            return View(); 

        }
        public ActionResult UsuarioCus()
        {
            ViewBag.Message = "Usuario de Custodia";

            return View();

        }

        public ActionResult UsuarioInv()
        {
            ViewBag.Message = "Usuario Invitado";

            return View();

        }
    }
}