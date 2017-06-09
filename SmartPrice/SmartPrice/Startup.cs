using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartPrice.Startup))]
namespace SmartPrice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
