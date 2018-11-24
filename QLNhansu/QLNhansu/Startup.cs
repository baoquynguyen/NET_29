using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLNhansu.Startup))]
namespace QLNhansu

{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
