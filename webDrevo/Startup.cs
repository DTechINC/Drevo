using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webDrevo.Startup))]
namespace webDrevo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
