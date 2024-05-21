using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdvancedNext.Startup))]
namespace AdvancedNext
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
