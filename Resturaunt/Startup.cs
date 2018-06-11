using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resturaunt.Startup))]
namespace Resturaunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
