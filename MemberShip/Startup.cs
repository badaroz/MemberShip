using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberShip.Startup))]
namespace MemberShip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
