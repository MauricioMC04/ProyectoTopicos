
using ProyectoTopicos.Models;
using ProyectoTopicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoTopicos.LogicaNegocio.Logica.Repositorio;

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
            Articulo art = new Articulo();
            var categorias = new Categoria();
            var subCategoria = new SubCategoria();

            var lista = art.ObtenerTodos();
            var listaCategorias = categorias.getAll();
            var listaSub = subCategoria.getAll();

            var viewModel = new UsuarioInvViewModel
            {
                ListaArticulos = lista.Select(r => new ArticulosDTO {
                    categoria = r.CategoriasArticulos.categoria,
                    codigoArticulo = r.codigoArticulo,
                    descripcion = r.descripcion,
                    nombre = r.nombre,
                    subCategoria = r.SubCategoriasArticulos.subCategoria

                }).ToList()
                ,
                listaCategorias = listaCategorias.Select(r => new SelectListItem {
                    Text = r.categoria,
                    Value = r.codigoCategoria
                }).ToList(),
                listaSubCategorias = listaSub.Select(r => new SelectListItem {
                    Text = r.subCategoria,
                    Value = r.codigoSubCategoria
                }).ToList()
            };
            ViewBag.Message = "Usuario Invitado";

            return View(viewModel);

        }

        public ActionResult UsuarioInvGuardar(UsuarioInvViewModel modelo)
        {
            Articulo art = new Articulo();
            art.AddArticulo(modelo.nombre, DateTime.Now, "AC", modelo.categoria, modelo.subCategoria, DateTime.Now, modelo.descripcion);

            return Redirect("/Home/UsuarioInv#articulo");
        }

        public ActionResult UsuarioInvDel(int id) {
            Articulo art = new Articulo();
            art.EliminarArt(id);
            return Redirect("/Home/UsuarioInv#articulo");
        }
    }
}