using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetBookstore.Startup))]
namespace AspNetBookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
