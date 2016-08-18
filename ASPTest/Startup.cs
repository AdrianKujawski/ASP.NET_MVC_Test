using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPTest.Startup))]
namespace ASPTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
