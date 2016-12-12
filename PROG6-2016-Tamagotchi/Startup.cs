using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROG6_2016_Tamagotchi.Startup))]
namespace PROG6_2016_Tamagotchi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
