using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamHub.Startup))]
namespace JamHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
