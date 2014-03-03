using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_App.Startup))]
namespace MVC_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
