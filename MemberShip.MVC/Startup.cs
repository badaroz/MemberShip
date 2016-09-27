using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberShip.MVC.Startup))]
namespace MemberShip.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
