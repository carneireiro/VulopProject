using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vulop.Startup))]
namespace Vulop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
