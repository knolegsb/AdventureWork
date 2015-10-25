using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventureWork.Startup))]
namespace AdventureWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
