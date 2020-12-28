using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LianaBirushevaWeb.Startup))]
namespace LianaBirushevaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
