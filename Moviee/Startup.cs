using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moviee.Startup))]
namespace Moviee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
