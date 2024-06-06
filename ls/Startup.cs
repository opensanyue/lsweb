using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ls.Startup))]
namespace ls
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
