using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDevLab8.Startup))]
namespace WebDevLab8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
