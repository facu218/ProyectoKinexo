using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoKinexo.Startup))]
namespace ProyectoKinexo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
