using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blahgger.Startup))]
namespace Blahgger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
