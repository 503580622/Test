using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstASPMvc.Startup))]
namespace MyFirstASPMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
