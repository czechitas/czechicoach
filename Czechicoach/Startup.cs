using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Czechicoach.Startup))]
namespace Czechicoach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
