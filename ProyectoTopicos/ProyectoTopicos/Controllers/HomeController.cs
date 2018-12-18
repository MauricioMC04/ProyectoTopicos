using ProyectoTopicos.Models;
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

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Inicio de Sesión";

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginInfo modelo)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mensaje = "El modelo no esta correcto";
                return View();
            }

            //Validar contrasenna
            var n = 2;
            if (n==1) {
                ViewBag.Mensaje = "Contraseña incorrecta";
                
                return View();
            }
            switch (modelo.TipoCuenta)
            {
                case "Adm":
                    return RedirectToAction("UsuarioAdm");
                case "Cus":
                    return RedirectToAction("UsuarioCus");
                case "Inv":
                    return RedirectToAction("UsuarioInv");
                default:
                    ViewBag.Mensaje = "Usuario no valido";
                    return View();
            }
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