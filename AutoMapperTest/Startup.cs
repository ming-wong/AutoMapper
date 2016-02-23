using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoMapperTest.Startup))]
namespace AutoMapperTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
