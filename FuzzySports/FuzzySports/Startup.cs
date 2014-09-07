using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuzzySports.Startup))]
namespace FuzzySports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
