using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDev.Startup))]
namespace WebDev
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
