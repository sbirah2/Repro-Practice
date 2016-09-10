using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repro_Website.Startup))]
namespace Repro_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
