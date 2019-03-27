using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(laptrinhweb.Startup))]
namespace laptrinhweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
