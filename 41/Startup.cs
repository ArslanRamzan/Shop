using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_41.Startup))]
namespace _41
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
