using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStoreFramework.Startup))]
namespace OnlineStoreFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
