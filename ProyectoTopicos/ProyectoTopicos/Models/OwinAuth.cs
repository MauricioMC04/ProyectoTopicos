using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.ApplicationServices;

namespace ProyectoTopicos.Models
{
    public class OwinAuth
    {
        private readonly HttpContextBase _context;
        private const string AuthenticationType = "ApplicationCookie";

        public OwinAuth(HttpContextBase context)
        {
            _context = context;
        }

        public void SignIn(ProyectoTopicos.Model.Usuarios user)
        {
            IList<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.nombre),
            new Claim(ClaimTypes.Role, user.perfil)
        };

            ClaimsIdentity identity = new ClaimsIdentity(claims, AuthenticationType);

            IOwinContext context = _context.Request.GetOwinContext();
            IAuthenticationManager authenticationManager = context.Authentication;

            authenticationManager.SignIn(identity);
        }

        public void SignOut()
        {
            IOwinContext context = _context.Request.GetOwinContext();
            IAuthenticationManager authenticationManager = context.Authentication;

            authenticationManager.SignOut(AuthenticationType);
        }
    }
    
}