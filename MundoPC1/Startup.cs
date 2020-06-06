using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MundoPC1.Startup))]
namespace MundoPC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
