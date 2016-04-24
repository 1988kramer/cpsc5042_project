using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eServeSU.Startup))]
namespace eServeSU
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
