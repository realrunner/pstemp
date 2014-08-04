using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParkSavers.Startup))]
namespace ParkSavers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
