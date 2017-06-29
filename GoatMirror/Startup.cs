using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoatMirror.Startup))]
namespace GoatMirror
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
