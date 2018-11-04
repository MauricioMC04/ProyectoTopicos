using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoTopicos.Startup))]
namespace ProyectoTopicos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
