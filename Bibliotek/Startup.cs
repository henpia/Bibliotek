using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bibliotek.Startup))]
namespace Bibliotek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
