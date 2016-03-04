using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPFinal.Startup))]
namespace TPFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
