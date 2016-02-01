using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Remindz.Startup))]
namespace Remindz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
