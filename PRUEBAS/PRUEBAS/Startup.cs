using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRUEBAS.Startup))]
namespace PRUEBAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
