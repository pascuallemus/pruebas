using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebas.Backend.Startup))]
namespace pruebas.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
