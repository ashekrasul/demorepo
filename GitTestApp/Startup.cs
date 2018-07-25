using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTestApp.Startup))]
namespace GitTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
