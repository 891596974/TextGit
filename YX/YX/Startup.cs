using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YX.Startup))]
namespace YX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
