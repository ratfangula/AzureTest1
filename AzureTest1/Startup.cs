using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTest1.Startup))]
namespace AzureTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
