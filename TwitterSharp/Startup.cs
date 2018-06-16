using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterSharp.Startup))]
namespace TwitterSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
