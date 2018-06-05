using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web7Days.Startup))]
namespace Web7Days
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
