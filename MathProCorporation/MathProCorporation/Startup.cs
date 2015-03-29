using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathProCorporation.Startup))]

namespace MathProCorporation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}