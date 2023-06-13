using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AqsaCakeStore.Startup))]
namespace AqsaCakeStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
