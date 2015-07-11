using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicacionApp.Startup))]
namespace PublicacionApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
