using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDNInMVC.Startup))]
namespace CDNInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
