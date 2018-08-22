using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InCollegeWeb.Startup))]
namespace InCollegeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
