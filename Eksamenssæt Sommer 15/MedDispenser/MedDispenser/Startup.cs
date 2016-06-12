using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedDispenser.Startup))]
namespace MedDispenser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
