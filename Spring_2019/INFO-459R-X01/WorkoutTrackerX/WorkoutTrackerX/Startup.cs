using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkoutTrackerX.Startup))]
namespace WorkoutTrackerX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
