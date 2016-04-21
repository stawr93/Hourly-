using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HourlySharp.Startup))]
namespace HourlySharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
