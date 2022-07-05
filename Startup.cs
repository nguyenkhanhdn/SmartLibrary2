using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartLibrary2.Startup))]
namespace SmartLibrary2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
