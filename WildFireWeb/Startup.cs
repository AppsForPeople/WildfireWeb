using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WildFireWeb.Startup))]
namespace WildFireWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
