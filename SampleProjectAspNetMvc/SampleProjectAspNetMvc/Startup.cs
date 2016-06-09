using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleProjectAspNetMvc.Startup))]
namespace SampleProjectAspNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
