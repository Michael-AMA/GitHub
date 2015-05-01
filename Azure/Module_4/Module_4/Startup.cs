using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module_4.Startup))]
namespace Module_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
