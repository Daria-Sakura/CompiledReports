using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompiledReports.Web.UI.Startup))]
namespace CompiledReports.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
