using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamFic.Startup))]
namespace TeamFic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
