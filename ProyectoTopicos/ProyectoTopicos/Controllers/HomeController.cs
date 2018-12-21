
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
        private OwinAuth Auth;

        public HomeController()
        {
            var cont = new System.Web.HttpContextWrapper(System.Web.HttpContext.Current);
            Auth = new OwinAuth(cont as HttpContextBase);
        }

        [Authorize]
		public ActionResult Index()
		{
            
			return View();
		}
        [Authorize]
        public ActionResult About()
		{
			ViewBag.Message = "Bienvenidos a la Ulatina";

			return View();
		}
        [Authorize]
        public ActionResult Contact()
		{
			ViewBag.Message = "Información de Contacto";

			return View();
		}

        [HttpGet]
        [AllowAnonymous]
       
        public ActionResult Login()
        {
            ViewBag.Message = "Inicio de Sesión";

            return View();
        }

        [AllowAnonymous]
        public ActionResult LogOut()
        {
            Auth.SignOut();
            return RedirectToAction("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginInfo modelo)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mensaje = "El modelo no esta correcto";
                return View();
            }
            var usuarioRepo = new Usuario();
            var usuario = usuarioRepo.GetUsuario(modelo.TipoCuenta, modelo.Contrasenna);
            //Validar contrasenna
            if (usuario == null) {
                ViewBag.Mensaje = "Contraseña incorrecta";
                return View();
            }
            Auth.SignIn(usuario);
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
        [Authorize]
        public ActionResult UsuarioAdm()
        {
            ViewBag.Message = "Usuario Administrador";

            return View(); 

        }
        [Authorize]
        public ActionResult UsuarioCus()
        {
            ViewBag.Message = "Usuario de Custodia";

            return View();

        }
        [Authorize]
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
        [Authorize]
        public ActionResult UsuarioInvGuardar(UsuarioInvViewModel modelo)
        {
            Articulo art = new Articulo();
            art.AddArticulo(modelo.nombre, DateTime.Now, "AC", modelo.categoria, modelo.subCategoria, DateTime.Now, modelo.descripcion);

            return Redirect("/Home/UsuarioInv#articulo");
        }
        [Authorize]
        public ActionResult UsuarioInvDel(int id) {
            Articulo art = new Articulo();
            art.EliminarArt(id);
            return Redirect("/Home/UsuarioInv#articulo");
        }
    }
}