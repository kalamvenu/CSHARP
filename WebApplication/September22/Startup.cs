using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(September22.Startup))]
namespace September22
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
