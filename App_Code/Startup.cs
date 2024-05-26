using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurdOperation.Startup))]
namespace CurdOperation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
