using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gbookWinAPP.Startup))]
namespace gbookWinAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
