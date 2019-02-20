using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part_5.Startup))]
namespace Part_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
