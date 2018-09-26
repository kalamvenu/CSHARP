using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(September24_2.Startup))]
namespace September24_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
