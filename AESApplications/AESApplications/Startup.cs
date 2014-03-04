using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AESApplications.Startup))]
namespace AESApplications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
