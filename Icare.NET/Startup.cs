using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Icare.NET.Startup))]
namespace Icare.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
