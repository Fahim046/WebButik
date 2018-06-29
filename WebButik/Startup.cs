using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebButik.Startup))]
namespace WebButik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
