using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VittighederWeb.Startup))]
namespace VittighederWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
