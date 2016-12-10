using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebsite24.Startup))]
namespace TestWebsite24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
