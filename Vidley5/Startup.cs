using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidley5.Startup))]
namespace Vidley5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
