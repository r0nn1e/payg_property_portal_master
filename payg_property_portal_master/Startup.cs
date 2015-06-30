using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(payg_property_portal_master.Startup))]
namespace payg_property_portal_master
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
