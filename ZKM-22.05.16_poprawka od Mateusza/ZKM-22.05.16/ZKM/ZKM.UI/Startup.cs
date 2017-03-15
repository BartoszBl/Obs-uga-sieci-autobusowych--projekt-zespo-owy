using Microsoft.Owin;
using Owin;
using ZKM.UI;

[assembly: OwinStartup(typeof(Startup))]
namespace ZKM.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
