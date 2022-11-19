using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SellerGear.Web.Startup))]
namespace SellerGear.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
