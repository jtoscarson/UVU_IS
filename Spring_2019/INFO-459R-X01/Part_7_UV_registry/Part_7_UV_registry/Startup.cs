using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part_7_UV_registry.Startup))]
namespace Part_7_UV_registry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
