using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contoso1.Startup))]
namespace Contoso1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
