using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyEuroleague.Startup))]
namespace FantasyEuroleague
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
