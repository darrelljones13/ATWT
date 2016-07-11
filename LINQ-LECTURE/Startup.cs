using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamerLinqDemoApp.Startup))]
namespace GamerLinqDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
