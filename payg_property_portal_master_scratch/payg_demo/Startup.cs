using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(payg_demo.Startup))]
namespace payg_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
